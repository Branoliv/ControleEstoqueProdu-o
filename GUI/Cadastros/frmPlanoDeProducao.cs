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
    public partial class frmPlanoDeProducao : GUI.frmModeloCadastro
    {
        public frmPlanoDeProducao()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txbPlpCod.Clear();
            txbPlpProCod.Clear();
            lblPlpDescProduto.Text = String.Empty;
            txbPlpQtde.Clear();
            cbxPlpUnidMed.Text = String.Empty;
            txbIppProdCod.Clear();
            lblIppDescricaoProd.Text = string.Empty;
            txbIppQtde.Clear();
            cbxIppUmProd.Text = string.Empty;
            cbxIppDepProd.Text = string.Empty;
            dgvItensExcluir.Visible = false;
            dgvPlpItens.EditMode = DataGridViewEditMode.EditProgrammatically;

            if (dgvPlpItens.DataSource != null)
            {
                dgvPlpItens.DataSource = null;
            }
            else
            {
                dgvPlpItens.Rows.Clear();
            }

            this.alterabotoes(1);
        }

        private void frmPlanoDeProducao_Load(object sender, EventArgs e)
        {
            frmPrincipal frt = new frmPrincipal();
            ((frmPrincipal)Application.OpenForms["frmPrincipal"]).LblTituloPrincipal.Text = frt.LblTituloPrincipal.Text + " - " + this.Text;
            dgvItensExcluir.Visible = false;
           // dgvPlpItens.Columns[6].Visible = false;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            alterabotoes(2);
            txbPlpProCod.Focus();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaPlanoProducao f = new frmConsultaPlanoProducao();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                try
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLPlanoProducao bll = new BLLPlanoProducao(cx);
                    ModeloPlanoProducao modelo = bll.CarregaModeloPlanoProducao(f.codigo);

                    txbPlpCod.Text = modelo.PlpCod.ToString("D9");
                    txbPlpProCod.Text = modelo.Procod.ToString("D6");
                    LocalizarPA();
                    txbPlpQtde.Text = modelo.PlpQtde.ToString("N3");
               
                    ModeloItensPlanoProducao mipp = new ModeloItensPlanoProducao();
                    BLLItensPlanoProducao bllIpp = new BLLItensPlanoProducao(cx);
                    DataTable tabela = bllIpp.Localizar(modelo.PlpCod);

                    this.dgvPlpItens.RowHeadersVisible = false;

                    for (int i = 0; i < tabela.Rows.Count; i++)
                    {
                        int itcod = Convert.ToInt32(tabela.Rows[i]["ipp_cod"]);
                        int icod = Convert.ToInt32(tabela.Rows[i]["pro_cod"]);
                        string inome = tabela.Rows[i]["pro_nome"].ToString();
                        Double iqtd = Convert.ToDouble(tabela.Rows[i]["ipp_qtde"]);
                        string iumed = tabela.Rows[i]["umed_simbolo"].ToString();
                        string itDep = tabela.Rows[i]["ipp_deposito"].ToString();
                                                

                        String[] it = new String[] {  itcod.ToString("D2"), icod.ToString("D2"), inome, iqtd.ToString("N3"), iumed,itDep };
                        this.dgvPlpItens.Rows.Add(it);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("PlanoProducao, Localizar - " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }


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
            dgvItensExcluir.Visible = true;
            dgvPlpItens.EditMode = DataGridViewEditMode.EditOnEnter;
            this.alterabotoes(2);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (dgvPlpItens.Rows.Count != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
               
                try
                {
                    cx.Conectar();
                    cx.IniciarTransacao();

                    ModeloPlanoProducao modeloPlp = new ModeloPlanoProducao();
                    modeloPlp.Procod = Convert.ToInt32(txbPlpProCod.Text);
                    modeloPlp.PlpQtde = Convert.ToDouble(txbPlpQtde.Text);
                    modeloPlp.UmdeCod = Convert.ToInt32(cbxPlpUnidMed.SelectedValue);

                    BLLPlanoProducao bllPlp = new BLLPlanoProducao(cx);

                    ModeloItensPlanoProducao modeloIpp = new ModeloItensPlanoProducao();
                    BLLItensPlanoProducao bllIpp = new BLLItensPlanoProducao(cx);

                    if (this.operacao == "inserir")
                    {

                        bllPlp.Incluir(modeloPlp);

                        for (int i = 0; i < dgvPlpItens.RowCount; i++)
                        {
                            modeloIpp.IppCod = Convert.ToInt32(dgvPlpItens.Rows[i].Cells[0].Value);
                            modeloIpp.PlpCod = modeloPlp.PlpCod;
                            modeloIpp.ProCod = Convert.ToInt32(dgvPlpItens.Rows[i].Cells[1].Value);
                            modeloIpp.IppQtde = Convert.ToDouble(dgvPlpItens.Rows[i].Cells[3].Value);
                            modeloIpp.IppDeposito = dgvPlpItens.Rows[i].Cells[5].Value.ToString();

                            bllIpp.Incluir(modeloIpp);
                        }


                        MessageBox.Show("Plano cadastrado: " + modeloPlp.PlpCod.ToString());
                    }
                    else if (this.operacao == "alterar")
                    {
                        modeloPlp.PlpCod = Convert.ToInt32(txbPlpCod.Text);
                        modeloPlp.PlpQtde = Convert.ToDouble(txbPlpQtde.Text);
                        bllPlp.Alterar(modeloPlp);

                        modeloIpp.PlpCod = modeloPlp.PlpCod;
                        bllIpp.ExcluirItem(modeloIpp);
                        
                        for (int i = 0; i < dgvPlpItens.RowCount; i++)
                        {
                            int excluirlinha = Convert.ToInt32(dgvPlpItens.Rows[i].Cells[6].Value);
                            if (excluirlinha != 2)
                            {
                                modeloIpp.IppCod = Convert.ToInt32(dgvPlpItens.Rows[i].Cells[0].Value);
                                modeloIpp.PlpCod = modeloPlp.PlpCod;
                                modeloIpp.ProCod = Convert.ToInt32(dgvPlpItens.Rows[i].Cells[1].Value);
                                modeloIpp.IppQtde = Convert.ToDouble(dgvPlpItens.Rows[i].Cells[3].Value);
                                modeloIpp.IppDeposito = dgvPlpItens.Rows[i].Cells[5].Value.ToString();

                                bllIpp.Incluir(modeloIpp);
                            }
                        }

                        MessageBox.Show("Cadastro alterado com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }

                    this.LimpaTela();
                    this.alterabotoes(1);
                    cx.TerminarTransacao();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Plano Produção, Salvar - " + ex.Message);
                    cx.CancelarTransacao();
                }
                finally
                {
                    cx.Desconectar();
                }
            }
            else
            {
                MessageBox.Show("Nenhum item MP foi incluido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    cx.Conectar();
                   cx.IniciarTransacao();

                    ModeloItensPlanoProducao mPlp = new ModeloItensPlanoProducao();
                    BLLItensPlanoProducao bllIpp = new BLLItensPlanoProducao(cx);

                    mPlp.PlpCod = Convert.ToInt32(txbPlpCod.Text);
                    bllIpp.Excluir(mPlp);

                    BLLPlanoProducao bll = new BLLPlanoProducao(cx);
                    bll.Excluir(Convert.ToInt32(txbPlpCod.Text));

                    this.LimpaTela();
                    this.alterabotoes(1);
                   cx.TerminarTransacao();

                    MessageBox.Show("Registro excluído com sucesso.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Impossível excluir o registro. O registro esta sendo utilizado em outro local." + ex.Message);
                cx.CancelarTransacao();
                this.alterabotoes(3);
            }
            finally
            {
                cx.Desconectar();
            }
        }

        private void btnPlpLocProd_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f = new frmConsultaProduto();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txbPlpProCod.Text = Convert.ToString(f.codigo);
                txbPlpProCod_Leave(sender, e);
            }
        }

        private void LocalizarPA()
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(Convert.ToInt32(txbPlpProCod.Text));

                if (modelo.ProdNome.ToString() == "")
                {
                    MessageBox.Show("Produto não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblPlpDescProduto.Text = "Informe o código do produto acabado.";
                    txbPlpProCod.Focus();
                }
                else if (modelo.ProdAtivo.Equals("N"))
                {
                    MessageBox.Show("Produto inativo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    lblPlpDescProduto.Text = "Informe o código do produto acabado.";
                    txbPlpProCod.Focus();
                }
                else
                {
                    lblPlpDescProduto.Text = modelo.ProdNome;
                    LoadUnidMedPa();
                    cbxPlpUnidMed.SelectedValue = modelo.UmedCodigo;
                }
            }
            catch
            {
                txbPlpProCod.Clear();
                lblPlpDescProduto.Text = "Informe o código do produto.";
            }
        }

        private void LoadUnidMedPa()
        {
            try
            {
                DALConexao ucx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeDeMedida ubll = new BLLUnidadeDeMedida(ucx);
                cbxPlpUnidMed.DataSource = ubll.Localizar("");
                cbxPlpUnidMed.DisplayMember = "umed_simbolo";
                cbxPlpUnidMed.ValueMember = "umed_cod";
            }
            catch
            {
                MessageBox.Show("Unidade de medida inválida.");
            }
        }

        private void btnIppLocProd_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f = new frmConsultaProduto();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txbIppProdCod.Text = Convert.ToString(f.codigo);
                LocalizarMP();
            }
        }

        private void LocalizarMP()
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(Convert.ToInt32(txbIppProdCod.Text));

                if (modelo.ProdNome.ToString() == "")
                {
                    MessageBox.Show("Produto não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblIppDescricaoProd.Text = "Informe o código da matéria prima.";
                    txbIppProdCod.Focus();
                }
                else if (modelo.ProdAtivo.Equals("N"))
                {
                    MessageBox.Show("Produto inativo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    lblIppDescricaoProd.Text = "Informe o código da matéria prima.";
                    txbIppProdCod.Focus();
                }
                else
                {
                    lblIppDescricaoProd.Text = modelo.ProdNome;
                    LoadUnidMedMp();
                    cbxIppUmProd.SelectedValue = modelo.UmedCodigo;
                    LoadDepositoMp();
                }

            }
            catch
            {
                txbIppProdCod.Clear();
                lblIppDescricaoProd.Text = "Informe o código do produto.";
            }
        }

        private void LoadUnidMedMp()
        {
            try
            {
                DALConexao ucx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeDeMedida ubll = new BLLUnidadeDeMedida(ucx);
                cbxIppUmProd.DataSource = ubll.Localizar("");
                cbxIppUmProd.DisplayMember = "umed_simbolo";
                cbxIppUmProd.ValueMember = "umed_cod";
            }
            catch
            {
                MessageBox.Show("Unidade de medida inválida.");
            }
        }

        private void LoadDepositoMp()
        {
            try
            {
                DALConexao ucx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLItensDeposito bll = new BLLItensDeposito(ucx);
                cbxIppDepProd.DataSource = bll.Localizar(Convert.ToInt32(txbIppProdCod.Text));
                cbxIppDepProd.DisplayMember = "dep_abreviacao";
                cbxIppDepProd.ValueMember = "dep_codprod";
            }
            catch
            {
                MessageBox.Show("Depósito inválido.");
            }
        }

        private void btnIppIncluirMp_Click(object sender, EventArgs e)
        {
            if ((txbPlpProCod.Text == "") && (txbPlpQtde.Text == ""))
            {
                MessageBox.Show("Informe os dados do produto acabado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPlpProCod.Focus();
            }
            else if (txbIppProdCod.Text == "")
            {
                MessageBox.Show("Informe o código MP.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbIppProdCod.Focus();
            }
            else if ((txbIppQtde.Text.Equals(String.Empty) || (txbIppQtde.Text == "0,000")))
            {
                MessageBox.Show("Informe a quantidade valida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbIppQtde.Focus();
            }
            else if (cbxIppDepProd.Text.Equals(""))
            {
                MessageBox.Show("Informe um depósito valido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbxIppDepProd.Focus();
            }
           
            else
            {
                
                int j = 0;

                for(int x = 0; x < dgvPlpItens.Rows.Count; x++)
                {
                    j = Convert.ToInt32(dgvPlpItens.Rows[x].Cells[0].Value);
                }

                j = j + 1;

                String[] i = new String[] { j.ToString("D2"), txbIppProdCod.Text, lblIppDescricaoProd.Text, txbIppQtde.Text, cbxIppUmProd.Text, cbxIppDepProd.Text };
                this.dgvPlpItens.Rows.Add(i);

                txbIppProdCod.Clear();
                lblIppDescricaoProd.Text = "Informe o código do produto.";
                // cbxIppUmProd.Text = "";
                txbIppQtde.Clear();
                cbxIppUmProd.SelectedValue = 0;
                txbIppProdCod.Focus();

            }
        }

        private void txbPlpCod_Enter(object sender, EventArgs e)
        {
            txbPlpCod.BackColor = Color.LemonChiffon;
        }

        private void txbPlpCod_Leave(object sender, EventArgs e)
        {
            txbPlpCod.BackColor = Color.WhiteSmoke;
        }

        private void txbPlpProCod_Enter(object sender, EventArgs e)
        {
            txbPlpProCod.BackColor = Color.LemonChiffon;
        }

        private void txbPlpProCod_Leave(object sender, EventArgs e)
        {
            txbPlpProCod.BackColor = Color.WhiteSmoke;

            LocalizarPA();
        }

        private void txbPlpQtde_Enter(object sender, EventArgs e)
        {
            txbPlpQtde.BackColor = Color.LemonChiffon;
        }

        private void txbPlpQtde_Leave(object sender, EventArgs e)
        {
            txbPlpQtde.BackColor = Color.WhiteSmoke;
            if (!txbPlpQtde.Text.Equals(String.Empty))
            {
                txbPlpQtde.Text = Double.Parse(txbPlpQtde.Text).ToString("N3");
            }
        }

        private void cbxPlpUnidMed_Enter(object sender, EventArgs e)
        {
            cbxPlpUnidMed.BackColor = Color.LemonChiffon;
        }

        private void cbxPlpUnidMed_Leave(object sender, EventArgs e)
        {
            cbxPlpUnidMed.BackColor = Color.WhiteSmoke;
        }

        private void txbIppProdCod_Enter(object sender, EventArgs e)
        {
            txbIppProdCod.BackColor = Color.LemonChiffon;
        }

        private void txbIppProdCod_Leave(object sender, EventArgs e)
        {
            txbIppProdCod.BackColor = Color.WhiteSmoke;

            LocalizarMP();
        }

        private void txbIppQtde_Enter(object sender, EventArgs e)
        {
            txbIppQtde.BackColor = Color.LemonChiffon;
        }

        private void txbIppQtde_Leave(object sender, EventArgs e)
        {
            txbIppQtde.BackColor = Color.WhiteSmoke;

            if (!txbIppQtde.Text.Equals(String.Empty))
            {
                txbIppQtde.Text = Double.Parse(txbIppQtde.Text).ToString("N3");
            }
        }

        private void cbxIppUmProd_Enter(object sender, EventArgs e)
        {
            cbxIppUmProd.BackColor = Color.LemonChiffon;
        }

        private void cbxIppUmProd_Leave(object sender, EventArgs e)
        {
            cbxIppUmProd.BackColor = Color.WhiteSmoke;
        }

        private void cbxIppDepProd_Enter(object sender, EventArgs e)
        {
            cbxIppDepProd.BackColor = Color.LemonChiffon;
        }

        private void cbxIppDepProd_Leave(object sender, EventArgs e)
        {
            cbxIppDepProd.BackColor = Color.WhiteSmoke;
        }
    }
}
