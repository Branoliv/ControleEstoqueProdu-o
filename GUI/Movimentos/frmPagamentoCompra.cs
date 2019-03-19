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
    public partial class frmPagamentoCompra : Form
    {        
        public int pcoCod = 0;
        public int status;
        public string operacao = "";

        public frmPagamentoCompra()
        {
            InitializeComponent();
        }

        public void alterabotoes(int op)
        {
            // op = operações que serão feitas com os botões
            // 1  = Preparar os botões para localizar
            // 2  = Preparar para salvar pagamento
            // 3  = Preparar a tela para excluir ou alterar
            // 4  = Preparar para pagamento
            // 5  = documento estornado. Apenas consulta e limpar tela

            btnPagar.Enabled = false;         
            btnPgtoCompraLocalizar.Enabled = false;
            btnEstornar.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            dtpkDtPagtoCompra.Enabled = false;

            if (op == 1)
            {               
                btnPgtoCompraLocalizar.Enabled = true;
            }

            if (op == 2)
            {               
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
                dtpkDtPagtoCompra.Enabled = true;
                this.operacao = "pagar";
            }

            if (op == 3)
            {               
                btnEstornar.Enabled = true;
                btnCancelar.Enabled = true;
            }

            if (op == 4)
            {
                btnPagar.Enabled = true;             
                btnCancelar.Enabled = true;               
            }

            if (op == 5)
            {                
                btnCancelar.Enabled = true;
            }

            if (op == 6)
            {
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
                dtpkDtPagtoCompra.Enabled = false;
                this.operacao = "estorno";
            }
        }

        private void frmPagamentoCompra_Load(object sender, EventArgs e)
        {
            frmPrincipal frt = new frmPrincipal();
            ((frmPrincipal)Application.OpenForms["frmPrincipal"]).LblTituloPrincipal.Text = frt.LblTituloPrincipal.Text + " - " + this.Text;

            this.alterabotoes(1);
        }
       
        public void LimpaTela()
        {
            txbPgtoComCod.Clear();
            txbPgtoComCodForn.Clear();
            txbPgtoComNf.Clear();
            lblPgtoComNomeForn.Text = String.Empty;
            dgvPgtoComParcelas.Rows.Clear();
            dtpkDtCompra.Value = DateTime.Now;
            dtpkDtPagtoCompra.Enabled = false;
            lblPagtoCompraAviso.Visible = false;
            this.status = 0;
            this.alterabotoes(1);
        }

        private void btnPgtoCompraLocalizar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();

            frmConsultaCompras f = new frmConsultaCompras();

            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                try
                {
                    BLLCompra bll = new BLLCompra(cx);
                    ModeloCompra modelo = bll.CarregaModeloCompra(f.codigo);

                    txbPgtoComCod.Text = modelo.ComCod.ToString("D8");
                    txbPgtoComNf.Text = modelo.ComNFiscal.ToString();
                    dtpkDtCompra.Value = modelo.ComData;
                    txbPgtoComCodForn.Text = modelo.ForCod.ToString("D6");
                    status = modelo.ComStatus;
                   
                    BLLFornecedor bllf = new BLLFornecedor(cx);
                    ModeloFornecedor modelof = bllf.CarregaModeloFornecedor(modelo.ForCod);

                    lblPgtoComNomeForn.Text = modelof.ForNome;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("LocalizaPgtoCompra, Dados Compra - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                carregaParcelas();
                                                        
            }
            else
            {
                 this.LimpaTela();
            }

            f.Dispose();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            frmPrincipal frt = new frmPrincipal();
            ((frmPrincipal)Application.OpenForms["frmPrincipal"]).LblTituloPrincipal.Text = frt.LblTituloPrincipal.Text;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alterabotoes(1);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (this.operacao == "pagar")
            {
                if (dtpkDtPagtoCompra.Value <= DateTime.Now)
                {
                    try
                    {
                        DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                        ModeloParcelasCompra modelo = new ModeloParcelasCompra();
                        BLLParcelasCompra bll = new BLLParcelasCompra(cx);

                        modelo.ComCod = Convert.ToInt32(txbPgtoComCod.Text);
                        modelo.PcoDtPagto = Convert.ToDateTime(dtpkDtPagtoCompra.Value);
                        modelo.PcoCod = pcoCod;
                        bll.PagtoCompra(modelo);

                        //dgvPgtoComParcelas.Refresh();
                        dgvPgtoComParcelas.Update();

                        this.alterabotoes(1);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Pagamento Compra, Salvar - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Data de pagamento precisa ser anterior ou igual a hoje.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else if(this.operacao == "estorno")
            {
                try
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    ModeloParcelasCompra modelo = new ModeloParcelasCompra();
                    BLLParcelasCompra bll = new BLLParcelasCompra(cx);

                    modelo.ComCod = Convert.ToInt32(txbPgtoComCod.Text);
                    DateTime? dtEstorno = null;
                    modelo.PcoDtPagto = Convert.ToDateTime(dtEstorno);
                    modelo.PcoCod = pcoCod;
                    bll.PagtoCompra(modelo);

                    dgvPgtoComParcelas.Refresh();

                    this.alterabotoes(1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Pagamento Compra, Salvar - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            carregaParcelas();            
        }

        private void dgvPgtoComParcelas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (status == 1)
            {
                return;
            }
            else if(e.RowIndex >= 0 && dgvPgtoComParcelas.Rows[e.RowIndex].Cells[3].Value.ToString().Equals(string.Empty))
            {
                this.alterabotoes(4);
                this.pcoCod = Convert.ToInt32(dgvPgtoComParcelas.Rows[e.RowIndex].Cells[1].Value);
            }
            else if (e.RowIndex >= 0 && !dgvPgtoComParcelas.Rows[e.RowIndex].Cells[3].Value.ToString().Equals(string.Empty))
            {
                this.alterabotoes(3);
                this.pcoCod = Convert.ToInt32(dgvPgtoComParcelas.Rows[e.RowIndex].Cells[1].Value);
            }
        }    

        private void btnPagar_Click(object sender, EventArgs e)
        {
            this.alterabotoes(2);            
        }

        private void btnEstornar_Click(object sender, EventArgs e)
        {
            this.alterabotoes(6);
        }

        public void carregaParcelas()
        {
            dgvPgtoComParcelas.Rows.Clear();

            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                ModeloParcelasCompra mparcelas = new ModeloParcelasCompra();
                BLLParcelasCompra bllparcelas = new BLLParcelasCompra(cx);
                DataTable tabelap = bllparcelas.LocalizarPgto(Convert.ToInt32(txbPgtoComCod.Text));

                for (int i = 0; i < tabelap.Rows.Count; i++)
                {
                    int pcod = Convert.ToInt32(tabelap.Rows[i]["pco_cod"]);
                    Double pvlpar = Convert.ToDouble(tabelap.Rows[i]["pco_valor"]);
                    DateTime pdtvenc = Convert.ToDateTime(tabelap.Rows[i]["pco_datavecto"]);
                    DateTime? pdtPagto;

                    if (tabelap.Rows[i]["pco_datapagto"] is DBNull)
                    {
                        pdtPagto = null;
                    }
                    else
                    {
                        pdtPagto = (DateTime)Convert.ToDateTime(tabelap.Rows[i]["pco_datapagto"]);
                    }

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

                    String[] it = new String[] { status.ToString(), pcod.ToString("D2"), pvlpar.ToString("N2"),
                            (pdtPagto != null? pdtPagto.Value.ToString("dd/MM/yyyy"):string.Empty), pdtvenc.Date.ToString("d") };
                    this.dgvPgtoComParcelas.Rows.Add(it);

                    dgvPgtoComParcelas.Columns[3].DefaultCellStyle.Format = "d";

                }

                if (status == 1)
                {
                    lblPagtoCompraAviso.Visible = true;
                    lblPagtoCompraAviso.Text = "Compra estornada.";
                }

                this.alterabotoes(5);

            }
            catch (Exception ex)
            {
                MessageBox.Show("LocalizaPgtoCompra, Parcelas Compra - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.LimpaTela();
            }
        }

    }
}
