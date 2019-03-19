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
    public partial class frmUnidadeDeMedida : GUI.frmModeloCadastro
    {
        public frmUnidadeDeMedida()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txbUnidMedCodigo.Clear();
            txbUnidMedNome.Clear();
            txbSimbUnidMedNome.Clear();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            alterabotoes(2);
            txbUnidMedNome.Focus();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaUnidadeDeMedida f = new frmConsultaUnidadeDeMedida();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(cx);
                ModeloUnidadeDeMedida modelo = bll.CarregaModeloUnidadeDeMedida(f.codigo);
                txbUnidMedCodigo.Text = modelo.UmedCod.ToString("D6");
                txbUnidMedNome.Text = modelo.UmedNome;
                txbSimbUnidMedNome.Text = modelo.UmedSimbolo;
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
            txbUnidMedNome.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(cx);
                    bll.Excluir(Convert.ToInt32(txbUnidMedCodigo.Text));
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.operacao == "inserir" || this.operacao == "alterar")
                {
                    int r = 0;
                    int v = 0;
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(cx);
                    r = bll.VerificaUnidadeDeMedida(txbUnidMedNome.Text);
                    v = bll.VerificaUnidadeDeMedida(txbSimbUnidMedNome.Text);
                    if(r <= 0)
                    {
                        //leitrua dos dados
                        ModeloUnidadeDeMedida modelo = new ModeloUnidadeDeMedida();
                        modelo.UmedNome = txbUnidMedNome.Text;
                        modelo.UmedSimbolo = txbSimbUnidMedNome.Text;
                        
                        if (this.operacao == "inserir")
                        {
                            //cadastrar um grupo
                            bll.Incluir(modelo);
                            MessageBox.Show("Cadastro efetuadio: Código " + modelo.UmedCod.ToString());
                        }
                        else
                        {
                            //alterar um grupo
                            modelo.UmedCod = Convert.ToInt32(txbUnidMedCodigo.Text);
                            bll.Alterar(modelo);
                            MessageBox.Show("Cadastro alterado com sucesso.");
                        }

                        this.LimpaTela();
                        this.alterabotoes(1);
                    }
                    else if(r > 0 && v <= 0)
                    {
                        ModeloUnidadeDeMedida modelo = new ModeloUnidadeDeMedida();
                        modelo.UmedNome = txbUnidMedNome.Text;
                        modelo.UmedSimbolo = txbSimbUnidMedNome.Text;
                        //alterar um grupo
                        modelo.UmedCod = Convert.ToInt32(txbUnidMedCodigo.Text);
                        bll.Alterar(modelo);
                        MessageBox.Show("Cadastro alterado com sucesso.");
                        this.LimpaTela();
                        this.alterabotoes(1);
                    }
                    else
                    {
                        MessageBox.Show("Cadastro existente!");
                        LimpaTela();
                        this.alterabotoes(1);
                    }
                }                
            }
            catch (Exception erro)
            {
                MessageBox.Show("frmUnidadeDeMedida, btnSalvar - " + erro.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaTela();
            this.alterabotoes(1);
        }

        private void txbUnidMedCodigo_Enter(object sender, EventArgs e)
        {
            txbUnidMedCodigo.BackColor = Color.LemonChiffon;
        }

        private void txbUniMedCodigo_Leave(object sender,EventArgs e)
        {
            txbUnidMedCodigo.BackColor = Color.WhiteSmoke;
        }

        private void txbUnidMedNome_Enter(object sender, EventArgs e)
        {
            txbUnidMedNome.BackColor = Color.LemonChiffon;
        }

        private void txbUnidMedNome_Leave(object sender, EventArgs e)
        {
            txbUnidMedNome.BackColor = Color.WhiteSmoke;
        }

        private void txbSimbUnidMedNome_Enter(object sender, EventArgs e)
        {
            txbSimbUnidMedNome.BackColor = Color.LemonChiffon;
        }

        private void txbSimbUnidMedNome_Leave(object sender,EventArgs e)
        {
            txbSimbUnidMedNome.BackColor = Color.WhiteSmoke;
        }

        private void frmUnidadeDeMedida_Load(object sender, EventArgs e)
        {
            frmPrincipal frt = new frmPrincipal();
            ((frmPrincipal)Application.OpenForms["frmPrincipal"]).LblTituloPrincipal.Text = frt.LblTituloPrincipal.Text + " - " + this.Text;
        }
    }
}
