using BLL;
using DAL;
using Ferramentas;
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
    public partial class frmFornecedor : GUI.frmModeloCadastro
    {
        public frmFornecedor()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txbForCod.Clear();
            txbForNome.Clear();            
            txbForRazaoSocial.Clear();
            txbForIe.Clear();
            txbForCnpj.Clear();
            txbForCep.Clear();
            txbForEndereco.Clear();
            txbForEndNumero.Clear();
            txbForBairro.Clear();
            txbForCidade.Clear();
            txbForEstado.Clear();
            txbForTelefone.Clear();
            txbForCelular.Clear();
            txbForEmail.Clear();
            txbForObservacao.Clear();
            lblForInvalido.Visible = false;
        }

        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            frmPrincipal frt = new frmPrincipal();
            ((frmPrincipal)Application.OpenForms["frmPrincipal"]).LblTituloPrincipal.Text = frt.LblTituloPrincipal.Text + " - " + this.Text;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            alterabotoes(2);
            txbForNome.Focus();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor f = new frmConsultaFornecedor();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(f.codigo);

                txbForCod.Text = modelo.ForCod.ToString("D6");
                txbForNome.Text = modelo.ForNome.ToString();               
                txbForRazaoSocial.Text = modelo.ForRzSocial.ToString();
                txbForIe.Text = modelo.ForIe.ToString();
                txbForCnpj.Text = modelo.ForCnpj.ToString();
                txbForCep.Text = modelo.ForCep.ToString();
                txbForEndereco.Text = modelo.ForEndereco.ToString();
                txbForEndNumero.Text = modelo.ForEndNumero.ToString();
                txbForBairro.Text = modelo.ForBairro.ToString();
                txbForCidade.Text = modelo.ForCidade.ToString();
                txbForEstado.Text = modelo.ForEstado.ToString();
                txbForTelefone.Text = modelo.ForFone.ToString();
                txbForCelular.Text = modelo.ForCelular.ToString();
                txbForEmail.Text = modelo.ForEmail.ToString();
                txbForObservacao.Text = modelo.ForObservacao.ToString();
                
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
            txbForNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitrua dos dados
                ModeloFornecedor modelo = new ModeloFornecedor();
                modelo.ForNome = txbForNome.Text;
                modelo.ForRzSocial = txbForRazaoSocial.Text;
                modelo.ForIe = txbForIe.Text;
                modelo.ForCnpj = txbForCnpj.Text;
                modelo.ForCep = txbForCep.Text;
                modelo.ForEndereco = txbForEndereco.Text;
                modelo.ForEndNumero = txbForEndNumero.Text;
                modelo.ForBairro = txbForBairro.Text;
                modelo.ForCidade = txbForCidade.Text;
                modelo.ForEstado = txbForEstado.Text;
                modelo.ForFone = txbForTelefone.Text;
                modelo.ForCelular = txbForCelular.Text;
                modelo.ForEmail = txbForEmail.Text;
                modelo.ForObservacao = txbForObservacao.Text;
                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar um grupo
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuadio: Código " + modelo.ForCod.ToString());
                }
                else
                {
                    //alterar um grupo
                    modelo.ForCod = Convert.ToInt32(txbForCod.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado com sucesso.");
                }

                this.LimpaTela();
                this.alterabotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show("frmCliente, btnSalvar - " + erro.Message);
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
                    BLLFornecedor bll = new BLLFornecedor(cx);
                    bll.Excluir(Convert.ToInt32(txbForCod.Text));
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

        private void txbForCod_Enter(object sender, EventArgs e)
        {
            txbForCod.BackColor = Color.LemonChiffon;
        }

        private void txbForCod_Leave(object sender, EventArgs e)
        {
            txbForCod.BackColor = Color.WhiteSmoke;
        }

        private void txbForNome_Enter(object sender, EventArgs e)
        {
            txbForNome.BackColor = Color.LemonChiffon;
        }

        private void txbForNome_Leave(object sender, EventArgs e)
        {
            txbForNome.BackColor = Color.WhiteSmoke;
        }

        private void txbForRazaoSocial_Enter(object sender, EventArgs e)
        {
            txbForRazaoSocial.BackColor = Color.LemonChiffon;
        }

        private void txbForRazaoSocial_Leave(object sender, EventArgs e)
        {
            txbForRazaoSocial.BackColor = Color.WhiteSmoke;
        }

        private void txbForIe_Enter(object sender, EventArgs e)
        {
            txbForIe.BackColor = Color.LemonChiffon;
        }

        private void txbForIe_Leave(object sender, EventArgs e)
        {
            txbForIe.BackColor = Color.WhiteSmoke;
        }

        private void txbForCnpj_Enter(object sender, EventArgs e)
        {
            txbForCnpj.BackColor = Color.LemonChiffon;
        }

        private void txbForCnpj_Leave(object sender, EventArgs e)
        {
            txbForCnpj.BackColor = Color.WhiteSmoke;

            if (txbForCnpj.Text != "")
            {
                                
                //validação cnpj
                if (Validacao.IsCnpj(txbForCnpj.Text) == false)
                {
                    lblForInvalido.Visible = true;
                }
                else
                {
                    lblForInvalido.Visible = false;
                }
            }            
        }

        private void txbForCep_Enter(object sender, EventArgs e)
        {
            txbForCep.BackColor = Color.LemonChiffon;
        }

        private void txbForCep_Leave(object sender, EventArgs e)
        {
            txbForCep.BackColor = Color.WhiteSmoke;

            if (BuscaEndereco.verificaCEP(txbForCep.Text) == true)
            {
                txbForBairro.Text = BuscaEndereco.bairro;
                txbForEstado.Text = BuscaEndereco.estado;
                txbForCidade.Text = BuscaEndereco.cidade;
                txbForEndereco.Text = BuscaEndereco.endereco;
            }
        }

        private void txbForRua_Enter(object sender, EventArgs e)
        {
            txbForEndereco.BackColor = Color.LemonChiffon;
        }

        private void txbForRua_Leave(object sender, EventArgs e)
        {
            txbForEndereco.BackColor = Color.WhiteSmoke;
        }

        private void txbForEndNumero_Enter(object sender, EventArgs e)
        {
            txbForEndNumero.BackColor = Color.LemonChiffon;
        }

        private void txbForEndNumero_Leave(object sender, EventArgs e)
        {
            txbForEndNumero.BackColor = Color.WhiteSmoke;
        }

        private void txbForBairro_Enter(object sender, EventArgs e)
        {
            txbForBairro.BackColor = Color.LemonChiffon;
        }

        private void txbForBairro_Leave(object sender, EventArgs e)
        {
            txbForBairro.BackColor = Color.WhiteSmoke;
        }

        private void txbForCidade_Enter(object sender, EventArgs e)
        {
            txbForCidade.BackColor = Color.LemonChiffon;
        }

        private void txbForCidade_Leave(object sender, EventArgs e)
        {
            txbForCidade.BackColor = Color.WhiteSmoke;
        }

        private void txbForEstado_Enter(object sender, EventArgs e)
        {
            txbForEstado.BackColor = Color.LemonChiffon;
        }

        private void txbForEstado_Leave(object sender, EventArgs e)
        {
            txbForEstado.BackColor = Color.WhiteSmoke;
        }

        private void txbForTelefone_Enter(object sender, EventArgs e)
        {
            txbForTelefone.BackColor = Color.LemonChiffon;
        }

        private void txbForTelefone_Leave(object sender, EventArgs e)
        {
            txbForTelefone.BackColor = Color.WhiteSmoke;
        }

        private void txbForCelular_Enter(object sender, EventArgs e)
        {
            txbForCelular.BackColor = Color.LemonChiffon;
        }

        private void txbForCelular_Leave(object sender, EventArgs e)
        {
            txbForCelular.BackColor = Color.WhiteSmoke;
        }

        private void txbForEmail_Enter(object sender, EventArgs e)
        {
            txbForEmail.BackColor = Color.LemonChiffon;
        }

        private void txbForEmail_Leave(object sender, EventArgs e)
        {
            txbForEmail.BackColor = Color.WhiteSmoke;
        }

        private void txbForObservacao_Enter(object sender, EventArgs e)
        {
            txbForObservacao.BackColor = Color.LemonChiffon;
        }

        private void txbForObservacao_Leave(object sender, EventArgs e)
        {
            txbForObservacao.BackColor = Color.WhiteSmoke;
        }
    }
}
