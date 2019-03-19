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
    public partial class frmTipoPagamento : GUI.frmModeloCadastro
    {
        public frmTipoPagamento()
        {
            InitializeComponent();
        }

        private void frmTipoPagamento_Load(object sender, EventArgs e)
        {
            frmPrincipal frt = new frmPrincipal();
            ((frmPrincipal)Application.OpenForms["frmPrincipal"]).LblTituloPrincipal.Text = frt.LblTituloPrincipal.Text + " - " + this.Text;
        }

        public void LimpaTela()
        {
            txbTpPagtoCod.Clear();
            txbTpPagtoNome.Clear();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            alterabotoes(2);
            txbTpPagtoNome.Focus();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaTipoPagamento f = new frmConsultaTipoPagamento();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLTipoPagamento bll = new BLLTipoPagamento(cx);
                ModeloTipoPagamento modelo = bll.CarregaModeloTipoPagamento(f.codigo);
                txbTpPagtoCod.Text = modelo.TpaCod.ToString("D6");
                txbTpPagtoNome.Text = modelo.TpaNome;
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
            txbTpPagtoNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitrua dos dados
                ModeloTipoPagamento modelo = new ModeloTipoPagamento();
                modelo.TpaNome = txbTpPagtoNome.Text;

                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLTipoPagamento bll = new BLLTipoPagamento(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar um grupo
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado.\n Código: " + modelo.TpaCod.ToString());
                }
                else
                {
                    //alterar um grupo
                    modelo.TpaCod = Convert.ToInt32(txbTpPagtoCod.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado com sucesso.");
                }

                this.LimpaTela();
                this.alterabotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show("frmGrupoMaterial, btnSalvar - " + erro.Message);
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
                    BLLTipoPagamento bll = new BLLTipoPagamento(cx);
                    bll.Excluir(Convert.ToInt32(txbTpPagtoCod.Text));
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

        private void txbTpPagtoCod_Enter(object sender, EventArgs e)
        {
            txbTpPagtoCod.BackColor = Color.LemonChiffon;
        }

        private void TxbTpPagtoCod_Leave(object sender, EventArgs e)
        {
            txbTpPagtoCod.BackColor = Color.WhiteSmoke;
        }

        private void txbTpPagtoNome_Enter(Object sender, EventArgs e)
        {
            txbTpPagtoNome.BackColor = Color.LemonChiffon;
        }

        private void txbTpPagtoNome_Leave(object sender, EventArgs e)
        {
            txbTpPagtoNome.BackColor = Color.WhiteSmoke;
        }
    }
}
