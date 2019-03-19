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
using Ferramentas;

namespace GUI
{
    public partial class frmCliente : GUI.frmModeloCadastro
    {



        public frmCliente()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txbCliCod.Clear();
            txbCliNome.Clear();
            rbtCliTpFisica.Checked = true;
            txbCliRazaoSocial.Clear();
            txbCliRg.Clear();
            txbCliCpfCnpj.Clear();
            txbCliCep.Clear();
            txbCliEndereco.Clear();
            txbCliEndNumero.Clear();
            txbCliBairro.Clear();
            txbCliCidade.Clear();
            txbCliEstado.Clear();
            txbCliTelefone.Clear();
            txbCliCelular.Clear();
            txbCliEmail.Clear();
            txbCliObservacao.Clear();
            lblCliInvalido.Visible = false;
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                ModeloCliente modelo = bll.CarregaModeloCliente(f.codigo);

                txbCliCod.Text = modelo.CliCod.ToString("D6");
                txbCliNome.Text = modelo.CliNome.ToString();

                if (modelo.CliTipo == 0)
                {
                    rbtCliTpFisica.Checked = true;
                }
                else
                {
                    rbtCliTpJuridica.Checked = true;
                }

                txbCliRazaoSocial.Text = modelo.CliRzSocial.ToString();
                txbCliRg.Text = modelo.CliRgIe.ToString();
                txbCliCpfCnpj.Text = modelo.CliCpfCnpj.ToString();
                txbCliCep.Text = modelo.CliCep.ToString();
                txbCliEndereco.Text = modelo.CliEndereco.ToString();
                txbCliEndNumero.Text = modelo.CliEndNumero.ToString();
                txbCliBairro.Text = modelo.CliBairro.ToString();
                txbCliCidade.Text = modelo.CliCidade.ToString();
                txbCliEstado.Text = modelo.CliEstado.ToString();
                txbCliTelefone.Text = modelo.CliFone.ToString();
                txbCliCelular.Text = modelo.CliCelular.ToString();
                txbCliEmail.Text = modelo.CliEmail.ToString();
                txbCliObservacao.Text = modelo.CliObservacao.ToString();              
                alterabotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alterabotoes(1);
            }
            f.Dispose();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            alterabotoes(2);
            txbCliNome.Focus();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            frmPrincipal frt = new frmPrincipal();
            ((frmPrincipal)Application.OpenForms["frmPrincipal"]).LblTituloPrincipal.Text = frt.LblTituloPrincipal.Text + " - " + this.Text;
        }
       
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitrua dos dados
                ModeloCliente modelo = new ModeloCliente();
                modelo.CliNome = txbCliNome.Text;

                if (rbtCliTpFisica.Checked == true)
                {
                    modelo.CliTipo = Convert.ToInt32(0);
                    modelo.CliRzSocial = "";
                }
                else
                {
                    modelo.CliTipo = Convert.ToInt32(1);
                }
                
                modelo.CliRzSocial = txbCliRazaoSocial.Text;
                modelo.CliRgIe = txbCliRg.Text;
                modelo.CliCpfCnpj = txbCliCpfCnpj.Text;
                modelo.CliCep = txbCliCep.Text;
                modelo.CliEndereco = txbCliEndereco.Text;
                modelo.CliEndNumero = txbCliEndNumero.Text;
                modelo.CliBairro = txbCliBairro.Text;
                modelo.CliCidade = txbCliCidade.Text;
                modelo.CliEstado = txbCliEstado.Text;
                modelo.CliFone = txbCliTelefone.Text;
                modelo.CliCelular = txbCliCelular.Text;
                modelo.CliEmail = txbCliEmail.Text;
                modelo.CliObservacao = txbCliObservacao.Text;

                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar um grupo
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuadio: Código " + modelo.CliCod.ToString());
                }
                else
                {
                    //alterar um grupo
                    modelo.CliCod = Convert.ToInt32(txbCliCod.Text);
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
                    BLLCliente bll = new BLLCliente(cx);
                    bll.Excluir(Convert.ToInt32(txbCliCod.Text));
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alterabotoes(2);
            txbCliNome.Focus();
        }

        private void txbCliNome_Enter(object sender, EventArgs e)
        {
            txbCliNome.BackColor = Color.LemonChiffon;
        }

        private void txbCliNome_Leave(object sender, EventArgs e)
        {
            txbCliNome.BackColor = Color.WhiteSmoke;
        }

        private void rbtCliTpFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtCliTpFisica.Checked == true)
            {
                lblCliRazaoSocial.Visible = false;
                txbCliRazaoSocial.Visible = false;
                lbCliRg.Text = "RG";
                lblCliCpfCnpj.Text = "CPF";
                txbCliNome.Focus();
            }
            else
            {
                lblCliRazaoSocial.Visible = true;
                txbCliRazaoSocial.Visible = true;
                lbCliRg.Text = "IE";
                lblCliCpfCnpj.Text = "CNPJ";
                txbCliNome.Focus();
            }
        }
       
        private void txbCliCep_Leave(object sender, EventArgs e)
        {
            txbCliCep.BackColor = Color.WhiteSmoke;

            if (BuscaEndereco.verificaCEP(txbCliCep.Text) == true)
            {
                txbCliBairro.Text = BuscaEndereco.bairro;
                txbCliEstado.Text = BuscaEndereco.estado;
                txbCliCidade.Text = BuscaEndereco.cidade;
                txbCliEndereco.Text = BuscaEndereco.endereco;
            }
        }

        private void txbCliCpfCnpj_Leave(object sender, EventArgs e)
        {
            txbCliCpfCnpj.BackColor = Color.WhiteSmoke;

            if (txbCliCpfCnpj.Text != "")
            {
                if (rbtCliTpFisica.Checked == true)
                {
                    //validação cpf
                    if (Validacao.IsCpf(txbCliCpfCnpj.Text) == false)
                    {
                        lblCliInvalido.Visible = true;
                    }
                    else
                    {
                        lblCliInvalido.Visible = false;
                    }
                }
                else
                {
                    //validação cnpj
                    if (Validacao.IsCnpj(txbCliCpfCnpj.Text) == false)
                    {
                        lblCliInvalido.Visible = true;
                    }
                    else
                    {
                        lblCliInvalido.Visible = false;
                    }
                }
            }
        }
       
        private void txbCliRazaoSocial_Enter(object sender, EventArgs e)
        {
            txbCliRazaoSocial.BackColor = Color.LemonChiffon;
        }

        private void txbCliRazaoSocial_Leave(object sender, EventArgs e)
        {
            txbCliRazaoSocial.BackColor = Color.WhiteSmoke;
        }

        private void txbCliRg_Enter(object sender, EventArgs e)
        {
            txbCliRg.BackColor = Color.LemonChiffon;
        }

        private void txbCliRg_Leave(object sender, EventArgs e)
        {
            txbCliRg.BackColor = Color.WhiteSmoke;
        }

        private void txbCliCpfCnpj_Enter(object sender, EventArgs e)
        {
            txbCliCpfCnpj.BackColor = Color.LemonChiffon;
        }

        private void txbCliCep_Enter(object sender, EventArgs e)
        {
            txbCliCep.BackColor = Color.LemonChiffon;
        }

        private void txbCliEndereco_Enter(object sender, EventArgs e)
        {
            txbCliEndereco.BackColor = Color.LemonChiffon;
        }

        private void txbCliEndereco_Leave(object sender, EventArgs e)
        {
            txbCliEndereco.BackColor = Color.WhiteSmoke;
        }

        private void txbCliEndNumero_Enter(object sender, EventArgs e)
        {
            txbCliEndNumero.BackColor = Color.LemonChiffon;
        }

        private void txbCliEndNumero_Leave(object sender, EventArgs e)
        {
            txbCliEndNumero.BackColor = Color.WhiteSmoke;
        }

        private void txbCliBairro_Enter(object sender, EventArgs e)
        {
            txbCliBairro.BackColor = Color.LemonChiffon;
        }

        private void txbCliBairro_Leave(object sender, EventArgs e)
        {
            txbCliBairro.BackColor = Color.WhiteSmoke;
        }

        private void txbCliCidade_Enter(object sender, EventArgs e)
        {
            txbCliCidade.BackColor = Color.LemonChiffon;
        }

        private void txbCliCidade_Leave(object sender, EventArgs e)
        {
            txbCliCidade.BackColor = Color.WhiteSmoke;
        }

        private void txbCliEstado_Enter(object sender, EventArgs e)
        {
            txbCliEstado.BackColor = Color.LemonChiffon;
        }

        private void txbCliEstado_Leave(object sender, EventArgs e)
        {
            txbCliEstado.BackColor = Color.WhiteSmoke;
        }

        private void txbCliTelefone_Enter(object sender, EventArgs e)
        {
            txbCliTelefone.BackColor = Color.LemonChiffon;
        }

        private void txbCliTelefone_Leave(object sender, EventArgs e)
        {
            txbCliTelefone.BackColor = Color.WhiteSmoke;
        }

        private void txbCliCelular_Enter(object sender, EventArgs e)
        {
            txbCliCelular.BackColor = Color.LemonChiffon;
        }

        private void txbCliCelular_Leave(object sender, EventArgs e)
        {
            txbCliCelular.BackColor = Color.WhiteSmoke;
        }

        private void txbCliEmail_Enter(object sender, EventArgs e)
        {
            txbCliEmail.BackColor = Color.LemonChiffon;
        }

        private void txbCliEmail_Leave(object sender, EventArgs e)
        {
            txbCliEmail.BackColor = Color.WhiteSmoke;
        }

        private void txbCliObservacao_Enter(object sender, EventArgs e)
        {
            txbCliObservacao.BackColor = Color.LemonChiffon;
        }

        private void txbCliObservacao_Leave(object sender, EventArgs e)
        {
            txbCliObservacao.BackColor = Color.WhiteSmoke;
        }
    }
}
