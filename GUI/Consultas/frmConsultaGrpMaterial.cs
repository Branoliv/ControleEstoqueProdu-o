using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL;
using System.Threading;

namespace GUI
{
    public partial class frmConsultaGrpMaterial : GUI.frmModeloConsulta
    {
        private frmLoading loading = new frmLoading();
        private delegate void FechaPopUp();
        public int codigo = 0;

        public frmConsultaGrpMaterial()
        {
            InitializeComponent();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            ProcessarInfo();
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCategoria bll = new BLLCategoria(cx);                       
                dgvConsGrpMaterial.DataSource = bll.Localizar(txbConsNome.Text);
                dgvConsGrpMaterial.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                dgvConsGrpMaterial.RowTemplate.Height = 16;
                dgvConsGrpMaterial.Columns[0].HeaderText = "Código";
                dgvConsGrpMaterial.Columns[0].Width = 60;
                dgvConsGrpMaterial.Columns[0].DefaultCellStyle.Format = "d6";
                dgvConsGrpMaterial.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvConsGrpMaterial.Columns[1].HeaderText = "Grupo Material";
                dgvConsGrpMaterial.Columns[1].Width = 364;
                dgvConsGrpMaterial.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                this.Invoke(new FechaPopUp(this.FecharPopUp));
            }
            catch (Exception erro)
            {
                this.Invoke(new FechaPopUp(this.FecharPopUp));
                MessageBox.Show(erro.Message);
            }
        }

        private void dgvConsGrpMaterial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvConsGrpMaterial.Rows[e.RowIndex].Cells[0].Value);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txbConsNome.Clear();
            dgvConsGrpMaterial.DataSource = null;
            dgvConsGrpMaterial.Refresh();
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
