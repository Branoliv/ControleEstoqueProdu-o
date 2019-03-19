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
    public partial class frmSubGrupoMaterial : GUI.frmModeloCadastro
    {
        public frmSubGrupoMaterial()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txbSubGrpMatCodigo.Clear();
            //cbxSubGrpMatGrupoMaterial.Text = "";
            txbSubGrpMatNome.Clear();
        }

        private void frmSubGrupoMaterial_Load(object sender, EventArgs e)
        {
            try
            {
                frmPrincipal frt = new frmPrincipal();
                ((frmPrincipal)Application.OpenForms["frmPrincipal"]).LblTituloPrincipal.Text = frt.LblTituloPrincipal.Text + " - " + this.Text;

                this.alterabotoes(1);
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCategoria bll = new BLLCategoria(cx);
                cbxSubGrpMatGrupoMaterial.DataSource = bll.Localizar("");
                cbxSubGrpMatGrupoMaterial.DisplayMember = "cat_nome";
                cbxSubGrpMatGrupoMaterial.ValueMember = "cat_cod";
            }
            catch (Exception erro)
            {
                MessageBox.Show("frmSubGrupoMaterial, frmSubGrupoMaterial_Load - " + erro.Message);
            }
        }

        private void txbSubGrpMatCodigo_Enter(object sender, EventArgs e)
        {
            txbSubGrpMatCodigo.BackColor = Color.LemonChiffon;
        }

        private void txbSubGrpMatCodigo_Leave(object sender, EventArgs e)
        {
            txbSubGrpMatCodigo.BackColor = Color.WhiteSmoke;
        }

        private void txbSubGrpMatNome_Enter(object sender, EventArgs e)
        {
            txbSubGrpMatNome.BackColor = Color.LemonChiffon;
        }

        private void txbSubGrpMatNome_Leave(object sender, EventArgs e)
        {
            txbSubGrpMatNome.BackColor = Color.WhiteSmoke;
        }

        private void cbxSubGrpMatGrupoMaterial_Enter(object sender, EventArgs e)
        {
            cbxSubGrpMatGrupoMaterial.BackColor = Color.LemonChiffon;
        }

        private void cbxSubGrpMatGrupoMaterial_Leave(object sender, EventArgs e)
        {
            cbxSubGrpMatGrupoMaterial.BackColor = Color.WhiteSmoke;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            alterabotoes(2);
            cbxSubGrpMatGrupoMaterial.Focus();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {

            frmConsultaSubGrupoMaterial f = new frmConsultaSubGrupoMaterial();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSubCategoria bll = new BLLSubCategoria(cx);
                ModeloSubCategoria modelo = bll.CarregaModeloSubCategoria(f.codigo);
                txbSubGrpMatCodigo.Text = modelo.ScatCod.ToString("D6");
                cbxSubGrpMatGrupoMaterial.SelectedValue = modelo.CatCod;
                txbSubGrpMatNome.Text = modelo.ScatNome;
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
            txbSubGrpMatNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                //leitrua dos dados
                ModeloSubCategoria modelo = new ModeloSubCategoria();
                modelo.ScatNome = txbSubGrpMatNome.Text;
                modelo.CatCod = Convert.ToInt32(cbxSubGrpMatGrupoMaterial.SelectedValue);

                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSubCategoria bll = new BLLSubCategoria(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar um grupo
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuadio: Código " + modelo.ScatCod.ToString());
                }
                else
                {
                    //alterar um grupo
                    modelo.ScatCod = Convert.ToInt32(txbSubGrpMatCodigo.Text);
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
                    BLLSubCategoria bll = new BLLSubCategoria(cx);
                    bll.Excluir(Convert.ToInt32(txbSubGrpMatCodigo.Text));
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
    }
}
