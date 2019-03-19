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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmConsultaCompras : Form
    {
        private frmLoading loading = new frmLoading();
        private delegate void FechaPopUp();
        public int op = 1;
        public int codigo = 0;

        public frmConsultaCompras()
        {
            InitializeComponent();
        }

        private void frmConsultaCompras_Load(object sender, EventArgs e)
        {
            dgvConsCompra.Top = 228;
            dgvConsCompra.Height = 420;
        }

        public void AtualizaDataGridCompra()
        {
            dgvConsCompra.RowHeadersVisible = false;

            dgvConsCompra.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvConsCompra.Columns[0].HeaderText = "Código";
            dgvConsCompra.Columns[0].DefaultCellStyle.Format = "D6";
            dgvConsCompra.Columns[0].Width = 60;
            dgvConsCompra.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvConsCompra.Columns[1].HeaderText = "Dt. Compra";           
            dgvConsCompra.Columns[1].Width = 100;
            dgvConsCompra.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;            

            dgvConsCompra.Columns[2].HeaderText = "Nota Físcal";
            dgvConsCompra.Columns[2].DefaultCellStyle.Format = "D8";
            dgvConsCompra.Columns[2].Width = 90;
            dgvConsCompra.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvConsCompra.Columns[3].HeaderText = "Tp.Mov.";            
            dgvConsCompra.Columns[3].Width = 50;
            dgvConsCompra.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgvConsCompra.Columns[4].HeaderText = "Parcelas";
            dgvConsCompra.Columns[4].DefaultCellStyle.Format = "D2";
            dgvConsCompra.Columns[4].Width = 70;
            dgvConsCompra.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;                                 

            dgvConsCompra.Columns[5].HeaderText = "Cod. Forn.";
            dgvConsCompra.Columns[5].DefaultCellStyle.Format = "D6";
            dgvConsCompra.Columns[5].Width = 80;
            dgvConsCompra.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvConsCompra.Columns[6].HeaderText = "Status";
            dgvConsCompra.Columns[6].Visible = false;

            dgvConsCompra.Columns[7].HeaderText = "Fornecedor";
            dgvConsCompra.Columns[7].Width = 210;
            dgvConsCompra.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvConsCompra.Columns[8].HeaderText = "Tipo Pagto";
            dgvConsCompra.Columns[8].Visible = false;

            dgvConsCompra.Columns[9].HeaderText = "Vl. Compra";
            dgvConsCompra.Columns[9].DefaultCellStyle.Format = "N2";
            dgvConsCompra.Columns[9].Width = 100;
            dgvConsCompra.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
               // ProcessarInfo();
                try
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);

                    switch (op)
                    {
                        case 1:

                            ProcessarInfo();

                            BLLCompra bllg = new BLLCompra(cx);
                            dgvConsCompra.DataSource = bllg.Localizar();

                            AtualizaDataGridCompra();

                            break;
                        case 2:

                            if (!txbConsCompraForn.Text.Equals(string.Empty))
                            {
                                ProcessarInfo();

                                BLLCompra bllforn = new BLLCompra(cx);
                                dgvConsCompra.DataSource = bllforn.Localizar(Convert.ToInt32(txbConsCompraForn.Text));
                                AtualizaDataGridCompra();
                            }
                            else
                            {
                              //  this.Invoke(new FechaPopUp(this.FecharPopUp));
                                MessageBox.Show("O código do fornecedor é necessário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }

                            break;
                        case 3:

                            ProcessarInfo();
                            DateTime dtinicial = dtpkConsComDtInicial.Value;
                            DateTime dtFinal = dtpkConsComDtFinal.Value;
                            BLLCompra blldatas = new BLLCompra(cx);
                            dgvConsCompra.DataSource = blldatas.Localizar(dtinicial, dtFinal);
                            AtualizaDataGridCompra();

                            break;
                        case 4:
                            break;

                    }

                    this.Invoke(new FechaPopUp(this.FecharPopUp));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("frmConsultaCompras, btnLocalizar " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Invoke(new FechaPopUp(this.FecharPopUp));
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
            dgvConsCompra.Height = 420;
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

        private void ProcessarInfo()
        {
            Thread thProcessa = new Thread(Open_Forn);
            thProcessa.Start();
        }

        private void Open_Forn()
        {
            loading.ShowDialog();
        }

        private void FecharPopUp()
        {
            loading.Close();
        }

        private void frmConsultaCompras_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                btnSair_Click(sender, e);
            }
        }
    }
}
