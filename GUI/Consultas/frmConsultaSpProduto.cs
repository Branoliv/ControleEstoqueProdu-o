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
    public partial class frmConsultaSpProduto : GUI.ModelosForm.frmModeloConsultaSimples
    {
        private frmLoading loading = new frmLoading();
        private delegate void FechaPopUp();
        public int codigo = 0;

        public frmConsultaSpProduto()
        {
            InitializeComponent();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            ProcessarInfo();

            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                dgvConsSpProduto.DataSource = bll.LocalizarPesqSimples(txbConsSpNome.Text);
                dgvConsSpProduto.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                dgvConsSpProduto.RowTemplate.Height = 16;
                dgvConsSpProduto.RowHeadersVisible = false;

                dgvConsSpProduto.Columns[0].HeaderText = "Código";
                dgvConsSpProduto.Columns[0].Width = 60;
                dgvConsSpProduto.Columns[0].DefaultCellStyle.Format = "d6";
                dgvConsSpProduto.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;               

                dgvConsSpProduto.Columns[1].HeaderText = "Produto";
                dgvConsSpProduto.Columns[1].Width = 300;
                dgvConsSpProduto.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                this.Invoke(new FechaPopUp(this.FecharPopUp));
            }
            catch (Exception ex)
            {
                this.Invoke(new FechaPopUp(this.FecharPopUp));
                throw new Exception(ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbConsSpNome.Clear();
            dgvConsSpProduto.DataSource = null;
            dgvConsSpProduto.Refresh();
            txbConsSpNome.Focus();
        }

        private void dgvConsSpProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvConsSpProduto.Rows[e.RowIndex].Cells[0].Value);
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

        private void txbConsSpNome_Enter(object sender, EventArgs e)
        {
            txbConsSpNome.BackColor = Color.LemonChiffon;
        }

        private void txbConsSpNome_Leave(object sender, EventArgs e)
        {
            txbConsSpNome.BackColor = Color.WhiteSmoke;
        }
    }
}
