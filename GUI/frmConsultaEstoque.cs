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
    public partial class frmConsultaEstoque : GUI.frmModeloConsulta
    {
        private frmLoading loading = new frmLoading();
        private delegate void FechaPopUp();

        public frmConsultaEstoque()
        {
            InitializeComponent();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            if (txbConsNome.Text.Equals(""))
            {
                MessageBox.Show("O código do produto é necessário.","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLimpar_Click(sender, e);
            }
            else
            {
                ProcessarInfo();

                try
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLEstoque bll = new BLLEstoque(cx);
                    dgvConsEstoque.DataSource = bll.Localizar(Convert.ToInt32(txbConsNome.Text));
                    dgvConsEstoque.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                    dgvConsEstoque.RowTemplate.Height = 18;
                    dgvConsEstoque.Columns[0].Visible = false;
                    dgvConsEstoque.Columns[1].HeaderText = "Depósito";
                    dgvConsEstoque.Columns[1].Width = 60;
                    dgvConsEstoque.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvConsEstoque.Columns[2].HeaderText = "Saldo";
                    dgvConsEstoque.Columns[2].Width = 60;
                    dgvConsEstoque.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    this.Invoke(new FechaPopUp(this.FecharPopUp));
                }

                catch (Exception erro)
                {
                    this.Invoke(new FechaPopUp(this.FecharPopUp));
                    MessageBox.Show(erro.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void frmConsultaEstoque_Load(object sender, EventArgs e)
        {
            frmPrincipal frt = new frmPrincipal();
            ((frmPrincipal)Application.OpenForms["frmPrincipal"]).LblTituloPrincipal.Text = frt.LblTituloPrincipal.Text + " - " + this.Text;            
            }

        private void txbConsNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLocalizar_Click(sender, e);
            }
        }

        private void txbConsNome_Enter(object sender, EventArgs e)
        {
            txbConsNome.BackColor = Color.LemonChiffon;
        }

        private void txbConsNome_Leave(object sender, EventArgs e)
        {
            txbConsNome.BackColor = Color.WhiteSmoke;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbConsNome.Clear();
            dgvConsEstoque.DataSource = null;
            dgvConsEstoque.Refresh();
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
    }    
}
