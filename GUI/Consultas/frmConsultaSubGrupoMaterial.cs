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
    public partial class frmConsultaSubGrupoMaterial : GUI.frmModeloConsulta
    {
        private frmLoading loading = new frmLoading();
        private delegate void FechaPopUp();
        public int codigo = 0;

        public frmConsultaSubGrupoMaterial()
        {
            InitializeComponent();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            ProcessarInfo();
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSubCategoria bll = new BLLSubCategoria(cx);
                dgvConsSubGrpMaterial.DataSource = bll.Localizar(txbConsNome.Text);
                dgvConsSubGrpMaterial.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                dgvConsSubGrpMaterial.RowTemplate.Height = 16;
                dgvConsSubGrpMaterial.Columns[0].HeaderText = "Código";
                dgvConsSubGrpMaterial.Columns[0].Width = 60;
                dgvConsSubGrpMaterial.Columns[0].DefaultCellStyle.Format = "d6";
                dgvConsSubGrpMaterial.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvConsSubGrpMaterial.Columns[1].HeaderText = "Sub Grupo Material";
                dgvConsSubGrpMaterial.Columns[1].Width = 181;
                dgvConsSubGrpMaterial.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvConsSubGrpMaterial.Columns[2].HeaderText = "Grupo Material";
                dgvConsSubGrpMaterial.Columns[2].Width = 183;
                dgvConsSubGrpMaterial.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                this.Invoke(new FechaPopUp(this.FecharPopUp));

            }
            catch (Exception erro)
            {
                this.Invoke(new FechaPopUp(this.FecharPopUp));
                MessageBox.Show("frmConsultaSubGrupoMaterial, btnLocalizar_Click - " + erro.Message);
            }
        }

        private void dgvConsSubGrpMaterial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvConsSubGrpMaterial.Rows[e.RowIndex].Cells[0].Value);
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
            dgvConsSubGrpMaterial.DataSource = null;
            dgvConsSubGrpMaterial.Refresh();
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
    }
}
