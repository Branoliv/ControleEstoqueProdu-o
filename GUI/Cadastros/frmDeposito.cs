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
    public partial class frmDeposito : GUI.frmModeloCadastro
    {
        public frmDeposito()
        {
            InitializeComponent();
        }

        private void LimpaTela()
        {
            txbDepCod.Clear();
            txbDepNome.Clear();
            txbDepNomeAbr.Clear();
        }

        private void frmDeposito_Load(object sender, EventArgs e)
        {
            frmPrincipal frt = new frmPrincipal();
            ((frmPrincipal)Application.OpenForms["frmPrincipal"]).LblTituloPrincipal.Text = frt.LblTituloPrincipal.Text + " - " + this.Text;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            alterabotoes(2);
            txbDepNome.Focus();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaDeposito f = new frmConsultaDeposito();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLDeposito bll = new BLLDeposito(cx);
                ModeloDeposito modelo = bll.CarregaModeloDeposito(f.codigo);
                txbDepCod.Text = modelo.DepCod.ToString("D6");
                txbDepNome.Text = modelo.DepNome;
                txbDepNomeAbr.Text = modelo.DepAbrev;
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
            txbDepNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitrua dos dados
                ModeloDeposito modelo = new ModeloDeposito();
                modelo.DepNome = txbDepNome.Text;
                modelo.DepAbrev = txbDepNomeAbr.Text;

                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLDeposito bll = new BLLDeposito(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar um grupo
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuadio: Código " + modelo.DepCod.ToString());
                }
                else
                {
                    //alterar um grupo
                    modelo.DepCod = Convert.ToInt32(txbDepCod.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado com sucesso.");
                }

                this.LimpaTela();
                this.alterabotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show("frmDeposito, btnSalvar - " + erro.Message, "Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                    BLLDeposito bll = new BLLDeposito(cx);
                    bll.Excluir(Convert.ToInt32(txbDepCod.Text));
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

        private void txbDepCod_Enter(object sender, EventArgs e)
        {
            txbDepCod.BackColor = Color.LemonChiffon;
        }

        private void txbDepCod_Leave(object sender, EventArgs e)
        {
            txbDepCod.BackColor = Color.WhiteSmoke;
        }

        private void txbDepNome_Enter(object sender, EventArgs e)
        {
            txbDepNome.BackColor = Color.LemonChiffon;
        }

        private void txbDepNome_Leave(object sender, EventArgs e)
        {
            txbDepNome.BackColor = Color.WhiteSmoke;
        }

        private void txbDepNomeAbr_Enter(object sender, EventArgs e)
        {
            txbDepNomeAbr.BackColor = Color.LemonChiffon;
        }

        private void txbDepNomeAbr_Leave(object sender, EventArgs e)
        {
            txbDepNomeAbr.BackColor = Color.WhiteSmoke;
        }
    }
}
