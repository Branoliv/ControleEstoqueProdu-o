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
    public partial class frmTipoProduto : GUI.frmModeloCadastro
    {
        public frmTipoProduto()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txbTppCod.Clear();
            txbTppNome.Clear();
            txbTppNomeAbr.Clear();
        }

        private void frmTipoProduto_Load(object sender, EventArgs e)
        {
            frmPrincipal frt = new frmPrincipal();
            ((frmPrincipal)Application.OpenForms["frmPrincipal"]).LblTituloPrincipal.Text = frt.LblTituloPrincipal.Text + " - " + this.Text;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            alterabotoes(2);
            txbTppNome.Focus();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaTipoProduto f = new frmConsultaTipoProduto();
            f.ShowDialog();

            txbTppCod.Text = Convert.ToString(f.codigo);

            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLTipoProduto bllTpp = new BLLTipoProduto(cx);

                ModeloTipoProduto modTpp = bllTpp.CarregaTipoProduto(Convert.ToInt32(txbTppCod.Text));

                txbTppNome.Text = modTpp.TppDescricao;
                txbTppNomeAbr.Text = modTpp.TppAbrev;

                this.alterabotoes(3);
            }
            catch(Exception ex)
            {
                MessageBox.Show("frmTipoProduto, Localizar - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpaTela();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alterabotoes(2);
            txbTppNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                ModeloTipoProduto modTpp = new ModeloTipoProduto();
                BLLTipoProduto bllTpp = new BLLTipoProduto(cx);

                modTpp.TppDescricao = txbTppNome.Text;
                modTpp.TppAbrev = txbTppNomeAbr.Text;

                if(operacao == "inserir")
                {
                    bllTpp.Incluir(modTpp);
                    MessageBox.Show("Cadastro efetuado. \nCódigo: " + modTpp.TppCod, "Aviso",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

                }
                else if (operacao == "alterar")
                {
                    modTpp.TppCod = Convert.ToInt32(txbTppCod.Text);

                    bllTpp.Alterar(modTpp);
                    MessageBox.Show("Alteração efetuada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                LimpaTela();
                alterabotoes(1);
            }
            catch(Exception ex)
            {
                MessageBox.Show("frmTipoProduto, btnSalvar - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaTela();
            alterabotoes(1);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void txbTppCod_Enter(object sender, EventArgs e)
        {
            txbTppCod.BackColor = Color.LemonChiffon;
        }

        private void txbTppCod_Leave(object sender, EventArgs e)
        {
            txbTppCod.BackColor = Color.WhiteSmoke;
        }

        private void txbTppNome_Enter(object sender, EventArgs e)
        {
            txbTppNome.BackColor = Color.LemonChiffon;
        }

        private void txbTppNome_Leave(object sender, EventArgs e)
        {
            txbTppNome.BackColor = Color.WhiteSmoke;
        }

        private void txbTppNomeAbr_Enter(object sender, EventArgs e)
        {
            txbTppNomeAbr.BackColor = Color.LemonChiffon;
        }

        private void txbTppNomeAbr_Leave(object sender, EventArgs e)
        {
            txbTppNomeAbr.BackColor = Color.WhiteSmoke;
        }
    }
}
