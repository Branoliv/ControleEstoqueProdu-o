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
    public partial class frmConsultaDeposito : GUI.frmModeloConsulta
    {
        private frmLoading loading = new frmLoading();
        private delegate void FechaPopUp();
        public int codigo = 0;
        

        public frmConsultaDeposito()
        {
            InitializeComponent();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            ProcessarInfo();
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLDeposito bll = new BLLDeposito(cx);
                dgvConsDeposito.DataSource = bll.Localizar(txbConsNome.Text);
                dgvConsDeposito.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                dgvConsDeposito.RowTemplate.Height = 16;
                dgvConsDeposito.Columns[0].HeaderText = "Código";
                dgvConsDeposito.Columns[0].Width = 60;
                dgvConsDeposito.Columns[0].DefaultCellStyle.Format = "d6";
                dgvConsDeposito.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvConsDeposito.Columns[1].HeaderText = "Depósito";
                dgvConsDeposito.Columns[1].Width = 60;
                dgvConsDeposito.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvConsDeposito.Columns[2].HeaderText = "Descrição";
                dgvConsDeposito.Columns[2].Width = 304;
                dgvConsDeposito.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

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
            dgvConsDeposito.DataSource = null;
            dgvConsDeposito.Refresh();
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

        private void dgvConsDeposito_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvConsDeposito.Rows[e.RowIndex].Cells[0].Value);
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
