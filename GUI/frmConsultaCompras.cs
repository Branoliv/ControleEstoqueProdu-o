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
    public partial class frmConsultaCompras : Form
    {
        public int op = 1;
        public int codigo = 0;
        public frmConsultaCompras()
        {
            InitializeComponent();
        }

        private void frmConsultaCompras_Load(object sender, EventArgs e)
        {
            dgvConsCompra.Top = 228;
            dgvConsCompra.Height = 519;
        }

        public void AtualizaDataGripCompra()
        {
            dgvConsCompra.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvConsCompra.Columns[0].HeaderText = "Código";
            dgvConsCompra.Columns[0].DefaultCellStyle.Format = "D6";
            dgvConsCompra.Columns[0].Width = 60;
            dgvConsCompra.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvConsCompra.Columns[1].HeaderText = "Dt. Compra";
            //dgvConsCompra.Columns[1].DefaultCellStyle.Format = ;
            dgvConsCompra.Columns[1].Width = 100;
            dgvConsCompra.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;            

            dgvConsCompra.Columns[2].HeaderText = "Nota Físcal";
            dgvConsCompra.Columns[2].DefaultCellStyle.Format = "D8";
            dgvConsCompra.Columns[2].Width = 90;
            dgvConsCompra.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvConsCompra.Columns[3].HeaderText = "Parcelas";
            dgvConsCompra.Columns[3].DefaultCellStyle.Format = "D2";
            dgvConsCompra.Columns[3].Width = 70;
            dgvConsCompra.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;                                 

            dgvConsCompra.Columns[4].HeaderText = "Cod. Forn.";
            dgvConsCompra.Columns[4].DefaultCellStyle.Format = "D6";
            dgvConsCompra.Columns[4].Width = 80;
            dgvConsCompra.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvConsCompra.Columns[5].HeaderText = "Status";
            dgvConsCompra.Columns[5].Visible = false;

            dgvConsCompra.Columns[6].HeaderText = "Fornecedor";
            dgvConsCompra.Columns[6].Width = 220;
            dgvConsCompra.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvConsCompra.Columns[7].HeaderText = "Tipo Pagto";
            dgvConsCompra.Columns[7].Visible = false;

            dgvConsCompra.Columns[8].HeaderText = "Vl. Compra";
            dgvConsCompra.Columns[8].DefaultCellStyle.Format = "N2";
            dgvConsCompra.Columns[8].Width = 100;
            dgvConsCompra.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                     

            
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            try
            {            
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);

                switch (op)
                {
                    case 1:

                        BLLCompra bllg = new BLLCompra(cx);
                        dgvConsCompra.DataSource = bllg.Localizar();
                        AtualizaDataGripCompra();

                        break;
                    case 2:

                        BLLCompra bllforn = new BLLCompra(cx);
                        dgvConsCompra.DataSource = bllforn.Localizar(Convert.ToInt32(txbConsCompraForn.Text));
                        AtualizaDataGripCompra();

                        break;
                    case 3:

                        DateTime dtinicial = dtpkConsComDtInicial.Value;
                        DateTime dtFinal = dtpkConsComDtFinal.Value;
                        BLLCompra blldatas = new BLLCompra(cx);
                        dgvConsCompra.DataSource = blldatas.Localizar(dtinicial,dtFinal);
                        AtualizaDataGripCompra();

                        break;
                    case 4:
                        break;
                }                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {            
            dgvConsCompra.DataSource = null;
            dgvConsCompra.Refresh();         
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void rdbConsGeral_CheckedChanged(object sender, EventArgs e)
        {                       
            dgvConsCompra.Top = 228;
            dgvConsCompra.Height = 519;
            //Ocultar paineis
            pnlFornecedor.Visible = false;
            pnlDtCompra.Visible = false;
            pnlParcAberto.Visible = false;

            btnLimpar_Click(sender, e);

            if(rdbConsGeral.Checked == true)
            {
                op = 1;
            }

            if(rdbConsFornecedor.Checked == true)
            {
                op = 2;
                pnlFornecedor.Visible = true;
                txbConsCompraForn.Clear();
            }

            if(rdbConsDtCompra.Checked == true)
            {
                op = 3;
                pnlDtCompra.Visible = true;
                dtpkConsComDtInicial.Value = DateTime.Now;
                dtpkConsComDtFinal.Value = DateTime.Now;
            }

            if (rdbParcAberto.Checked == true)
            {
                op = 4;
                pnlParcAberto.Visible = true;
            }
        }

        private void btnConsLocForn_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor f = new frmConsultaFornecedor();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(f.codigo);

                txbConsCompraForn.Text = modelo.ForCod.ToString("D6");
                lblConsNomeFornecedor.Text = modelo.ForNome.ToString();                
            }
            else
            {
                //this.LimpaTela();
               // this.alterabotoes(1);
            }
            f.Dispose();
        }

        private void dgvConsCompra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvConsCompra.Rows[e.RowIndex].Cells[0].Value);
                if (this.codigo <= 0)
                {
                    return;
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
