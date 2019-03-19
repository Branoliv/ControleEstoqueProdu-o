using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmItensPedidoVenda : Form
    {
        public int codigo = 0;
        public int ipvCod = 0;
        public int op = 2;

        public frmItensPedidoVenda()
        {
            InitializeComponent();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);

                BLLItensPedidoVenda bll = new BLLItensPedidoVenda(cx);

                DataTable tabItensPedido = bll.Localizar();

                for (int i = 0; i < tabItensPedido.Rows.Count; i++)
                {
                    int ipvCod = Convert.ToInt32(tabItensPedido.Rows[i]["ipv_cod"]);
                    int pedCod = Convert.ToInt32(tabItensPedido.Rows[i]["ped_cod"]);
                    int proCod = Convert.ToInt32(tabItensPedido.Rows[i]["pro_cod"]);
                    double ipvQtde = Convert.ToDouble(tabItensPedido.Rows[i]["ipv_qtde"]);
                    double ipvValor = Convert.ToDouble(tabItensPedido.Rows[i]["ipv_valor"]);
                    int ipvStatus = Convert.ToInt32(tabItensPedido.Rows[i]["ipv_status"]);
                    string ipvDep = tabItensPedido.Rows[i]["ipv_dep"].ToString();

                    String[] itPed = new string[] { pedCod.ToString("D9"), ipvCod.ToString("D2"),proCod.ToString("D6"),ipvQtde.ToString("N3"),
                        ipvValor.ToString("N2"),ipvStatus.ToString("D2"),ipvDep.ToString()};
                    dgvConsItensPedVenda.Rows.Add(itPed);


                    foreach(DataGridViewRow row in dgvConsItensPedVenda.Rows)
                    {
                        if ((string)row.Cells[5].Value == "00")
                        {
                            row.DefaultCellStyle.BackColor = Color.DarkSeaGreen;
                        }
                        else if ((string)row.Cells[5].Value == "01")
                        {
                            row.DefaultCellStyle.BackColor = Color.IndianRed;
                        }
                        else if ((string)row.Cells[5].Value == "03")
                        {
                            row.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                        }
                    }
                }

                btnLocalizar.Enabled = false;
                gpbxCriterioConsPedVenda.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Itens Pedido Venda, Localizar - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                dgvConsItensPedVenda.Rows.Clear();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dgvConsItensPedVenda.Rows.Clear();
            dgvConsItensPedVenda.Refresh();

            btnLocalizar.Enabled = true;
            gpbxCriterioConsPedVenda.Visible = false;
        }

        private void dgvConsItensPedVenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvConsItensPedVenda.Rows[e.RowIndex].Cells[0].Value);
                this.ipvCod = Convert.ToInt32(dgvConsItensPedVenda.Rows[e.RowIndex].Cells[1].Value);
                int st = Convert.ToInt32(dgvConsItensPedVenda.Rows[e.RowIndex].Cells[5].Value);

                if (st == 0)
                {

                    if ((this.codigo <= 0) || (this.ipvCod <= 0))
                    {
                        return;
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("A inclusão de ordem não está disponivel para esse item. \n Verifique a existência de ordem ou cancelamento do pedido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void rdbConsGeral_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbConsGeral.Checked == true)
            {
                op = 1;

                foreach (DataGridViewRow row in dgvConsItensPedVenda.Rows)
                {
                    if ((string)row.Cells[5].Value == "00")
                    {
                        row.Visible = true;
                    }
                    else if ((string)row.Cells[5].Value == "01")
                    {
                        row.Visible = true;
                    }
                    else if ((string)row.Cells[5].Value == "03")
                    {
                        row.Visible = true;
                    }
                }
            }

            if (rdbConsSeOp.Checked == true)
            {
                op = 2;

                foreach (DataGridViewRow row in dgvConsItensPedVenda.Rows)
                {
                    if ((string)row.Cells[5].Value == "00")
                    {
                        row.Visible = true;
                    }
                    else if ((string)row.Cells[5].Value == "01")
                    {
                        row.Visible = false;
                    }
                    else if ((string)row.Cells[5].Value == "03")
                    {
                        row.Visible = false;
                    }
                }
            }

            if (rdbConsCoOp.Checked == true)
            {
                op = 3;

                foreach (DataGridViewRow row in dgvConsItensPedVenda.Rows)
                {
                    if ((string)row.Cells[5].Value == "00")
                    {
                        row.Visible = false;
                    }
                    else if ((string)row.Cells[5].Value == "01")
                    {
                        row.Visible = false;
                    }
                    else if ((string)row.Cells[5].Value == "03")
                    {
                        row.Visible = true;
                    }
                }
            }

            if (rdbConsCancelado.Checked == true)
            {
                op = 4;

                foreach (DataGridViewRow row in dgvConsItensPedVenda.Rows)
                {
                    if ((string)row.Cells[5].Value == "00")
                    {
                        row.Visible = false;
                    }
                    else if ((string)row.Cells[5].Value == "01")
                    {
                        row.Visible = true;
                    }
                    else if ((string)row.Cells[5].Value == "03")
                    {
                        row.Visible = false;
                    }
                }
            }

        }

        private void frmItensPedidoVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                btnSair_Click(sender, e);
            }
        }
    }
}
