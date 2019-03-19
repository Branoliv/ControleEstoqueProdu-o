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
    public partial class frmMovimentacaoCompra : GUI.frmModeloCadastro
    {
        public double totalCompra = 0;

        public frmMovimentacaoCompra()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            this.operacao = String.Empty;
            txbComTm.Clear();
            txbComCod.Clear();
            txbComNf.Clear();
            dtpkDtCompra.Value = DateTime.Now;
            txbComCodForn.Clear();
            lblComForn.Text = "Informe o código do fornecedor.";
            txbComCodProd.Clear();
            lblComProd.Text = "Informe o código do produto."; 
            txbComQuantProd.Clear();
            txbComVlUnit.Clear();
            cbxComParcelas.SelectedIndex = 0;
            cbxComTpPagto.SelectedIndex = 0;           
            cbxComDeProd.Text = "";            
            cbxComUmProd.Text = "";
            dtpkDtVencPriPar.Value = DateTime.Now;
            txbComTotalCompra.Clear();

            if(dgvComItens.DataSource != null)
            {
                dgvComItens.DataSource = null;
            }
            else
            {
                dgvComItens.Rows.Clear();
            }
            
            dgvComParcelas.Rows.Clear();
        }

        private void frmMovimentacaoCompra_Load(object sender, EventArgs e)
        {
            frmPrincipal frt = new frmPrincipal();
            ((frmPrincipal)Application.OpenForms["frmPrincipal"]).LblTituloPrincipal.Text = frt.LblTituloPrincipal.Text + " - " + this.Text;

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTipoPagamento bll = new BLLTipoPagamento(cx);
            cbxComTpPagto.DataSource = bll.Localizar("");
            cbxComTpPagto.DisplayMember = "tpa_nome";
            cbxComTpPagto.ValueMember = "tpa_cod";
            btnAlterar.Visible = false;
            btnExcluir.Text = "Estorno";

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            totalCompra = 0;
            alterabotoes(2);
            gbxComCompra.Enabled = true;
            gbxComProduto.Enabled = true;
            gbxComVencimentos.Enabled = true;
            txbComTm.Text = "01";
            txbComNf.Focus();

        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaCompras f = new frmConsultaCompras();
           
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                try
                {
                    BLLCompra bll = new BLLCompra(cx);
                    ModeloCompra modelo = bll.CarregaModeloCompra(f.codigo);

                    txbComCod.Text = modelo.ComCod.ToString("D6");
                    txbComNf.Text = modelo.ComNFiscal.ToString();
                    dtpkDtCompra.Value = modelo.ComData;
                    txbComCodForn.Text = modelo.ForCod.ToString("D6");
                    cbxComParcelas.Text = modelo.ComNParcelas.ToString("D2");
                    cbxComTpPagto.SelectedValue = modelo.TpaCod;
                    txbComTotalCompra.Text = modelo.ComTotal.ToString("N2");
                    txbComTm.Text = modelo.TpMovimento.ToString("D2");

                    txbComCodForn_Leave(sender, e);
                                   
                try
                {
                    ModeloItensCompra mitens = new ModeloItensCompra();
                    BLLItensCompra bllitens = new BLLItensCompra(cx);
                    DataTable tabela = bllitens.Localizar(modelo.ComCod);

                        this.dgvComItens.RowHeadersVisible = false;

                    for (int i = 0; i < tabela.Rows.Count; i++)
                    {
                        int itcod = Convert.ToInt32(tabela.Rows[i]["itc_cod"]);
                        string icod = tabela.Rows[i]["pro_cod"].ToString();
                        string inome = tabela.Rows[i]["pro_nome"].ToString();
                        Double iqtd = Convert.ToDouble(tabela.Rows[i]["itc_qtde"]);
                        string iumed = tabela.Rows[i]["umed_simbolo"].ToString();
                        string idep = tabela.Rows[i]["dep_cod"].ToString();
                        Double ivu = Convert.ToDouble(tabela.Rows[i]["itc_valor"]);
                        Double TotalLocal = Convert.ToDouble(tabela.Rows[i]["itc_qtde"]) * Convert.ToDouble(tabela.Rows[i]["itc_valor"]);
                        int itcstatus = Convert.ToInt32(tabela.Rows[i]["itc_status"]);

                        String status;
                        if (itcstatus == 0)
                        {
                            status = "A";
                        }
                        else
                        {
                            status = "S";
                        }

                        String[] it = new String[] { status.ToString(), itcod.ToString("D2"), icod, inome, iqtd.ToString("N3"), iumed, idep, ivu.ToString("N2"), TotalLocal.ToString("N2") };
                        this.dgvComItens.Rows.Add(it);
                                               
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("LocalizaCompra, Itens Compra - "  + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                try
                {
                    ModeloParcelasCompra mparcelas = new ModeloParcelasCompra();
                    BLLParcelasCompra bllparcelas = new BLLParcelasCompra(cx);
                    DataTable tabelap = bllparcelas.Localizar(modelo.ComCod);

                    for (int i = 0; i < tabelap.Rows.Count; i++)
                    {
                        int pcod = Convert.ToInt32(tabelap.Rows[i]["pco_cod"]);
                        Double pvlpar = Convert.ToDouble(tabelap.Rows[i]["pco_valor"]);
                        DateTime pdtvenc = Convert.ToDateTime(tabelap.Rows[i]["pco_datavecto"]);
                        int pcostatus = Convert.ToInt32(tabelap.Rows[i]["pco_status"]);

                        String status;
                        if (pcostatus == 0)
                        {
                            status = "A";
                        }
                        else
                        {
                            status = "S";
                        }

                        String[] it = new String[] { status.ToString(), pcod.ToString("D2"), pvlpar.ToString("N2"), pdtvenc.Date.ToString("d") };
                        this.dgvComParcelas.Rows.Add(it);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("LocalizaCompra, Parcelas Compra - " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                this.alterabotoes(4);
                if(modelo.ComStatus == 1)
                {
                    btnExcluir.Enabled = false;
                }
                gbxComCompra.Enabled = false;
                gbxComProduto.Enabled = false;
                gbxComVencimentos.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("LocalizaCompra, Compra - " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.LimpaTela();
                }
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
            //this.operacao = "alterar";
            //this.alterabotoes(2);
            //gbxComCompra.Enabled = true;
            //gbxComProduto.Enabled = true;
            //gbxComVencimentos.Enabled = true;
            //txbComNf.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (dgvComParcelas.Rows.Count != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                cx.Conectar();
                cx.IniciarTransacao();
                try
                {
                    ModeloCompra modeloCompra = new ModeloCompra();
                    modeloCompra.ComData = dtpkDtCompra.Value;
                    modeloCompra.ComNFiscal = Convert.ToInt32(txbComNf.Text);
                    modeloCompra.ComNParcelas = Convert.ToInt32(cbxComParcelas.Text);                    
                    modeloCompra.ComTotal = Convert.ToDouble(txbComTotalCompra.Text);
                    modeloCompra.ForCod = Convert.ToInt32(txbComCodForn.Text);
                    modeloCompra.TpaCod = Convert.ToInt32(cbxComTpPagto.SelectedValue);
                    modeloCompra.DepProd = Convert.ToInt32(cbxComDeProd.SelectedValue);
                    modeloCompra.TpMovimento = Convert.ToInt32(txbComTm.Text);                 
                    
                    BLLCompra bll = new BLLCompra(cx);

                    ModeloItensCompra mitens = new ModeloItensCompra();
                    BLLItensCompra bllitens = new BLLItensCompra(cx);

                    ModeloEstoque es = new ModeloEstoque();
                    BLLEstoque blles = new BLLEstoque(cx);

                    ModeloParcelasCompra mparcelas = new ModeloParcelasCompra();
                    BLLParcelasCompra bparcelas = new BLLParcelasCompra(cx);

                    ModeloProduto modeloProd = new ModeloProduto();
                    BLLProduto bllProd = new BLLProduto(cx);

                    if (this.operacao == "inserir")
                    {                        
                        modeloCompra.ComStatus = 0;

                        bll.Incluir(modeloCompra);

                        for (int i = 0; i < dgvComItens.RowCount; i++)
                        {
                            mitens.ItcCod = Convert.ToInt32(dgvComItens.Rows[i].Cells[1].Value);
                            mitens.ComCod = modeloCompra.ComCod;
                            mitens.ProCod = Convert.ToInt32(dgvComItens.Rows[i].Cells[2].Value);
                            mitens.ItcQtde = Convert.ToDouble(dgvComItens.Rows[i].Cells[4].Value);
                            mitens.DepCod = Convert.ToString(dgvComItens.Rows[i].Cells[6].Value);
                            mitens.ItcValor = Convert.ToDouble(dgvComItens.Rows[i].Cells[7].Value);
                            mitens.ItcStatus = 0;
                            bllitens.Incluir(mitens);
                        }

                        for (int i = 0; i < dgvComItens.RowCount; i++)
                        {                           
                            es.EstTm = Convert.ToInt32(txbComTm.Text);
                            es.ProdCod = Convert.ToInt32(dgvComItens.Rows[i].Cells[2].Value);
                            es.EstSaldo = Convert.ToDouble(dgvComItens.Rows[i].Cells[4].Value);
                            es.DepAbrev = Convert.ToString(dgvComItens.Rows[i].Cells[6].Value);
                            es.VlrEstq = Convert.ToDouble(dgvComItens.Rows[i].Cells[8].Value);
                            blles.AtualizaEstoque(es);
                        }

                        for (int i = 0; i < dgvComParcelas.RowCount; i++)
                        {
                            mparcelas.ComCod = modeloCompra.ComCod;
                            mparcelas.PcoCod = Convert.ToInt32(dgvComParcelas.Rows[i].Cells[1].Value);
                            mparcelas.PcoValor = Convert.ToDouble(dgvComParcelas.Rows[i].Cells[2].Value);
                            mparcelas.PcoDtVecto = Convert.ToDateTime(dgvComParcelas.Rows[i].Cells[3].Value);
                            mparcelas.PcoStatus = 0;
                            bparcelas.Incluir(mparcelas);
                        }

                            MessageBox.Show("Compra efetuada; Código " + modeloCompra.ComCod.ToString());
                    }
                    else if (this.operacao == "estorno")
                    {
                        modeloCompra.ComStatus = 1;
                        modeloCompra.ComCod = Convert.ToInt32(txbComCod.Text);

                        bll.Estorno(modeloCompra);

                        for (int i = 0; i < dgvComItens.RowCount; i++)
                        {
                            mitens.ItcCod = Convert.ToInt32(dgvComItens.Rows[i].Cells[1].Value);
                            mitens.ComCod = modeloCompra.ComCod;
                            mitens.ProCod = Convert.ToInt32(dgvComItens.Rows[i].Cells[2].Value);
                            mitens.ItcQtde = Convert.ToDouble(dgvComItens.Rows[i].Cells[4].Value);
                            mitens.DepCod = Convert.ToString(dgvComItens.Rows[i].Cells[6].Value);
                            mitens.ItcValor = Convert.ToDouble(dgvComItens.Rows[i].Cells[7].Value);
                            mitens.ItcStatus = 1;
                            bllitens.Estorno(mitens);
                        }

                        for (int i = 0; i < dgvComItens.RowCount; i++)
                        {
                            es.EstTm = Convert.ToInt32(txbComTm.Text);
                            es.ProdCod = Convert.ToInt32(dgvComItens.Rows[i].Cells[2].Value);
                            es.EstSaldo = Convert.ToDouble(dgvComItens.Rows[i].Cells[4].Value);
                            es.DepAbrev = Convert.ToString(dgvComItens.Rows[i].Cells[6].Value);
                            es.VlrEstq = Convert.ToDouble(dgvComItens.Rows[i].Cells[8].Value);
                            blles.AtualizaEstoque(es);
                        }

                        for (int i = 0; i < dgvComParcelas.RowCount; i++)
                        {
                            mparcelas.ComCod = modeloCompra.ComCod;
                            mparcelas.PcoCod = Convert.ToInt32(dgvComParcelas.Rows[i].Cells[1].Value);
                            mparcelas.PcoValor = Convert.ToDouble(dgvComParcelas.Rows[i].Cells[2].Value);
                            mparcelas.PcoDtVecto = Convert.ToDateTime(dgvComParcelas.Rows[i].Cells[3].Value);
                            mparcelas.PcoStatus = 1;
                            bparcelas.Estorno(mparcelas);
                        }

                        MessageBox.Show("Estorno efetuado; Código " + modeloCompra.ComCod.ToString());
                    }

                    this.LimpaTela();
                    this.alterabotoes(1);
                    cx.TerminarTransacao();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Movimentação Compra, Salvar - " + ex.Message, "Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    cx.CancelarTransacao();
                }
                finally
                {
                    cx.Desconectar();
                }
            }
            else
            {
                MessageBox.Show("Nenhuma parcela foi gerada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.totalCompra = 0;
            this.alterabotoes(1);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Referente ao botão estorno.
            this.alterabotoes(5);
            txbComTm.Text = "02";
            dtpkDtCompra.Value = DateTime.Now;
            this.operacao = "estorno";            
        }

        private void btnComLocForn_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor f = new frmConsultaFornecedor();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txbComCodForn.Text = Convert.ToString(f.codigo);
                txbComCodForn_Leave(sender, e);

            }
        }

        private void txbComCodForn_Leave(object sender, EventArgs e)
        {
            txbComCodForn.BackColor = Color.WhiteSmoke;

            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(Convert.ToInt32(txbComCodForn.Text));                

                if (modelo.ForNome.ToString() == "")
                {
                    MessageBox.Show("Fornecedor não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblComForn.Text = "Informe o código do fornecedor.";
                    txbComCodForn.Focus();
                }
                else
                {
                    lblComForn.Text = modelo.ForNome;
                    VerificaNotaFornecedor();
                }
            }
            catch
            {
                txbComCodForn.Clear();
                lblComForn.Text = "Informe o código do fornecedor.";
            }
        }
        
        private void txbComCod_Enter(object sender, EventArgs e)
        {
            txbComCod.BackColor = Color.LemonChiffon;
        }

        private void txbComCod_Leave(object sender, EventArgs e)
        {
            txbComCod.BackColor = Color.WhiteSmoke;
        }

        private void txbComNf_Enter(object sender, EventArgs e)
        {
            txbComNf.BackColor = Color.LemonChiffon;
        }

        private void txbComNf_Leave(object sender, EventArgs e)
        {
            txbComNf.BackColor = Color.WhiteSmoke;
        }

        private void dtpkDtCompra_Enter(object sender, EventArgs e)
        {
            dtpkDtCompra.CalendarMonthBackground = Color.LemonChiffon;
        }

        private void dtpkDtCompra_Leave(object sender, EventArgs e)
        {

        }

        private void txbComCodForn_Enter(object sender, EventArgs e)
        {
            txbComCodForn.BackColor = Color.LemonChiffon;
        }

        private void txbComCodProd_Enter(object sender, EventArgs e)
        {
            txbComCodProd.BackColor = Color.LemonChiffon;
        }

        private void txbComCodProd_Leave(object sender, EventArgs e)
        {
            txbComCodProd.BackColor = Color.WhiteSmoke;

            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(Convert.ToInt32(txbComCodProd.Text));

                if (modelo.ProdNome.ToString() == "")
                {
                    MessageBox.Show("Produto não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblComProd.Text = "Informe o código do produto.";
                    txbComCodProd.Focus();
                }
                else if (modelo.ProdAtivo.Equals("N"))
                {
                    MessageBox.Show("Produto inativo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    lblComProd.Text = "Informe o código do produto.";
                    txbComCodProd.Focus();
                }
                else
                {
                    lblComProd.Text = modelo.ProdNome;
                    LoadDeposito();
                    LoadUnidMed();
                    cbxComUmProd.SelectedValue = modelo.UmedCodigo;
                }

            }
            catch
            {
                txbComCodProd.Clear();
                lblComProd.Text = "Informe o código do produto.";
            }            
        }

        private void LoadUnidMed()
        {
            try
            {
                DALConexao ucx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeDeMedida ubll = new BLLUnidadeDeMedida(ucx);
                cbxComUmProd.DataSource = ubll.Localizar("");
                cbxComUmProd.DisplayMember = "umed_simbolo";
                cbxComUmProd.ValueMember = "umed_cod";
            }
            catch
            {
                MessageBox.Show("Unidade de medida inválida.");
            }
        }

        private void LoadDeposito()
        {
            try
            {
                DALConexao ucx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLItensDeposito bll = new BLLItensDeposito(ucx);
                cbxComDeProd.DataSource = bll.Localizar(Convert.ToInt32(txbComCodProd.Text));
                cbxComDeProd.DisplayMember = "dep_abreviacao";
                cbxComDeProd.ValueMember = "dep_codprod";
            }
            catch
            {
                MessageBox.Show("Depósito inválido.");
            }
        }

        private void txbComQuantProd_Enter(object sender, EventArgs e)
        {
            txbComQuantProd.BackColor = Color.LemonChiffon;
        }

        private void txbComQuantProd_Leave(object sender, EventArgs e)
        {
            txbComQuantProd.BackColor = Color.WhiteSmoke;

            int vg = txbComQuantProd.Text.Split(',').Length - 1;
            if (vg >= 2)
            {
                MessageBox.Show("Não é permitido mais de uma virgula.");
            }

            if (txbComQuantProd.Text.IndexOf(",") == txbComQuantProd.Text.Length - 1)
            {
                txbComQuantProd.Text += "00";
            }

            if (txbComQuantProd.Text.Contains(",") == false)
            {
                txbComQuantProd.Text += ",00";
            }


            try
            {
                Double d = Convert.ToDouble(txbComQuantProd.Text);
            }
            catch
            {
                txbComQuantProd.Text = "0,00";
            }

            txbComQuantProd.Text = Double.Parse(txbComQuantProd.Text).ToString("N3");
            if ((txbComCodProd.Text != "") && (txbComTm.Text != ""))
            {
                try
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    ModeloEstoque es = new ModeloEstoque();
                    BLLEstoque blles = new BLLEstoque(cx);
                    es.EstTm = Convert.ToInt32(txbComTm.Text);
                    es.ProdCod = Convert.ToInt32(txbComCodProd.Text);
                    es.EstSaldo = Convert.ToDouble(txbComQuantProd.Text);
                    es.DepAbrev = Convert.ToString(cbxComDeProd.Text);
                    blles.VerificaSaldoNegativo(es);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txbComQuantProd.Focus();
                }
            }

        }

        private void txbComVlUnit_Enter(object sender, EventArgs e)
        {
            txbComVlUnit.BackColor = Color.LemonChiffon;
        }

        private void txbComVlUnit_Leave(object sender, EventArgs e)
        {
            txbComVlUnit.BackColor = Color.WhiteSmoke;

            int vg = txbComVlUnit.Text.Split(',').Length - 1;
            if (vg >= 2)
            {
                MessageBox.Show("Não é permitido mais de uma virgula.");
            }

            if (txbComVlUnit.Text.IndexOf(",") == txbComVlUnit.Text.Length - 1)
            {
                txbComVlUnit.Text += "00";
            }

            if (txbComVlUnit.Text.Contains(",") == false)
            {
                txbComVlUnit.Text += ",00";
            }

            try
            {
                Double d = Convert.ToDouble(txbComVlUnit.Text);
            }
            catch
            {
                txbComVlUnit.Text = "0,00";
            }

            txbComVlUnit.Text = Double.Parse(txbComVlUnit.Text).ToString("N2");
        }

        private void cbxComParcelas_Enter(object sender, EventArgs e)
        {
            cbxComParcelas.BackColor = Color.LemonChiffon;
        }

        private void cbxComParcelas_Leave(object sender, EventArgs e)
        {
            cbxComParcelas.BackColor = Color.WhiteSmoke;
        }

        private void cbxComTpPagto_Enter(object sender, EventArgs e)
        {
            cbxComTpPagto.BackColor = Color.LemonChiffon;
        }

        private void cbxComTpPagto_Leave(object sender, EventArgs e)
        {
            cbxComTpPagto.BackColor = Color.WhiteSmoke;
        }

        private void dtpkDtVencPriPar_Enter(object sender, EventArgs e)
        {

        }

        private void dtpkDtVencPriPar_Leave(object sender, EventArgs e)
        {

        }

        private void txbComTotalCompra_Enter(object sender, EventArgs e)
        {
            txbComTotalCompra.BackColor = Color.LemonChiffon;
        }

        private void txbComTotalCompra_Leave(object sender, EventArgs e)
        {
            txbComTotalCompra.BackColor = Color.WhiteSmoke;
        }

        private void btnComLocProd_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f = new frmConsultaProduto();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txbComCodProd.Text = Convert.ToString(f.codigo);
                txbComCodProd_Leave(sender, e);
            }
        }

        private void btnComProdIncluir_Click(object sender, EventArgs e)
        {
            if((txbComCodProd.Text == "") && (txbComQuantProd.Text == "") && (txbComVlUnit.Text == ""))
            {
                MessageBox.Show("Informe os dados da compra.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbComCodProd.Focus();
            }
            else if(txbComCodProd.Text == "")
            {
                MessageBox.Show("Informe o produto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbComCodProd.Focus();
            }
            else if((txbComQuantProd.Text == "") || (txbComQuantProd.Text == "0,000"))
            {
                MessageBox.Show("Informe a quantidade valida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbComQuantProd.Focus();
            }
            else if ((txbComVlUnit.Text == "") || (txbComVlUnit.Text == "0,00"))
            {
                MessageBox.Show("Informe o valor unitário do produto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbComVlUnit.Focus();
            }
            else
            {
                Double TotalLocal = Convert.ToDouble(txbComQuantProd.Text) * Convert.ToDouble(txbComVlUnit.Text);
                this.totalCompra = this.totalCompra + TotalLocal;
                String status = "";
                int j = dgvComItens.Rows.Count;
                j = j + 1;
                String[] i = new String[] { status.ToString(), j.ToString("D2"), txbComCodProd.Text, lblComProd.Text, txbComQuantProd.Text,
                    cbxComUmProd.Text, cbxComDeProd.Text ,txbComVlUnit.Text, TotalLocal.ToString("N2") };
                this.dgvComItens.Rows.Add(i);

                txbComCodProd.Clear();
                lblComProd.Text = "Informe o código do produto.";
                cbxComDeProd.Text = "";
                txbComQuantProd.Clear();
                cbxComUmProd.SelectedValue = 0;
                txbComVlUnit.Clear();
                txbComCodProd.Focus();

                txbComTotalCompra.Text = this.totalCompra.ToString();
            }           
        }

        private void txbComTotalCompra_TextChanged(object sender, EventArgs e)
        {
            

            int vg = txbComTotalCompra.Text.Split(',').Length - 1;
            if (vg >= 2)
            {
                MessageBox.Show("Não é permitido mais de uma virgula.");
            }

            if (txbComTotalCompra.Text.IndexOf(",") == txbComTotalCompra.Text.Length - 1)
            {
                txbComTotalCompra.Text += "00";
            }

            if (txbComTotalCompra.Text.Contains(",") == false)
            {
                txbComTotalCompra.Text += ",00";
            }

            try
            {
                Double d = Convert.ToDouble(txbComTotalCompra.Text);
            }
            catch
            {
                txbComTotalCompra.Text = "0,00";
            }

            txbComTotalCompra.Text = Double.Parse(txbComTotalCompra.Text).ToString("N2");
        }

        private void dgvComItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gbxComCompra.Enabled == true)
            {
                if (MessageBox.Show("Deseja remover esse item?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (e.RowIndex >= 0)
                    {
                        txbComCodProd.Text = dgvComItens.Rows[e.RowIndex].Cells[1].Value.ToString();
                        txbComCodProd_Leave(sender, e);
                        txbComQuantProd.Text = dgvComItens.Rows[e.RowIndex].Cells[3].Value.ToString();
                        txbComVlUnit.Text = dgvComItens.Rows[e.RowIndex].Cells[6].Value.ToString();

                        Double valor = Convert.ToDouble(dgvComItens.Rows[e.RowIndex].Cells[7].Value.ToString());
                        this.totalCompra = this.totalCompra - valor;
                        dgvComItens.Rows.RemoveAt(e.RowIndex);
                        txbComTotalCompra.Text = this.totalCompra.ToString();
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void btnComGerarParcelas_Click(object sender, EventArgs e)
        {
            if ((cbxComParcelas.SelectedItem != null) && (txbComTotalCompra.Text != "") &&  (cbxComParcelas.SelectedItem != null) && (txbComTotalCompra.Text != "0,00"))
            {
                dgvComParcelas.Rows.Clear();
                int parcelas = Convert.ToInt32(cbxComParcelas.Text);
                Double totallocal = this.totalCompra;
                double valor = totallocal / parcelas;
                DateTime dt = new DateTime();
                dt = dtpkDtVencPriPar.Value;

                double conftotal = valor * parcelas;
                lblComTlParcelas.Text = conftotal.ToString("N2");
                string status = "";

                for (int i = 1; i <= parcelas; i++)
                {
                    String[] k = new String[] {status.ToString(), i.ToString(), valor.ToString("N2"), dt.Date.ToString("d") };
                    this.dgvComParcelas.Rows.Add(k);
                    if (dt.Month != 12)
                    {
                        dt = new DateTime(dt.Year, dt.Month + 1, dt.Day);
                    }
                    else
                    {
                        dt = new DateTime(dt.Year + 1, 1, dt.Day);
                    }
                }
            }
            else if ((cbxComParcelas.SelectedItem == null) && (txbComTotalCompra.Text != ""))
            {
                MessageBox.Show("Informe o número de parcelas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if ((cbxComParcelas.SelectedItem != null) && (txbComTotalCompra.Text == "0,00"))
            {
                MessageBox.Show("O valor total não pode se zero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("Informe todos os dados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }                       
        }

        private void txbComTm_Enter(object sender, EventArgs e)
        {
            txbComTm.BackColor = Color.LemonChiffon;
        }

        private void txbComTm_Leave(object sender, EventArgs e)
        {
            txbComTm.BackColor = Color.WhiteSmoke;
        }

        private void cbxComDeProd_Enter(object sender, EventArgs e)
        {
            cbxComDeProd.BackColor = Color.LemonChiffon;
        }

        private void cbxComDeProd_Leave(object sender, EventArgs e)
        {
            cbxComDeProd.BackColor = Color.WhiteSmoke;
        }

        private void btnComLocForn_Enter(object sender, EventArgs e)
        {
            btnComLocForn.BackColor = Color.Silver;
        }

        private void btnComLocForn_Leave(object sender, EventArgs e)
        {
            btnComLocForn.BackColor = Color.Gray;
        }

        private void btnComLocProd_Enter(object sender, EventArgs e)
        {
            btnComLocProd.BackColor = Color.Silver;
        }

        private void btnComLocProd_Leave(object sender, EventArgs e)
        {
            btnComLocProd.BackColor = Color.Gray;
        }

        public void VerificaNotaFornecedor()
        {
            if (operacao.Equals("inserir") && txbComNf.Text != String.Empty && txbComTm.Text != String.Empty && txbComCodForn.Text != String.Empty)
            {
                try
                {
                                       
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);                    
                    BLLCompra bllcompra = new BLLCompra(cx);
                    ModeloCompra modelo = bllcompra.VerificaNotaFornecedor(Convert.ToInt32(txbComNf.Text), Convert.ToInt32(txbComTm.Text),Convert.ToInt32(txbComCodForn.Text));

                    int st = modelo.ComStatus;
                    int tp = modelo.TpMovimento;

                    if (st == 0 && tp == 1)
                    {
                        MessageBox.Show("Há um lançamento válido para nota físcal e fornecedor informados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        LimpaTela();
                        this.totalCompra = 0;
                        this.alterabotoes(1);
                        return;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("MovimentoCompra; VerificaNotaFornecedor." + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }

        }

        private void frmMovimentacaoCompra_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Control && e.KeyCode == Keys.S)
            {
                btnSalvar_Click(sender, e);
            }
        }
    }
}
