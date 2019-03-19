using BLL;
using DAL;
using MODELO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmConsultaPedidoVenda : Form
    {
        private frmLoading loading = new frmLoading();
        private delegate void FechaPopUp();
        public int op = 1;
        public int codigo = 0;

        public frmConsultaPedidoVenda()
        {
            InitializeComponent();
        }

        private void frmConsultaPedidoVenda_Load(object sender, EventArgs e)
        {
            dgvConsPedidoVenda.Top = 228;
            dgvConsPedidoVenda.Height = 420;
        }

        public void AtualizaDataGridPedidoVenda()
        {

            dgvConsPedidoVenda.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvConsPedidoVenda.Columns[0].HeaderText = "Pedido";
            dgvConsPedidoVenda.Columns[0].DefaultCellStyle.Format = "D9";
            dgvConsPedidoVenda.Columns[0].Width = 90;
            dgvConsPedidoVenda.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvConsPedidoVenda.Columns[1].HeaderText = "Dt. Pedido";
            dgvConsPedidoVenda.Columns[1].Width = 100;
            dgvConsPedidoVenda.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvConsPedidoVenda.Columns[2].HeaderText = "Valor";
            dgvConsPedidoVenda.Columns[2].DefaultCellStyle.Format = "N2";
            dgvConsPedidoVenda.Columns[2].Width = 100;
            dgvConsPedidoVenda.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvConsPedidoVenda.Columns[3].Visible = false;

            dgvConsPedidoVenda.Columns[4].HeaderText = "Cliente";
            dgvConsPedidoVenda.Columns[4].Width = 200;
            dgvConsPedidoVenda.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
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

                        BLLPedidoVenda bllg = new BLLPedidoVenda(cx);
                        dgvConsPedidoVenda.DataSource = bllg.Localizar();

                        AtualizaDataGridPedidoVenda();

                        break;
                    case 2:

                        if (!txbConsPedVenCli.Text.Equals(string.Empty))
                        {
                            ProcessarInfo();

                            BLLPedidoVenda bllcli = new BLLPedidoVenda(cx);
                            dgvConsPedidoVenda.DataSource = bllcli.Localizar(Convert.ToInt32(txbConsPedVenCli.Text));

                            AtualizaDataGridPedidoVenda();
                        }
                        else
                        {
                            MessageBox.Show("O código do fornecedor é necessário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }

                        break;
                    case 3:

                        ProcessarInfo();
                        DateTime dtinicial = dtpkConsPedVenDtInicial.Value;
                        DateTime dtFinal = dtpkConsPedVenDtFinal.Value;
                        BLLPedidoVenda blldatas = new BLLPedidoVenda(cx);
                        dgvConsPedidoVenda.DataSource = blldatas.Localizar(dtinicial, dtFinal);

                        AtualizaDataGridPedidoVenda();

                        break;
                }

                this.Invoke(new FechaPopUp(this.FecharPopUp));
            }
            catch (Exception ex)
            {
                MessageBox.Show("frmConsultaPedidoVenda, btnLocalizar " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Invoke(new FechaPopUp(this.FecharPopUp));
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dgvConsPedidoVenda.DataSource = null;
            dgvConsPedidoVenda.Refresh();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void rdbConsGeral_CheckedChanged(object sender, EventArgs e)
        {
             dgvConsPedidoVenda.Top = 228;
             dgvConsPedidoVenda.Height = 420;
            //Ocultar paineis
            pnlCliente.Visible = false;
            pnlDtPedido.Visible = false;
            btnLimpar_Click(sender, e);

            if (rdbConsGeral.Checked == true)
            {
                op = 1;
            }

            if (rdbConsCliente.Checked == true)
            {
                op = 2;
                pnlCliente.Visible = true;
                txbConsPedVenCli.Clear();
            }

            if (rdbConsDtPedido.Checked == true)
            {
                op = 3;
                pnlDtPedido.Visible = true;
                dtpkConsPedVenDtInicial.Value = DateTime.Now;
                dtpkConsPedVenDtFinal.Value = DateTime.Now;
            }
        }

        private void btnConsLocCliente_Click(object sender, EventArgs e)
        {
            frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                ModeloCliente modelo = bll.CarregaModeloCliente(f.codigo);

                txbConsPedVenCli.Text = modelo.CliCod.ToString("D6");
                lblConsNomeCliente.Text = modelo.CliNome.ToString();
            }
            else
            {
                //this.LimpaTela();
                // this.alterabotoes(1);
            }
            f.Dispose();
        }

        private void dgvConsPedidoVenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvConsPedidoVenda.Rows[e.RowIndex].Cells[0].Value);
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

        private void btnConsLocProduto_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f = new frmConsultaProduto();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(f.codigo);

                txbConsPedVenCli.Text = modelo.ProdCodigo.ToString("D6");
                lblConsNomeCliente.Text = modelo.ProdNome.ToString();
            }
            else
            {
                //this.LimpaTela();
                // this.alterabotoes(1);
            }
            f.Dispose();
        }

        private void txbConsPedVenCli_Enter(object sender, EventArgs e)
        {
            txbConsPedVenCli.BackColor = Color.LemonChiffon;
        }

        private void txbConsPedVenCli_Leave(object sender, EventArgs e)
        {
            txbConsPedVenCli.BackColor = Color.WhiteSmoke;
        }

        private void frmConsultaPedidoVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                btnSair_Click(sender, e);
            }
        }
    }
}
