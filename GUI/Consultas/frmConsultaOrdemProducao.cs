using BLL;
using DAL;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmConsultaOrdemProducao : Form
    {
        private frmLoading loading = new frmLoading();
        private delegate void FechaPopUp();
        public int op = 1;
        public int codigo = 0;

        public frmConsultaOrdemProducao()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            dgvConsOrdemProducao.DataSource = null;
            txbCodPedidoVenda.Clear();
        }

        public void AtualizaDataGridOdProducao()
        {
            dgvConsOrdemProducao.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvConsOrdemProducao.Columns[0].HeaderText = "Od.Produção";
            dgvConsOrdemProducao.Columns[0].Width = 80;
            dgvConsOrdemProducao.Columns[0].DefaultCellStyle.Format = "D9";
            dgvConsOrdemProducao.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvConsOrdemProducao.Columns[1].HeaderText = "Pedido";
            dgvConsOrdemProducao.Columns[1].Width = 80;
            dgvConsOrdemProducao.Columns[1].DefaultCellStyle.Format = "D9";
            dgvConsOrdemProducao.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvConsOrdemProducao.Columns[2].HeaderText = "Produto";
            dgvConsOrdemProducao.Columns[2].Width = 60;
            dgvConsOrdemProducao.Columns[2].DefaultCellStyle.Format = "D6";
            dgvConsOrdemProducao.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvConsOrdemProducao.Columns[3].HeaderText = "Descrição";
            dgvConsOrdemProducao.Columns[3].Width = 200;
            dgvConsOrdemProducao.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvConsOrdemProducao.Columns[4].HeaderText = "Quant.";
            dgvConsOrdemProducao.Columns[4].Width = 60;
            dgvConsOrdemProducao.Columns[4].DefaultCellStyle.Format = "N3";
            dgvConsOrdemProducao.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvConsOrdemProducao.Columns[5].HeaderText = "U.M.";
            dgvConsOrdemProducao.Columns[5].Width = 50;
            dgvConsOrdemProducao.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvConsOrdemProducao.Columns[6].Visible = false;
        }

        private void rdbConsGeral_CheckedChanged(object sender, EventArgs e)
        {
            //Ocultar paineis
            pnlConsPedidoVenda.Visible = false;

            btnLimpar_Click(sender, e);

            if (rdbConsGeral.Checked == true)
            {
                op = 1;
            }

            if (rdbConsPedidoVenda.Checked == true)
            {
                op = 2;
                pnlConsPedidoVenda.Visible = true;
                txbCodPedidoVenda.Clear();
                txbCodPedidoVenda.Focus();
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);

                switch (op)
                {
                    case 1:

                        ProcessarInfo();

                        BLLOrdemProducao bllg = new BLLOrdemProducao(cx);
                        dgvConsOrdemProducao.DataSource = bllg.Localizar();

                        AtualizaDataGridOdProducao();

                        break;
                    case 2:

                        if (!txbCodPedidoVenda.Text.Equals(string.Empty))
                        {
                            ProcessarInfo();

                            BLLOrdemProducao bllforn = new BLLOrdemProducao(cx);
                            dgvConsOrdemProducao.DataSource = bllforn.Localizar(Convert.ToInt32(txbCodPedidoVenda.Text));
                            AtualizaDataGridOdProducao();
                        }
                        else
                        {
                            //  this.Invoke(new FechaPopUp(this.FecharPopUp));
                            MessageBox.Show("O código do pedido é necessário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }

                        break;
                }

                this.Invoke(new FechaPopUp(this.FecharPopUp));
                dgvConsOrdemProducao.Focus();
            }
            catch (Exception ex)
            {
                this.Invoke(new FechaPopUp(this.FecharPopUp));
                MessageBox.Show("Consulta Ordem Produção, Localizar - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
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

        private void txbCodPedidoVenda_Enter(object sender, EventArgs e)
        {
            txbCodPedidoVenda.BackColor = Color.LemonChiffon;
        }

        private void txbCodPedidoVenda_Leave(object sender, EventArgs e)
        {
            txbCodPedidoVenda.BackColor = Color.WhiteSmoke;
        }

        private void dgvConsOrdemProducao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvConsOrdemProducao.Rows[e.RowIndex].Cells[0].Value);
                if(this.codigo <= 0)
                {
                    return;
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void frmConsultaOrdemProducao_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                btnSair_Click(sender, e);
            }

            if(e.KeyCode == Keys.Enter)
            {
                btnLocalizar_Click(sender, e);
            }
        }
    }
}
