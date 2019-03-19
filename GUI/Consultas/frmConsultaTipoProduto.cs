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
    public partial class frmConsultaTipoProduto : GUI.frmModeloConsulta
    {
        private frmLoading loading = new frmLoading();
        private delegate void FechaPopUp();
        public int codigo = 0;

        public frmConsultaTipoProduto()
        {
            InitializeComponent();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            ProcessarInfo();

            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLTipoProduto bll = new BLLTipoProduto(cx);

                if (txbConsNome.Text.Equals(""))
                {
                    dgvConsTipoProduto.DataSource = bll.Localizar();
                }
                else
                {
                    dgvConsTipoProduto.DataSource = bll.Localizar(txbConsNome.Text);
                }

                this.Invoke(new FechaPopUp(this.FecharPopUp));
                ConfigurDataGrid();
            }
            catch(Exception ex)
            {
                this.Invoke(new FechaPopUp(this.FecharPopUp));
                MessageBox.Show("ConsultaTipoProduto, Localizar. - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbConsNome.Clear();
            dgvConsTipoProduto.DataSource = null;
            dgvConsTipoProduto.Refresh();
            txbConsNome.Focus();
        }

        private void txbConsNome_Enter(object sender, EventArgs e)
        {
            txbConsNome.BackColor = Color.LemonChiffon;
        }

        private void txbConsNome_Leave(object sender, EventArgs e)
        {
            txbConsNome.BackColor = Color.WhiteSmoke;
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

        protected void ConfigurDataGrid()
        {
            dgvConsTipoProduto.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvConsTipoProduto.Columns[0].HeaderText = "Código";
            dgvConsTipoProduto.Columns[0].Width = 60;
            dgvConsTipoProduto.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvConsTipoProduto.Columns[1].HeaderText = "Descrição";
            dgvConsTipoProduto.Columns[1].Width = 300;
            dgvConsTipoProduto.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvConsTipoProduto.Columns[2].HeaderText = "Abreviação";
            dgvConsTipoProduto.Columns[2].Width = 70;
            dgvConsTipoProduto.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private void dgvConsTipoProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvConsTipoProduto.Rows[e.RowIndex].Cells[0].Value);
                if(this.codigo <= 0)
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
