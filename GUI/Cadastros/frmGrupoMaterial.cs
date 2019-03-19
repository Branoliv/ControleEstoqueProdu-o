using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MODELO;
using DAL;
using BLL;

namespace GUI
{
    public partial class frmGrupoMaterial : GUI.frmModeloCadastro
    {
        public frmGrupoMaterial()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txbGrpMatCod.Clear();
            txbGrpMatNome.Clear();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            alterabotoes(2);
            txbGrpMatNome.Focus();          
        }

        private void txbGrpMatCod_Enter(object sender, EventArgs e)
        {
            txbGrpMatCod.BackColor = Color.LemonChiffon;
        }

        private void txbGrpMatCod_Leave(object sender, EventArgs e)
        {
            txbGrpMatCod.BackColor = Color.WhiteSmoke;
        }
       
        private void txbGrpMatNome_Enter(object sender, EventArgs e)
        {
            txbGrpMatNome.BackColor = Color.LemonChiffon;
        }

        private void txbGrpMatNome_Leave(object sender, EventArgs e)
        {
            txbGrpMatNome.BackColor = Color.WhiteSmoke;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaTela();
            this.alterabotoes(1);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                //leitrua dos dados
                ModeloCategoria modelo = new ModeloCategoria();
                modelo.CatNome = txbGrpMatNome.Text;

                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCategoria bll = new BLLCategoria(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar um grupo
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuadio: Código " + modelo.CatCod.ToString());
                }
                else
                {
                    //alterar um grupo
                    modelo.CatCod = Convert.ToInt32(txbGrpMatCod.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado com sucesso.");
                }

                this.LimpaTela();
                this.alterabotoes(1);
            }
            catch(Exception erro)
            {
                MessageBox.Show("frmGrupoMaterial, btnSalvar - " + erro.Message);               
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alterabotoes(2);
            txbGrpMatNome.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCategoria bll = new BLLCategoria(cx);
                    bll.Excluir(Convert.ToInt32(txbGrpMatCod.Text));
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

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaGrpMaterial f = new frmConsultaGrpMaterial();
            f.ShowDialog();
            if(f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCategoria bll = new BLLCategoria(cx);
                ModeloCategoria modelo = bll.CarregaModeloCategoria(f.codigo);
                txbGrpMatCod.Text = modelo.CatCod.ToString("D6");
                txbGrpMatNome.Text = modelo.CatNome;
                alterabotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alterabotoes(1);
            }
            f.Dispose();
        }

        private void frmGrupoMaterial_Load(object sender, EventArgs e)
        {
            frmPrincipal frt = new frmPrincipal();
            ((frmPrincipal)Application.OpenForms["frmPrincipal"]).LblTituloPrincipal.Text = frt.LblTituloPrincipal.Text + " - " + this.Text;
        }
    }
}
