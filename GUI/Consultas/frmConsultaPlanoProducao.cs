using BLL;
using DAL;
using MODELO;
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
    public partial class frmConsultaPlanoProducao : GUI.frmModeloConsulta
    {
        private frmLoading loading = new frmLoading();
        private delegate void FechaPopUp();
        public int codigo = 0;

        public frmConsultaPlanoProducao()
        {
            InitializeComponent();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            if (!txbConsNome.Text.Equals(String.Empty))
            {

                ProcessarInfo();
                try
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLPlanoProducao bll = new BLLPlanoProducao(cx);
                    dgvConsPlpProducao.DataSource = bll.Localizar(Convert.ToInt32(txbConsNome.Text));

                    dgvConsPlpProducao.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                    dgvConsPlpProducao.RowTemplate.Height = 16;
                    dgvConsPlpProducao.RowHeadersVisible = false;

                    dgvConsPlpProducao.Columns[0].HeaderText = "Plano Produção";
                    dgvConsPlpProducao.Columns[0].Width = 110;
                    dgvConsPlpProducao.Columns[0].DefaultCellStyle.Format = "D9";
                    dgvConsPlpProducao.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    dgvConsPlpProducao.Columns[1].HeaderText = "Produto";
                    dgvConsPlpProducao.Columns[1].Width = 60;
                    dgvConsPlpProducao.Columns[1].DefaultCellStyle.Format = "D6";
                    dgvConsPlpProducao.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    dgvConsPlpProducao.Columns[2].HeaderText = "Descrição";
                    dgvConsPlpProducao.Columns[2].Width = 350;
                    dgvConsPlpProducao.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    dgvConsPlpProducao.Columns[3].HeaderText = "Quant.";
                    dgvConsPlpProducao.Columns[3].Width = 100;
                    dgvConsPlpProducao.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    dgvConsPlpProducao.Columns[4].HeaderText = "Unid. Med.";
                    dgvConsPlpProducao.Columns[4].Width = 100;
                    dgvConsPlpProducao.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


                    this.Invoke(new FechaPopUp(this.FecharPopUp));
                }
                catch (Exception ex)
                {
                    this.Invoke(new FechaPopUp(this.FecharPopUp));
                    MessageBox.Show("ConsultaPlanoProducao, Localizar. - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Informe um código valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            lblPlpDescricaoProd.Text = "Informe o código do produto.";
            dgvConsPlpProducao.DataSource = null;
            dgvConsPlpProducao.Refresh();
            txbConsNome.Focus();
        }

        private void dgvConsPlpProducao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvConsPlpProducao.Rows[e.RowIndex].Cells[0].Value);
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

        private void btnIppLocProd_Click(object sender, EventArgs e)
        {
            frmConsultaSpProduto f = new frmConsultaSpProduto();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txbConsNome.Text = Convert.ToString(f.codigo);
                txbConsNome_Leave(sender,e);
            }
        }

        private void txbConsNome_Enter(object sender, EventArgs e)
        {
            txbConsNome.BackColor = Color.LemonChiffon;
            btnLimpar_Click(sender, e);
        }

        private void txbConsNome_Leave(object sender, EventArgs e)
        {
            txbConsNome.BackColor = Color.WhiteSmoke;
            LocalizarPA();
        }

        public void LocalizarPA()
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(Convert.ToInt32(txbConsNome.Text));

                if (modelo.ProdNome.Equals(String.Empty))
                {
                    MessageBox.Show("Produto não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblPlpDescricaoProd.Text = "Informe o código do produto.";
                    txbConsNome.Focus();
                }
                else
                {
                    lblPlpDescricaoProd.Text = modelo.ProdNome.ToString();
                }

            }
            catch
            {
                txbConsNome.Clear();
                lblPlpDescricaoProd.Text = "Informe o código do produto.";
            }
        }
    }
}
