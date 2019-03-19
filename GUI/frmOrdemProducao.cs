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
    public partial class frmOrdemProducao : Form
    {
        public String operacao = "";
        public frmOrdemProducao()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txbOdpCod.Clear();
            txbOdpItemPedido.Clear();
            txbOdpCodPedido.Clear();
            txbOdpProCod.Clear();
            lblOdpDescProduto.Text = "Informe o código do produto acabado.";
            txbOdpQtde.Clear();
            cbxOdpUnidMed.DataSource = null;
            dgvItensOrdemProducao.Rows.Clear();

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
            gbxIopPa.Enabled = false;

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
                gbxIopPa.Enabled = true;
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
                btnExcluir.Text = "Estorno";
            }

            if (op == 5)
            {
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void frmOrdemProducao_Load(object sender, EventArgs e)
        {
            frmPrincipal frt = new frmPrincipal();
            ((frmPrincipal)Application.OpenForms["frmPrincipal"]).LblTituloPrincipal.Text = frt.LblTituloPrincipal.Text + " - " + this.Text;

            alterabotoes(1);
        }

        private void frmOrdemProducao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
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
            frmItensPedidoVenda f = new frmItensPedidoVenda();
            f.ShowDialog();
            if ((f.codigo != 0) || (f.ipvCod != 0))
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);

                try
                {
                    BLLItensPedidoVenda bll = new BLLItensPedidoVenda(cx);
                    ModeloItensPedidoVenda modelo = bll.ItemPedidoOrdemProducao(f.codigo, f.ipvCod);

                    txbOdpCodPedido.Text = modelo.PedCod.ToString("D9");
                    txbOdpItemPedido.Text = modelo.IpvCod.ToString("D2");
                    txbOdpProCod.Text = modelo.ProCod.ToString("D6");
                    txbOdpQtde.Text = modelo.IpvQtde.ToString("N3");
                    CarregaUnidMed();
                    CarregaPA();
                  


                    BLLPlanoProducao bllpp = new BLLPlanoProducao(cx);


                    DataTable tabela = bllpp.LocalizarItemPlano(modelo.ProCod);

                    int cDt = tabela.Rows.Count;
                    if (cDt > 0)
                    {
                        for (int i = 0; i < tabela.Rows.Count; i++)
                        {
                            int ippCod = i + 1; //Convert.ToInt32(tabela.Rows[i]["ipp_cod"]);
                            int plpCod = Convert.ToInt32(tabela.Rows[i]["plp_cod"]);
                            int proCod = Convert.ToInt32(tabela.Rows[i]["pro_cod"]);
                            string proNome = tabela.Rows[i]["pro_nome"].ToString();
                            double ippQtde = Convert.ToDouble(tabela.Rows[i]["ipp_qtde"]) * Convert.ToDouble(txbOdpQtde.Text);
                            string umedSimb = tabela.Rows[i]["umed_simbolo"].ToString();
                            string iopDep = tabela.Rows[i]["ipp_deposito"].ToString();

                            string[] itemOp = new string[] {ippCod.ToString("D2"),plpCod.ToString("D9"), proCod.ToString("D6"), proNome.ToString(),
                                ippQtde.ToString("N3"), umedSimb.ToString(),iopDep.ToString() };
                            dgvItensOrdemProducao.Rows.Add(itemOp);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Não existe plano de produção para o item selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LimpaTela();
                        alterabotoes(1);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ordem Produção, Localizar - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public void CarregaPA()
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bllprod = new BLLProduto(cx);
                ModeloProduto modelo = bllprod.CarregaModeloProduto(Convert.ToInt32(txbOdpProCod.Text));

                lblOdpDescProduto.Text = modelo.ProdNome;
                cbxOdpUnidMed.SelectedValue = modelo.UmedCodigo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Carrega Descrição PA - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CarregaUnidMed()
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeDeMedida bllund = new BLLUnidadeDeMedida(cx);
                cbxOdpUnidMed.DataSource = bllund.Localizar("");
                cbxOdpUnidMed.ValueMember = "umed_cod";
                cbxOdpUnidMed.DisplayMember = "umed_simbolo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Carrega Unidade Medida - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaTela();
            alterabotoes(1);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            cx.Conectar();
            cx.IniciarTransacao();
            try
            {

                ModeloOrdemProducao modeloOp = new ModeloOrdemProducao();
                modeloOp.PedCod = Convert.ToInt32(txbOdpCodPedido.Text);
                modeloOp.ProdCod = Convert.ToInt32(txbOdpProCod.Text);
                modeloOp.OdpQtde = Convert.ToDouble(txbOdpQtde.Text);

                BLLOrdemProducao bll = new BLLOrdemProducao(cx);

                ModeloItensOrdemProducao mitens = new ModeloItensOrdemProducao();
                BLLItensOrdemProducao bllitens = new BLLItensOrdemProducao(cx);

                ModeloEstoque es = new ModeloEstoque();
                BLLEstoque blles = new BLLEstoque(cx);

                ModeloItensPedidoVenda modeloIpv = new ModeloItensPedidoVenda();
                BLLItensPedidoVenda bllIpv = new BLLItensPedidoVenda(cx);



                if (this.operacao == "inserir")
                {
                    modeloOp.OdpStatus = 0;

                    bll.Incluir(modeloOp);

                    for (int i = 0; i < dgvItensOrdemProducao.RowCount; i++)
                    {
                        mitens.Iopcod = Convert.ToInt32(dgvItensOrdemProducao.Rows[i].Cells[0].Value);
                        mitens.ProCod = Convert.ToInt32(dgvItensOrdemProducao.Rows[i].Cells[2].Value);
                        mitens.IopQtdPlano = Convert.ToDouble(dgvItensOrdemProducao.Rows[i].Cells[4].Value);
                        mitens.IopDeposito = dgvItensOrdemProducao.Rows[i].Cells[6].Value.ToString();
                        mitens.IopStatus = 0;
                        mitens.OdpCod = modeloOp.OdpCod;
                        bllitens.Incluir(mitens);
                    }

                    for (int i = 0; i < dgvItensOrdemProducao.RowCount; i++)
                    {
                       
                        es.ProdCod = Convert.ToInt32(dgvItensOrdemProducao.Rows[i].Cells[2].Value);
                        es.EstSaldoRevservado = Convert.ToDouble(dgvItensOrdemProducao.Rows[i].Cells[4].Value);
                        es.DepAbrev = Convert.ToString(dgvItensOrdemProducao.Rows[i].Cells[6].Value);
                        blles.incluirReservaEstq(es);
                    }

                    modeloIpv.PedCod = Convert.ToInt32(txbOdpCodPedido.Text);
                    modeloIpv.IpvCod = Convert.ToInt32(txbOdpItemPedido.Text);
                    modeloIpv.IpvStatus = 3;
                    bllIpv.AtualizaStatus(modeloIpv);




                    MessageBox.Show("Ordem incluída. \n Código " + modeloOp.OdpCod.ToString());
                }
                else if (this.operacao == "estorno")
                {
                    //modeloCompra.ComStatus = 1;
                    //modeloCompra.ComCod = Convert.ToInt32(txbComCod.Text);

                    //bll.Estorno(modeloCompra);

                    //for (int i = 0; i < dgvComItens.RowCount; i++)
                    //{
                    //    mitens.ItcCod = Convert.ToInt32(dgvComItens.Rows[i].Cells[1].Value);
                    //    mitens.ComCod = modeloCompra.ComCod;
                    //    mitens.ProCod = Convert.ToInt32(dgvComItens.Rows[i].Cells[2].Value);
                    //    mitens.ItcQtde = Convert.ToDouble(dgvComItens.Rows[i].Cells[4].Value);
                    //    mitens.DepCod = Convert.ToString(dgvComItens.Rows[i].Cells[6].Value);
                    //    mitens.ItcValor = Convert.ToDouble(dgvComItens.Rows[i].Cells[7].Value);
                    //    mitens.ItcStatus = 1;
                    //    bllitens.Estorno(mitens);
                    //}

                    //for (int i = 0; i < dgvComItens.RowCount; i++)
                    //{
                    //    es.EstTm = Convert.ToInt32(txbComTm.Text);
                    //    es.ProdCod = Convert.ToInt32(dgvComItens.Rows[i].Cells[2].Value);
                    //    es.EstSaldo = Convert.ToDouble(dgvComItens.Rows[i].Cells[4].Value);
                    //    es.DepAbrev = Convert.ToString(dgvComItens.Rows[i].Cells[6].Value);
                    //    es.VlrEstq = Convert.ToDouble(dgvComItens.Rows[i].Cells[8].Value);
                    //    blles.AtualizaEstoque(es);
                    //}

                    //for (int i = 0; i < dgvComParcelas.RowCount; i++)
                    //{
                    //    mparcelas.ComCod = modeloCompra.ComCod;
                    //    mparcelas.PcoCod = Convert.ToInt32(dgvComParcelas.Rows[i].Cells[1].Value);
                    //    mparcelas.PcoValor = Convert.ToDouble(dgvComParcelas.Rows[i].Cells[2].Value);
                    //    mparcelas.PcoDtVecto = Convert.ToDateTime(dgvComParcelas.Rows[i].Cells[3].Value);
                    //    mparcelas.PcoStatus = 1;
                    //    bparcelas.Estorno(mparcelas);
                    //}

                  //  MessageBox.Show("Estorno efetuado; Código " + modeloCompra.ComCod.ToString());
                }

                this.LimpaTela();
                this.alterabotoes(1);
                cx.TerminarTransacao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ordem Produção, Salvar - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cx.CancelarTransacao();
            }
            finally
            {
                cx.Desconectar();
            }
        }

        private void txbOdpItemPedido_Enter(object sender, EventArgs e)
        {
            txbOdpItemPedido.BackColor = Color.LemonChiffon;
        }

        private void txbOdpItemPedido_Leave(object sender, EventArgs e)
        {
            txbOdpItemPedido.BackColor = Color.WhiteSmoke;
        }
    }
}
