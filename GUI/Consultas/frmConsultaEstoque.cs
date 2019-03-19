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
    public partial class frmConsultaEstoque : Form
    {
        private frmLoading loading = new frmLoading();
        private delegate void FechaPopUp();

        public frmConsultaEstoque()
        {
            InitializeComponent();
        }

        private void frmConsultaEstoqu_Load(object sender, EventArgs e)
        {
            frmPrincipal frt = new frmPrincipal();
            ((frmPrincipal)Application.OpenForms["frmPrincipal"]).LblTituloPrincipal.Text = frt.LblTituloPrincipal.Text + " - " + this.Text;
        }

        private void LimpaTela()
        {
            txbConsCodProd.Clear();
            lblConsProd.Text = "";
            txbConsUmProd.Clear();
            lblConsUmProd.Text = "";
            dgvConsEstoque.DataSource = null;
            dgvConsEstoque.Refresh();
            txbConsCodProd.Focus();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            if (txbConsCodProd.Text.Equals(""))
            {
                MessageBox.Show("O código do produto é necessário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLimpar_Click(sender, e);
            }
            else
            {
                ProcessarInfo();

                try
                {
                    DALConexao pcx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLProduto pbll = new BLLProduto(pcx);
                    ModeloProduto modelo = pbll.CarregaModeloProduto(Convert.ToInt32(txbConsCodProd.Text));


                    BLLUnidadeDeMedida ubll = new BLLUnidadeDeMedida(pcx);
                    ModeloUnidadeDeMedida umodelo = ubll.CarregaModeloUnidadeDeMedida(Convert.ToInt32(modelo.UmedCodigo));

                    if (modelo.ProdNome.ToString() == "")
                    {
                        throw new Exception("Produto não encontrado.");                                                               
                    }
                    else
                    {                       
                        lblConsProd.Text = modelo.ProdNome;
                        txbConsUmProd.Text = umodelo.UmedSimbolo;
                        lblConsUmProd.Text = umodelo.UmedNome;                        
                    }

                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLEstoque bll = new BLLEstoque(cx);
                    dgvConsEstoque.DataSource = bll.Localizar(Convert.ToInt32(txbConsCodProd.Text));
                    dgvConsEstoque.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                    dgvConsEstoque.RowTemplate.Height = 18;
                    dgvConsEstoque.Columns[0].Visible = false;
                    dgvConsEstoque.Columns[1].Visible = false;

                    dgvConsEstoque.Columns[2].HeaderText = "Depósito";
                    dgvConsEstoque.Columns[2].Width = 60;
                    dgvConsEstoque.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    dgvConsEstoque.Columns[3].HeaderText = "Saldo";
                    dgvConsEstoque.Columns[3].DefaultCellStyle.Format = "n3";
                    dgvConsEstoque.Columns[3].Width = 100;
                    dgvConsEstoque.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    dgvConsEstoque.Columns[4].HeaderText = "Vlr. Unitário";
                    dgvConsEstoque.Columns[4].Width = 100;
                    dgvConsEstoque.Columns[4].DefaultCellStyle.Format = "n2" ;
                    dgvConsEstoque.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    dgvConsEstoque.Columns[5].HeaderText = "Vlr. Estoque";
                    dgvConsEstoque.Columns[5].Width = 100;
                    dgvConsEstoque.Columns[5].DefaultCellStyle.Format = "n2";
                    dgvConsEstoque.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    dgvConsEstoque.Columns[6].HeaderText = "Reservado";
                    dgvConsEstoque.Columns[6].DefaultCellStyle.Format = "n3";
                    dgvConsEstoque.Columns[6].Width = 100;
                    dgvConsEstoque.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    dgvConsEstoque.Columns[7].HeaderText = "Bloqueado";
                    dgvConsEstoque.Columns[7].DefaultCellStyle.Format = "n3";
                    dgvConsEstoque.Columns[7].Width = 100;
                    dgvConsEstoque.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    this.Invoke(new FechaPopUp(this.FecharPopUp));
                }

                catch (Exception erro)
                {
                    this.Invoke(new FechaPopUp(this.FecharPopUp));
                    txbConsCodProd.Focus();
                    MessageBox.Show(erro.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpaTela();
                    return;
                }
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
            frmPrincipal frt = new frmPrincipal();
            ((frmPrincipal)Application.OpenForms["frmPrincipal"]).LblTituloPrincipal.Text = frt.LblTituloPrincipal.Text;
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

        private void txbConsCodProd_Enter(object sender, EventArgs e)
        {
            txbConsCodProd.BackColor = Color.LemonChiffon;
        }

        private void txbConsCodProd_Leave(object sender, EventArgs e)
        {
            txbConsCodProd.BackColor = Color.WhiteSmoke;
        }

        private void frmConsultaEstoqu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLocalizar_Click(sender, e);
            }

            if(e.KeyCode == Keys.Escape)
            {
                btnSair_Click(sender, e);
            }
        }

        private void txbConsUmProd_Enter(object sender, EventArgs e)
        {
            txbConsUmProd.BackColor = Color.LemonChiffon;
        }

        private void txbConsUmProd_Leave(object sender, EventArgs e)
        {
            txbConsUmProd.BackColor = Color.WhiteSmoke;
        }

        private void btnConsLocProd_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f = new frmConsultaProduto();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txbConsCodProd.Text = Convert.ToString(f.codigo);
                txbConsCodProd.Focus();               
            }
        }

        private void frmConsultaEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                btnSair_Click(sender, e);
            }
        }
    }
}
