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
    public partial class frmConsultaProduto : GUI.frmModeloConsulta
    {
        private frmLoading loading = new frmLoading();
        private delegate void FechaPopUp();
        public int codigo = 0;

        public frmConsultaProduto()
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
                dgvConsProduto.DataSource = bll.Localizar(txbConsNome.Text);
                dgvConsProduto.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                dgvConsProduto.RowTemplate.Height = 16;
                dgvConsProduto.RowHeadersVisible = false;

                dgvConsProduto.Columns[0].HeaderText = "Código";
                dgvConsProduto.Columns[0].Width = 60;
                dgvConsProduto.Columns[0].DefaultCellStyle.Format = "d6";
                dgvConsProduto.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


                dgvConsProduto.Columns[1].HeaderText = "Cód. de Barras";
                dgvConsProduto.Columns[1].Width = 100;
                dgvConsProduto.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                dgvConsProduto.Columns[2].HeaderText = "Produto";
                dgvConsProduto.Columns[2].Width = 100;
                dgvConsProduto.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft; 
                               
                dgvConsProduto.Columns[3].HeaderText = "Descrição Longa";
                dgvConsProduto.Columns[3].Width = 300;
                dgvConsProduto.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                dgvConsProduto.Columns[4].HeaderText = "Foto";
                //dgvConsProduto.Columns[4].Width = 60;
                //dgvConsProduto.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvConsProduto.Columns[4].Visible = false;

                dgvConsProduto.Columns[5].HeaderText = "Valor Pago";
                dgvConsProduto.Columns[5].Width = 100;
                dgvConsProduto.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                dgvConsProduto.Columns[6].HeaderText = "Valor Venda";
                dgvConsProduto.Columns[6].Width = 100;
                dgvConsProduto.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                dgvConsProduto.Columns[7].HeaderText = "Quant.";
                dgvConsProduto.Columns[7].Width = 100;
                dgvConsProduto.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                dgvConsProduto.Columns[8].HeaderText = "Unid. Med.";
                dgvConsProduto.Columns[8].Width = 85;
                dgvConsProduto.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvConsProduto.Columns[9].HeaderText = "Grupo";
                dgvConsProduto.Columns[9].Width = 150;
                dgvConsProduto.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                dgvConsProduto.Columns[10].HeaderText = "Sub Grupo";
                dgvConsProduto.Columns[10].Width = 150;
                dgvConsProduto.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                dgvConsProduto.Columns[11].HeaderText = "Ativo";
                dgvConsProduto.Columns[11].Width = 50;
                dgvConsProduto.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvConsProduto.Columns[12].HeaderText = "Tp. Prod.";
                dgvConsProduto.Columns[12].Width = 80;
                dgvConsProduto.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                
                this.Invoke(new FechaPopUp(this.FecharPopUp));
            }
            catch (Exception erro)
            {
                this.Invoke(new FechaPopUp(this.FecharPopUp));
                MessageBox.Show(erro.Message);
            }
        }

        private void dgvConsProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvConsProduto.Rows[e.RowIndex].Cells[0].Value);
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbConsNome.Clear();
            dgvConsProduto.DataSource = null;
            dgvConsProduto.Refresh();
            txbConsNome.Focus();
        }
    }
}
