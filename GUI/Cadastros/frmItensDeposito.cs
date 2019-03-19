using BLL;
using DAL;
using MODELO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmItensDeposito : GUI.frmModeloCadastro
    {
        public int codigodeposito = 0;

        public frmItensDeposito()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txbItDepCodProd.Clear();
            txbItDepNomeAbr.Clear();
            lblItDepNomeProd.Text = "";
            lblItDepNome.Text = "";
        }

        private void frmItensDeposito_Load(object sender, EventArgs e)
        {
            frmPrincipal frt = new frmPrincipal();
            ((frmPrincipal)Application.OpenForms["frmPrincipal"]).LblTituloPrincipal.Text = frt.LblTituloPrincipal.Text + " - " + this.Text;
        }
        
        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            alterabotoes(2);
            txbItDepCodProd.Focus();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaItensDeposito f = new frmConsultaItensDeposito();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txbItDepCodProd.Text = f.codigo.ToString("D6");
                txbItDepNomeAbr.Text = f.deposito.ToString() ;

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(Convert.ToInt32(txbItDepCodProd.Text));

                lblItDepNomeProd.Text = modelo.ProdNome.ToString();

                BLLDeposito blld = new BLLDeposito(cx);
                ModeloDeposito modelodep = blld.CarregaModeloDepositoAbr(txbItDepNomeAbr.Text);

                lblItDepNome.Text = modelodep.DepNome.ToString();
                             
                alterabotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alterabotoes(1);
            }
            f.Dispose();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alterabotoes(2);
            txbItDepCodProd.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                //leitrua dos dados
                ModeloItensDeposito modelo = new ModeloItensDeposito();

                modelo.DepCodProd = Convert.ToInt32(txbItDepCodProd.Text);
                modelo.DepProdAbrev = txbItDepNomeAbr.Text;

                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLItensDeposito bll = new BLLItensDeposito(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar um grupo
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuadio: Código " + modelo.DepCodProd.ToString());
                }
                else
                {
                    //alterar um grupo
                    modelo.DepCodProd = Convert.ToInt32(txbItDepCodProd.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado com sucesso.");
                }

                this.LimpaTela();
                this.alterabotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show("frmItensDeposito, btnSalvar - " + erro.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaTela();
            this.alterabotoes(1);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLItensDeposito bll = new BLLItensDeposito(cx);
                    bll.Excluir(Convert.ToInt32(txbItDepCodProd.Text));
                    this.LimpaTela();
                    this.alterabotoes(1);
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro esta sendo utilizado em outro local.");
                this.alterabotoes(3);
            }
        }

        private void txbItDepCodProd_Enter(object sender, EventArgs e)
        {
            txbItDepCodProd.BackColor = Color.LemonChiffon;

        }

        private void txbItDepCodProd_Leave(object sender, EventArgs e)
        {
            txbItDepCodProd.BackColor = Color.WhiteSmoke;
            localizaProduto();
        }

        private void txbItDepNomeAbr_Enter(object sender, EventArgs e)
        {
            txbItDepNomeAbr.BackColor = Color.LemonChiffon;
        }

        private void txbItDepNomeAbr_Leave(object sender, EventArgs e)
        {
            txbItDepNomeAbr.BackColor = Color.WhiteSmoke;
        }

        private void btntDepLocProd_Click(object sender, EventArgs e)
        {
            frmConsultaSpProduto f = new frmConsultaSpProduto();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txbItDepCodProd.Text = Convert.ToString(f.codigo);
                txbItDepCodProd.Focus();                
            }

            localizaProduto();
        }

        private void btnItDepLocDep_Click(object sender, EventArgs e)
        {
            frmConsultaDeposito f = new frmConsultaDeposito();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                codigodeposito = f.codigo;
            }

            localizaDeposito();    
        }

        private void localizaProduto()
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(Convert.ToInt32(txbItDepCodProd.Text));

                if (modelo.ProdCodigo <= 0)
                {
                    MessageBox.Show("Produto não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    txbItDepCodProd.Focus();
                }
                else
                {
                    txbItDepCodProd.Text = modelo.ProdCodigo.ToString("D6");
                    lblItDepNomeProd.Text = modelo.ProdNome.ToString();
                }
            }
            catch
            {
                //MessageBox.Show("Informe o produto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //txbItDepCodProd.Clear();
            }
        }

        private void localizaDeposito()
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLDeposito bll = new BLLDeposito(cx);
                ModeloDeposito modelo = bll.CarregaModeloDeposito(codigodeposito);

                if (modelo.DepAbrev.ToString() == "")
                {
                    MessageBox.Show("Depósito não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    txbItDepNomeAbr.Focus();
                }
                else
                {
                    txbItDepNomeAbr.Text = modelo.DepAbrev;
                    lblItDepNome.Text = modelo.DepNome;
                    txbItDepNomeAbr.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Informe o depósito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbItDepNomeAbr.Clear();
            }
        }
    }      
}
