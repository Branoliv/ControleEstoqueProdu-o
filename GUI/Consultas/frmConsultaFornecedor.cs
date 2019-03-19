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
    public partial class frmConsultaFornecedor : GUI.frmModeloConsulta
    {
        private frmLoading loading = new frmLoading();
        private delegate void FechaPopUp();
        public int codigo = 0;

        public frmConsultaFornecedor()
        {
            InitializeComponent();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            ProcessarInfo();

            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                dgvConsFornecedor.DataSource = bll.Localizar(txbConsNome.Text);
                dgvConsFornecedor.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                dgvConsFornecedor.RowTemplate.Height = 16;

                dgvConsFornecedor.Columns[0].HeaderText = "Código";
                dgvConsFornecedor.Columns[0].Width = 60;
                dgvConsFornecedor.Columns[0].DefaultCellStyle.Format = "d6";
                dgvConsFornecedor.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvConsFornecedor.Columns[1].HeaderText = "Nome";
                dgvConsFornecedor.Columns[1].Width = 364;
                dgvConsFornecedor.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                dgvConsFornecedor.Columns[2].HeaderText = "Razão Social";
                dgvConsFornecedor.Columns[2].Width = 364;
                dgvConsFornecedor.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                dgvConsFornecedor.Columns[3].HeaderText = "Insc. Estadual";
                dgvConsFornecedor.Columns[3].Width = 150;
                dgvConsFornecedor.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                dgvConsFornecedor.Columns[4].HeaderText = "CNPJ";
                dgvConsFornecedor.Columns[4].Width = 150;
                dgvConsFornecedor.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;              

                dgvConsFornecedor.Columns[5].HeaderText = "Cep";
                dgvConsFornecedor.Columns[5].Width = 70;
                dgvConsFornecedor.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                dgvConsFornecedor.Columns[6].HeaderText = "Endereço";
                dgvConsFornecedor.Columns[6].Width = 364;
                dgvConsFornecedor.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                dgvConsFornecedor.Columns[7].HeaderText = "Número";
                dgvConsFornecedor.Columns[7].Width = 60;
                dgvConsFornecedor.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                dgvConsFornecedor.Columns[8].HeaderText = "Bairro";
                dgvConsFornecedor.Columns[8].Width = 200;
                dgvConsFornecedor.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                dgvConsFornecedor.Columns[9].HeaderText = "Telefone";
                dgvConsFornecedor.Columns[9].Width = 100;
                dgvConsFornecedor.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                dgvConsFornecedor.Columns[10].HeaderText = "Celular";
                dgvConsFornecedor.Columns[10].Width = 100;
                dgvConsFornecedor.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                dgvConsFornecedor.Columns[11].HeaderText = "Email";
                dgvConsFornecedor.Columns[11].Width = 200;
                dgvConsFornecedor.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;                

                dgvConsFornecedor.Columns[12].HeaderText = "Cidade";
                dgvConsFornecedor.Columns[12].Width = 200;
                dgvConsFornecedor.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                dgvConsFornecedor.Columns[13].HeaderText = "Estado";
                dgvConsFornecedor.Columns[13].Width = 60;
                dgvConsFornecedor.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                dgvConsFornecedor.Columns[14].Visible = false;

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
            dgvConsFornecedor.DataSource = null;
            dgvConsFornecedor.Refresh();
            txbConsNome.Focus();
        }

        private void dgvConsFornecedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvConsFornecedor.Rows[e.RowIndex].Cells[0].Value);
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
    }
}
