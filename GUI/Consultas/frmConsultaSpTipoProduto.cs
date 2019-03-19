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
    public partial class frmConsultaSpTipoProduto : GUI.ModelosForm.frmModeloConsultaSimples
    {
        private frmLoading loading = new frmLoading();
        private delegate void FechaPopUp();
        public int codigo = 0;

        public frmConsultaSpTipoProduto()
        {
            InitializeComponent();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            ProcessarInfo();

            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLTipoProduto blltPP = new BLLTipoProduto(cx);

                if (txbConsSpNome.Text.Equals(""))
                {
                    dgvConsSpTipoProduto.DataSource = blltPP.Localizar();
                }
                else
                {
                    dgvConsSpTipoProduto.DataSource = blltPP.Localizar(txbConsSpNome.Text);
                }

                dgvConsSpTipoProduto.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                dgvConsSpTipoProduto.Columns[0].HeaderText = "Código";
                dgvConsSpTipoProduto.Columns[0].Width = 60;
                dgvConsSpTipoProduto.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvConsSpTipoProduto.Columns[1].HeaderText = "Descrição";
                dgvConsSpTipoProduto.Columns[1].Width = 200;
                dgvConsSpTipoProduto.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                dgvConsSpTipoProduto.Columns[2].HeaderText = "Abrev.";
                dgvConsSpTipoProduto.Columns[2].Width = 60;
                dgvConsSpTipoProduto.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


                this.Invoke(new FechaPopUp(this.FecharPopUp));

            }
            catch(Exception ex)
            {
                this.Invoke(new FechaPopUp(this.FecharPopUp));
                MessageBox.Show("ConsultaSpTipoProduto, Localizar - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbConsSpNome.Clear();
            dgvConsSpTipoProduto.DataSource = null;
            txbConsSpNome.Focus();
        }

        private void dgvConsSpTipoProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvConsSpTipoProduto.Rows[e.RowIndex].Cells[0].Value);
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
