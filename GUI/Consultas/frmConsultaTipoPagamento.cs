using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmConsultaTipoPagamento : GUI.frmModeloConsulta
    {
        private frmLoading loading = new frmLoading();
        private delegate void FechaPopUp();
        public int codigo = 0;

        public frmConsultaTipoPagamento()
        {
            InitializeComponent();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            ProcessarInfo();
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLTipoPagamento bll = new BLLTipoPagamento(cx);
                dgvConsTpPagto.DataSource = bll.Localizar(txbConsNome.Text);
                dgvConsTpPagto.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                dgvConsTpPagto.RowTemplate.Height = 16;
                dgvConsTpPagto.Columns[0].HeaderText = "Código";
                dgvConsTpPagto.Columns[0].Width = 60;
                dgvConsTpPagto.Columns[0].DefaultCellStyle.Format = "d6";
                dgvConsTpPagto.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvConsTpPagto.Columns[1].HeaderText = "Tipo de Pagamento";
                dgvConsTpPagto.Columns[1].Width = 364;
                dgvConsTpPagto.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                this.Invoke(new FechaPopUp(this.FecharPopUp));
            }
            catch (Exception erro)
            {
                this.Invoke(new FechaPopUp(this.FecharPopUp));
                MessageBox.Show(erro.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbConsNome.Clear();
            dgvConsTpPagto.DataSource = null;
            dgvConsTpPagto.Refresh();
            txbConsNome.Focus();
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

        private void dgvConsTpPagto_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {            
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvConsTpPagto.Rows[e.RowIndex].Cells[0].Value);
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

        private void txbConsNome_Enter(object sender, EventArgs e)
        {
            txbConsNome.BackColor = Color.LemonChiffon;
        }

        private void TxbConsNome_Leave(object sender, EventArgs e)
        {
            txbConsNome.BackColor = Color.WhiteSmoke;
        }
    }
}
