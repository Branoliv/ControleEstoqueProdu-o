using BLL;
using DAL;
using MODELO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmPedidoVenda : Form
    {
        public String operacao = string.Empty;
        public Double totalPedido = 0;

        public frmPedidoVenda()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            dtpkPedVenData.Value = DateTime.Now;
            txbPedVenCodCli.Clear();
            lblPedVenCliNome.Text = "Informe o código do cliente";
            dtpkPedVenDtEntrega.Value = DateTime.Now;
            txbPedVenCodProd.Clear();
            lblPedVenProdNome.Text = "Informe o código do produto.";
            cbxPedVenDepProd.Text = string.Empty;
            txbPedVenQuantProd.Clear();
            cbxPedVenUmProd.Text = string.Empty;
            txbPedVenVlUnit.Clear();
            dgvPedVenItens.Rows.Clear();
            txbPedVenTotalCompra.Clear();
            dgvPedVenItens.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvItnsCancelar.Visible = false;
        }

        public void alterabotoes(int op)
        {
            // op = operações que serão feitas com os botões
            // 1  = Preparar os botões para inserir e localizar
            // 2  = Preparar os para inserir/alterar um registro
            // 3  = Preparar a tela para excluir ou alterar
            // 4  = visualização dos itens sem alterar

            pnlDados.Enabled = false;
            btnInserir.Enabled = false;
            btnAlterar.Enabled = false;
            btnLocalizar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;

            if (op == 1)
            {
                btnInserir.Enabled = true;
                btnLocalizar.Enabled = true;

            }
            if (op == 2)
            {
                pnlDados.Enabled = true;
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            if (op == 3)
            {
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
            }

            if (op == 4)
            {
                pnlDados.Enabled = true;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
            }

            if (op == 5)
            {
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void frmPedidoVenda_Load(object sender, EventArgs e)
        {
            frmPrincipal frt = new frmPrincipal();
            ((frmPrincipal)Application.OpenForms["frmPrincipal"]).LblTituloPrincipal.Text = frt.LblTituloPrincipal.Text + " - " + this.Text;
            alterabotoes(1);

            dgvItnsCancelar.Visible = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            frmPrincipal frt = new frmPrincipal();
            ((frmPrincipal)Application.OpenForms["frmPrincipal"]).LblTituloPrincipal.Text = frt.LblTituloPrincipal.Text;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            alterabotoes(2);
            dtpkPedVenData.Focus();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaPedidoVenda f = new frmConsultaPedidoVenda();
            f.ShowDialog();
            if(f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);

                try
                {
                    BLLPedidoVenda bll = new BLLPedidoVenda(cx);
                    ModeloPedidoVenda modelo = bll.CarregaModeloPedidoVenda(f.codigo);

                    txbPedVenCod.Text = modelo.PedCod.ToString("D9");
                    dtpkPedVenData.Value = modelo.PedData;
                    txbPedVenCodCli.Text = modelo.CliCod.ToString("D6");
                    dtpkPedVenDtEntrega.Value = modelo.PedDtEntrega;
                    txbPedVenTotalCompra.Text = modelo.PedTotal.ToString("N2");

                    txbPedVenCodCli_Leave(sender, e);

                    try
                    {
                        ModeloItensPedidoVenda modeloIpv = new ModeloItensPedidoVenda();
                        BLLItensPedidoVenda bllIpv = new BLLItensPedidoVenda(cx);
                        DataTable tabela = bllIpv.Localizar(modelo.PedCod);

                        this.dgvPedVenItens.RowHeadersVisible = false;

                        for (int i = 0; i < tabela.Rows.Count; i++)
                        {
                            int ipvCod = Convert.ToInt32(tabela.Rows[i]["ipv_cod"]);
                            int proCod = Convert.ToInt32(tabela.Rows[i]["pro_cod"]);
                            string ipvNome = tabela.Rows[i]["pro_nome"].ToString();
                            double ipvqtde = Convert.ToDouble(tabela.Rows[i]["ipv_qtde"]);
                            string ipvUndMed = tabela.Rows[i]["umed_simbolo"].ToString();
                            string ipvDep = tabela.Rows[i]["ipv_dep"].ToString();
                            double ipvValor = Convert.ToDouble(tabela.Rows[i]["ipv_valor"]);
                            Double totalLocal = Convert.ToDouble(tabela.Rows[i]["ipv_qtde"]) * Convert.ToDouble(tabela.Rows[i]["ipv_valor"]);
                            this.totalPedido += totalLocal;

                            String[] it = new String[] { ipvCod.ToString("D2"), proCod.ToString(), ipvNome, ipvqtde.ToString("N3"), ipvUndMed, ipvDep, ipvValor.ToString("N2"), totalLocal.ToString("N2") };
                            this.dgvPedVenItens.Rows.Add(it);
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("LocalizaPedidoVenda, Itens Pedido - " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }

                    this.alterabotoes(4);
                    if (modelo.PedStatus == 1)
                    {
                        btnExcluir.Enabled = false;
                    }
                    gbxPedVendDadosCli.Enabled = false;
                    gbxPedVenProduto.Enabled = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("frmPedidoVenda, Localizar - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.operacao = "alterar";
            dgvItnsCancelar.Visible = true;
            dgvPedVenItens.EditMode = DataGridViewEditMode.EditOnEnter;
            this.alterabotoes(2);
            gbxPedVendDadosCli.Enabled = true;
            gbxPedVenProduto.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            cx.Conectar();
            cx.IniciarTransacao();
            try
            {
                ModeloPedidoVenda modeloPedVenda = new ModeloPedidoVenda();

                modeloPedVenda.PedData = dtpkPedVenData.Value;
                modeloPedVenda.CliCod = Convert.ToInt32(txbPedVenCodCli.Text);
                modeloPedVenda.PedDtEntrega = dtpkPedVenDtEntrega.Value;
                modeloPedVenda.PedTotal = Convert.ToDouble(txbPedVenTotalCompra.Text);

                BLLPedidoVenda bllVenda = new BLLPedidoVenda(cx);


                ModeloItensPedidoVenda modeloIpv = new ModeloItensPedidoVenda();
                BLLItensPedidoVenda bllIpv = new BLLItensPedidoVenda(cx);


                ModeloEstoque modeloEstq = new ModeloEstoque();
                BLLEstoque bllEstq = new BLLEstoque(cx);

                if (this.operacao == "inserir")
                {
                    modeloPedVenda.PedStatus = 0;
                    bllVenda.Incluir(modeloPedVenda);

                    for (int i = 0; i< dgvPedVenItens.RowCount; i++)
                    {
                        modeloIpv.IpvStatus = 0;
                        modeloIpv.IpvCod = Convert.ToInt32(dgvPedVenItens.Rows[i].Cells[0].Value);
                        modeloIpv.ProCod = Convert.ToInt32(dgvPedVenItens.Rows[i].Cells[1].Value);
                        modeloIpv.IpvQtde = Convert.ToDouble(dgvPedVenItens.Rows[i].Cells[3].Value);
                        modeloIpv.IpvDep = dgvPedVenItens.Rows[i].Cells[5].Value.ToString();
                        modeloIpv.IpvValor = Convert.ToDouble(dgvPedVenItens.Rows[i].Cells[6].Value);
                        modeloIpv.PedCod = modeloPedVenda.PedCod;
                        bllIpv.Incluir(modeloIpv);
                    }

                    MessageBox.Show("Código: " + modeloPedVenda.PedCod.ToString(), "Pedido efetuado",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }
                else if (this.operacao == "alterar")
                {
                    modeloPedVenda.PedCod = (Convert.ToInt32(txbPedVenCod.Text));
                    bllVenda.Alterar(modeloPedVenda);

                    for (int i = 0; i < dgvPedVenItens.RowCount; i++)
                    {
                        modeloIpv.IpvCod = Convert.ToInt32(dgvPedVenItens.Rows[i].Cells[0].Value);
                        modeloIpv.ProCod = Convert.ToInt32(dgvPedVenItens.Rows[i].Cells[1].Value);
                        modeloIpv.IpvQtde = Convert.ToDouble(dgvPedVenItens.Rows[i].Cells[3].Value);
                        modeloIpv.IpvDep = dgvPedVenItens.Rows[i].Cells[5].Value.ToString();
                        modeloIpv.IpvValor = Convert.ToDouble(dgvPedVenItens.Rows[i].Cells[6].Value);
                        modeloIpv.IpvStatus = Convert.ToInt32(dgvPedVenItens.Rows[i].Cells[8].Value);
                        modeloIpv.PedCod = modeloPedVenda.PedCod;
                        if (modeloIpv.IpvStatus == 1)
                        {
                            bllIpv.ExcluirItem(modeloIpv);
                        }
                        else
                        {
                            DataTable dt = new DataTable();
                            dt = bllIpv.LocalizarItem(Convert.ToInt32(txbPedVenCod.Text), modeloIpv.IpvCod);
                            if (dt.Rows.Count < 1)
                            {
                                bllIpv.Incluir(modeloIpv);
                            }
                            else
                            {
                                bllIpv.Alterar(modeloIpv); 
                            }
                            dt.Clear();
                        }
                    }

                    MessageBox.Show("Pedido alterado com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                this.LimpaTela();
                this.alterabotoes(1);
                cx.TerminarTransacao();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Pedido Venda, Salvar - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cx.CancelarTransacao();
            }
            finally
            {
                cx.Desconectar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            alterabotoes(1);
            LimpaTela();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void frmPedidoVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void txbPedVenCod_Enter(object sender, EventArgs e)
        {
            txbPedVenCod.BackColor = Color.LemonChiffon;
        }

        private void txbPedVenCod_Leave(object sender, EventArgs e)
        {
            txbPedVenCod.BackColor = Color.WhiteSmoke;
        }

        private void txbPedVenCodCli_Enter(object sender, EventArgs e)
        {
            txbPedVenCodCli.BackColor = Color.LemonChiffon;
        }

        private void txbPedVenCodCli_Leave(object sender, EventArgs e)
        {
            txbPedVenCodCli.BackColor = Color.WhiteSmoke;

            if (!txbPedVenCodCli.Text.Equals(string.Empty))
            {
                CarregaCliente();
            }
        }

        private void txbPedVenCodProd_Enter(object sender, EventArgs e)
        {
            txbPedVenCodProd.BackColor = Color.LemonChiffon;
        }

        private void txbPedVenCodProd_Leave(object sender, EventArgs e)
        {
            txbPedVenCodProd.BackColor = Color.WhiteSmoke;

            if (!txbPedVenCodProd.Text.Equals(string.Empty))
            {
                CarregaProduto();
            }
        }

        private void cbxPedVenDepProd_Enter(object sender, EventArgs e)
        {
            cbxPedVenDepProd.BackColor = Color.LemonChiffon;
        }

        private void cbxPedVenDepProd_Leave(object sender, EventArgs e)
        {
            cbxPedVenDepProd.BackColor = Color.WhiteSmoke;
        }

        private void txbPedVenQuantProd_Enter(object sender, EventArgs e)
        {
            txbPedVenQuantProd.BackColor = Color.LemonChiffon;
        }

        private void txbPedVenQuantProd_Leave(object sender, EventArgs e)
        {
            txbPedVenQuantProd.BackColor = Color.WhiteSmoke;

            int vg = txbPedVenQuantProd.Text.Split(',').Length - 1;
            if (vg >= 2)
            {
                MessageBox.Show("Não é permitido mais de uma virgula.");
            }

            if (txbPedVenQuantProd.Text.IndexOf(",") == txbPedVenQuantProd.Text.Length - 1)
            {
                txbPedVenQuantProd.Text += "00";
            }

            if (txbPedVenQuantProd.Text.Contains(",") == false)
            {
                txbPedVenQuantProd.Text += ",00";
            }

            try
            {
                Double d = Convert.ToDouble(txbPedVenQuantProd.Text);
            }
            catch
            {
                txbPedVenQuantProd.Text = "0,00";
            }

            txbPedVenQuantProd.Text = Double.Parse(txbPedVenQuantProd.Text).ToString("N3");
        }

        private void cbxPedVenUmProd_Enter(object sender, EventArgs e)
        {
            cbxPedVenUmProd.BackColor = Color.LemonChiffon;
        }

        private void cbxPedVenUmProd_Leave(object sender, EventArgs e)
        {
            cbxPedVenUmProd.BackColor = Color.WhiteSmoke;
        }

        private void txbPedVenVlUnit_Enter(object sender, EventArgs e)
        {
            txbPedVenVlUnit.BackColor = Color.LemonChiffon;
        }

        private void txbPedVenVlUnit_Leave(object sender, EventArgs e)
        {
            txbPedVenVlUnit.BackColor = Color.WhiteSmoke;

            int vg = txbPedVenVlUnit.Text.Split(',').Length - 1;
            if (vg >= 2)
            {
                MessageBox.Show("Não é permitido mais de uma virgula.");
            }

            if (txbPedVenVlUnit.Text.IndexOf(",") == txbPedVenVlUnit.Text.Length - 1)
            {
                txbPedVenVlUnit.Text += "00";
            }

            if (txbPedVenVlUnit.Text.Contains(",") == false)
            {
                txbPedVenVlUnit.Text += ",00";
            }

            try
            {
                Double d = Convert.ToDouble(txbPedVenVlUnit.Text);
            }
            catch
            {
                txbPedVenVlUnit.Text = "0,00";
            }
            txbPedVenVlUnit.Text = Double.Parse(txbPedVenVlUnit.Text).ToString("N2");
        }

        private void btnPedVenLocCli_Click(object sender, EventArgs e)
        {
            frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();
            if(f.codigo != 0)
            {
                txbPedVenCodCli.Text = Convert.ToString(f.codigo);
                txbPedVenCodCli.Focus();
            }
        }

        public void CarregaCliente()
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                ModeloCliente modelo = bll.CarregaModeloCliente(Convert.ToInt32(txbPedVenCodCli.Text));

                if (modelo.CliNome.ToString() == string.Empty)
                {
                    MessageBox.Show("Cliente não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblPedVenCliNome.Text = "Informe o código do cliente";
                    txbPedVenCodCli.Focus();
                }
                else
                {
                    lblPedVenCliNome.Text = modelo.CliNome;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cliente não encontrado." + ex.Message , "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblPedVenCliNome.Text = "Informe o código do cliente";
                txbPedVenCodCli.Focus();
            }
        }

        private void btnPedVenLocProd_Click(object sender, EventArgs e)
        {
            frmConsultaSpProduto f = new frmConsultaSpProduto();
            f.ShowDialog();
            if(f.codigo != 0)
            {
                txbPedVenCodProd.Text = Convert.ToString(f.codigo);
                txbPedVenCodProd.Focus();
            }
        }

        public void CarregaProduto()
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(Convert.ToInt32(txbPedVenCodProd.Text));

                if (modelo.ProdNome.ToString() == string.Empty)
                {
                    MessageBox.Show("Produto não encontrado. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblPedVenProdNome.Text = "Informe o código do produto.";
                    txbPedVenCodProd.Focus();
                }
                else
                {
                    lblPedVenProdNome.Text = modelo.ProdNome;
                    LoadDeposito();
                    LoadUnidMed();
                    cbxPedVenUmProd.SelectedValue = modelo.UmedCodigo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Produto não encontrado. " + ex.Message , "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblPedVenProdNome.Text = "Informe o código do produto.";
                txbPedVenCodProd.Focus();
            }
        }

        public void LoadDeposito()
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLItensDeposito bll = new BLLItensDeposito(cx);
                cbxPedVenDepProd.DataSource = bll.Localizar(Convert.ToInt32(txbPedVenCodProd.Text));
                cbxPedVenDepProd.DisplayMember = "dep_abreviacao";
                cbxPedVenDepProd.ValueMember = "dep_codprod";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Depósito não encontrado. " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadUnidMed()
        {
            try
            {
                DALConexao ucx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeDeMedida ubll = new BLLUnidadeDeMedida(ucx);
                cbxPedVenUmProd.DataSource = ubll.Localizar("");
                cbxPedVenUmProd.DisplayMember = "umed_simbolo";
                cbxPedVenUmProd.ValueMember = "umed_cod";
            }
            catch
            {
                MessageBox.Show("Unidade de medida inválida.");
            }
        }

        private void btnPedVenProdIncluir_Click(object sender, EventArgs e)
        {
            if ((txbPedVenCodProd.Text.Equals(string.Empty)) || (txbPedVenQuantProd.Text.Equals(string.Empty)) || (txbPedVenVlUnit.Text.Equals(string.Empty)))
            {
                MessageBox.Show("Informe os dados do pedido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPedVenCodProd.Focus();
            }
            else if (txbPedVenQuantProd.Text == "0,000")
            {
                MessageBox.Show("Informe a quantidade valida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPedVenQuantProd.Focus();
            }
            else if ((txbPedVenVlUnit.Text == "0,00"))
            {
                MessageBox.Show("Informe o valor unitário do produto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPedVenVlUnit.Focus();
            }
            else if (cbxPedVenDepProd.Text.Equals(string.Empty))
            {
                MessageBox.Show("O produto não possue um depósito valido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPedVenCodProd.Focus();
            }
            else if (cbxPedVenUmProd.Text.Equals(string.Empty))
            {
                MessageBox.Show("O produto não possue uma unidade de medida valida. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPedVenCodProd.Focus();
            }
            else
            {
                int j = 0;

                if (this.operacao == "inserir")
                {
                    j = dgvPedVenItens.Rows.Count;
                    j = j + 1;
                }
                else if(this.operacao == "alterar")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLItensPedidoVenda bllPrIpv = new BLLItensPedidoVenda(cx);
                    ModeloItensPedidoVenda modelo = bllPrIpv.ProximoItemPedido(Convert.ToInt32(txbPedVenCod.Text));

                    j = modelo.IpvCod + 1;
                }
                
                Double totalProduto = Convert.ToDouble(txbPedVenQuantProd.Text) * Convert.ToDouble(txbPedVenVlUnit.Text);
                //this.totalPedido += totalProduto;
                
                String[] i = new string[] {j.ToString("D2"), txbPedVenCodProd.Text, lblPedVenProdNome.Text, txbPedVenQuantProd.Text, cbxPedVenUmProd.Text,
                cbxPedVenDepProd.Text, txbPedVenVlUnit.Text, totalProduto.ToString("N2")};
                this.dgvPedVenItens.Rows.Add(i);

                txbPedVenCodProd.Clear();
                lblPedVenProdNome.Text = "Informe o código do produto.";
                cbxPedVenDepProd.Text = string.Empty;
                txbPedVenQuantProd.Clear();
                cbxPedVenUmProd.Text = string.Empty;
                txbPedVenVlUnit.Clear();
                txbPedVenCodProd.Focus();

                CalculaValorPeido();
                txbPedVenTotalCompra.Text = this.totalPedido.ToString("N2");
            }
        }

        private void dgvPedVenItens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CalculaValorPeido();
        }

        public void CalculaValorPeido()
        {
            //txbPedVenTotalCompra.Text = string.Empty;
            this.totalPedido = 0;
            dgvPedVenItens.EndEdit();

            for (int i = 0; i < dgvPedVenItens.RowCount; i++)
            {
                int ipvSt = Convert.ToInt32(dgvPedVenItens.Rows[i].Cells[8].Value);
                if (ipvSt != 1)
                {
                    this.totalPedido = totalPedido + Convert.ToDouble(dgvPedVenItens.Rows[i].Cells[7].Value);
                }
            }

            txbPedVenTotalCompra.Text = totalPedido.ToString("N2");
        }
    }
}
