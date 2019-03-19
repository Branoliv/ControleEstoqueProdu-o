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
    public partial class frmConsultaUnidadeDeMedida : GUI.frmModeloConsulta
    {
        private frmLoading loading = new frmLoading();
        private delegate void FechaPopUp();
        public int codigo = 0;

        public frmConsultaUnidadeDeMedida()
        {
            InitializeComponent();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            ProcessarInfo();
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(cx);
                dgvConsUnidMedida.DataSource = bll.Localizar(txbConsNome.Text);
                dgvConsUnidMedida.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                dgvConsUnidMedida.RowTemplate.Height = 16;
                dgvConsUnidMedida.Columns[0].HeaderText = "Código";
                dgvConsUnidMedida.Columns[0].Width = 60;
                dgvConsUnidMedida.Columns[0].DefaultCellStyle.Format = "d6";
                dgvConsUnidMedida.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvConsUnidMedida.Columns[1].HeaderText = "Unidade de Medida";
                dgvConsUnidMedida.Columns[1].Width = 300;
                dgvConsUnidMedida.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvConsUnidMedida.Columns[2].HeaderText = "Símbolo";
                dgvConsUnidMedida.Columns[2].Width = 64;
                dgvConsUnidMedida.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                this.Invoke(new FechaPopUp(this.FecharPopUp));

            }
            catch (Exception erro)
            {
                this.Invoke(new FechaPopUp(this.FecharPopUp));
                MessageBox.Show(erro.Message);
            }
        }

        private void dgvConsUnidMedida_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvConsUnidMedida.Rows[e.RowIndex].Cells[0].Value);
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbConsNome.Clear();
            dgvConsUnidMedida.DataSource = null;
            dgvConsUnidMedida.Refresh();
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
    }
}
