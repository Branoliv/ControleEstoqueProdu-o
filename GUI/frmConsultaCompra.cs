using BLL;
using DAL;
using MODELO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmConsultaCompra : GUI.frmModeloConsulta
    {
        public frmConsultaCompra()
        {
            InitializeComponent();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            if (txbConsNome.Text == "")
            {
                MessageBox.Show("O código do produto é necessário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
               // btnLimpar_Click(sender, e);
            }
            else
            {
               // ProcessarInfo();

                //try
                //{
                //    DALConexao pcx = new DALConexao(DadosDaConexao.StringDeConexao);
                //    BLLProduto pbll = new BLLProduto(pcx);
                //    ModeloProduto modelo = pbll.CarregaModeloProduto(Convert.ToInt32(txbConsNome.Text));


                //    BLLUnidadeDeMedida ubll = new BLLUnidadeDeMedida(pcx);
                //    ModeloUnidadeDeMedida umodelo = ubll.CarregaModeloUnidadeDeMedida(Convert.ToInt32(modelo.UmedCodigo));

                //    if (modelo.ProdNome.ToString() == "")
                //    {
                //        throw new Exception("Produto não encontrado.");
                //    }
                //    else
                //    {
                //        lblConsProd.Text = modelo.ProdNome;
                //        txbConsUmProd.Text = umodelo.UmedSimbolo;
                //        lblConsUmProd.Text = umodelo.UmedNome;
                //    }

                //    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                //    BLLEstoque bll = new BLLEstoque(cx);
                //    dgvConsEstoque.DataSource = bll.Localizar(Convert.ToInt32(txbConsNome.Text));
                //    dgvConsEstoque.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                //    dgvConsEstoque.RowTemplate.Height = 18;
                //    dgvConsEstoque.Columns[0].Visible = false;
                //    dgvConsEstoque.Columns[1].HeaderText = "Depósito";
                //    dgvConsEstoque.Columns[1].Width = 60;
                //    dgvConsEstoque.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //    dgvConsEstoque.Columns[2].HeaderText = "Saldo";
                //    dgvConsEstoque.Columns[2].Width = 60;
                //    dgvConsEstoque.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //    dgvConsEstoque.Columns[3].HeaderText = "Vlr. Unitário";
                //    dgvConsEstoque.Columns[3].Width = 100;
                //    dgvConsEstoque.Columns[3].DefaultCellStyle.Format = "n2";
                //    dgvConsEstoque.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //    dgvConsEstoque.Columns[4].HeaderText = "Vlr. Estoque";
                //    dgvConsEstoque.Columns[4].Width = 100;
                //    dgvConsEstoque.Columns[4].DefaultCellStyle.Format = "n2";
                //    dgvConsEstoque.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                //    this.Invoke(new FechaPopUp(this.FecharPopUp));
                //}

                //catch (Exception erro)
                //{
                //    this.Invoke(new FechaPopUp(this.FecharPopUp));
                //    txbConsNome.Focus();
                //    MessageBox.Show(erro.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    LimpaTela();
                //    return;
               // }
            }
        }
    }
}
