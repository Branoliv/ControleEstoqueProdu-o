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
    public partial class frmConsultaCliente : GUI.frmModeloConsulta
    {
        private frmLoading loading = new frmLoading();
        private delegate void FechaPopUp();
        public int codigo = 0;

        public frmConsultaCliente()
        {
            InitializeComponent();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            ProcessarInfo();
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                dgvConsCliente.DataSource = bll.Localizar(txbConsNome.Text);
                dgvConsCliente.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                dgvConsCliente.RowTemplate.Height = 16;
                dgvConsCliente.RowHeadersVisible = false;

                dgvConsCliente.Columns[0].HeaderText = "Código";
                dgvConsCliente.Columns[0].Width = 60;
                dgvConsCliente.Columns[0].DefaultCellStyle.Format = "d6";
                dgvConsCliente.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvConsCliente.Columns[1].HeaderText = "Nome";
                dgvConsCliente.Columns[1].Width = 364;
                dgvConsCliente.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                dgvConsCliente.Columns[2].HeaderText = "CPF/CNPJ";
                dgvConsCliente.Columns[2].Width = 150;
                dgvConsCliente.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                dgvConsCliente.Columns[3].HeaderText = "RG/Insc. Estadual";
                dgvConsCliente.Columns[3].Width = 150;
                dgvConsCliente.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                dgvConsCliente.Columns[4].HeaderText = "Razão Social";
                dgvConsCliente.Columns[4].Width = 364;
                dgvConsCliente.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                dgvConsCliente.Columns[5].Visible = false;
                
                dgvConsCliente.Columns[6].HeaderText = "Cep";
                dgvConsCliente.Columns[6].Width = 70;
                dgvConsCliente.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                dgvConsCliente.Columns[7].HeaderText = "Endereço";
                dgvConsCliente.Columns[7].Width = 364;
                dgvConsCliente.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                dgvConsCliente.Columns[8].HeaderText = "Número";
                dgvConsCliente.Columns[8].Width = 60;
                dgvConsCliente.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                dgvConsCliente.Columns[9].HeaderText = "Bairro";
                dgvConsCliente.Columns[9].Width = 200;
                dgvConsCliente.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                dgvConsCliente.Columns[10].HeaderText = "Telefone";
                dgvConsCliente.Columns[10].Width = 100;
                dgvConsCliente.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                dgvConsCliente.Columns[11].HeaderText = "Celular";
                dgvConsCliente.Columns[11].Width = 100;
                dgvConsCliente.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                dgvConsCliente.Columns[12].HeaderText = "E-mail";
                dgvConsCliente.Columns[12].Width = 200;
                dgvConsCliente.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                dgvConsCliente.Columns[13].HeaderText = "Cidade";
                dgvConsCliente.Columns[13].Width = 200;
                dgvConsCliente.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                dgvConsCliente.Columns[14].HeaderText = "Estado";
                dgvConsCliente.Columns[14].Width = 60;
                dgvConsCliente.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                dgvConsCliente.Columns[15].Visible = false;
               

                this.Invoke(new FechaPopUp(this.FecharPopUp));
            }
            catch (Exception erro)
            {
                this.Invoke(new FechaPopUp(this.FecharPopUp));
                MessageBox.Show(erro.Message);
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
            txbConsNome.Clear();
            dgvConsCliente.DataSource = null;
            dgvConsCliente.Refresh();
            txbConsNome.Focus();
        }

        private void dgvConsCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvConsCliente.Rows[e.RowIndex].Cells[0].Value);
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
