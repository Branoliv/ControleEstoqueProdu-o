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
    public partial class frmConsultaItensDeposito : GUI.frmModeloConsulta
    {
        private frmLoading loading = new frmLoading();
        private delegate void FechaPopUp();
        public int codigo = 0;
        public string deposito = "";

        public frmConsultaItensDeposito()
        {
            InitializeComponent();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            if (txbConsNome.Text.Equals(""))
            {
                MessageBox.Show("O código do produto é necessário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLimpar_Click(sender, e);
            }
            else
            {                
                ProcessarInfo();
                try
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLItensDeposito bll = new BLLItensDeposito(cx);
                    dgvConsDepositoProd.DataSource = bll.Localizar(Convert.ToInt32(txbConsNome.Text));
                    dgvConsDepositoProd.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                    dgvConsDepositoProd.RowTemplate.Height = 16;
                    dgvConsDepositoProd.Columns[0].HeaderText = "Código";
                    dgvConsDepositoProd.Columns[0].Width = 60;
                    dgvConsDepositoProd.Columns[0].DefaultCellStyle.Format = "d6";
                    dgvConsDepositoProd.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    dgvConsDepositoProd.Columns[1].HeaderText = "Descrição";
                    dgvConsDepositoProd.Columns[1].Width = 250;
                    dgvConsDepositoProd.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    dgvConsDepositoProd.Columns[2].HeaderText = "Depósito";
                    dgvConsDepositoProd.Columns[2].Width = 60;
                    dgvConsDepositoProd.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    this.Invoke(new FechaPopUp(this.FecharPopUp));
                }
                catch (Exception erro)
                {
                    this.Invoke(new FechaPopUp(this.FecharPopUp));
                    MessageBox.Show(erro.Message);
                }
            }            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbConsNome.Clear();
            dgvConsDepositoProd.DataSource = null;
            dgvConsDepositoProd.Refresh();
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

        private void txbConsNome_Enter(object sender, EventArgs e)
        {
            txbConsNome.BackColor = Color.LemonChiffon;
        }

        private void txbConsNome_Leave(object sender, EventArgs e)
        {
            txbConsNome.BackColor = Color.WhiteSmoke;
        }

        private void txbConsNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLocalizar_Click(sender, e);
            }
        }

        private void dgvConsDepositoProd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvConsDepositoProd .Rows[e.RowIndex].Cells[0].Value);
                this.deposito = Convert.ToString(dgvConsDepositoProd.Rows[e.RowIndex].Cells[2].Value);
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
