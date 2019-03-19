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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmApontamentoProducao : Form
    {
        public int odpCod = 0;
        public int iopCod = 0;
        public int proCod = 0;
        public string proDep = "";
        double custoUnit = 0;

        public frmApontamentoProducao()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txbOdpQtde.Clear();
        }

        private void frmApontamentoProducao_Load(object sender, EventArgs e)
        {
          
            txbApOdpCod.Text = odpCod.ToString("D9");
            txbApOdpItem.Text = iopCod.ToString("D2");
            txbApOdpProCod.Text = proCod.ToString("D6");
            txbApOdpDeposito.Text = proDep;
            CarregaUnidMed();
            CarregaProd();
            CalculaCusto();
        }

        public void CarregaProd()
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bllprod = new BLLProduto(cx);
                ModeloProduto modelo = bllprod.CarregaModeloProduto(proCod);

                lblApOdpDescProduto.Text = modelo.ProdNome;
                cbxApOdpUnidMed.SelectedValue = modelo.UmedCodigo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Carrega Descrição Produto - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CarregaUnidMed()
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeDeMedida bllund = new BLLUnidadeDeMedida(cx);
                cbxApOdpUnidMed.DataSource = bllund.Localizar("");
                cbxApOdpUnidMed.ValueMember = "umed_cod";
                cbxApOdpUnidMed.DisplayMember = "umed_simbolo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Carrega Unidade Medida - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CalculaCusto()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCustoOrdemProducao bllCst = new BLLCustoOrdemProducao(cx);

            DataTable tbl = bllCst.recuperaCusto(proCod);

            for (int x = 0; x < tbl.Rows.Count; x++)
            {
                custoUnit = Convert.ToDouble(tbl.Rows[x]["pro_valorpago"]);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void frmApontamentoProducao_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                btnSair_Click(sender, e);
            }

            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void txbOdpQtde_Enter(object sender, EventArgs e)
        {
            txbOdpQtde.BackColor = Color.LemonChiffon;
        }

        private void txbOdpQtde_Leave(object sender, EventArgs e)
        {
            txbOdpQtde.BackColor = Color.WhiteSmoke;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            cx.Conectar();
            cx.IniciarTransacao();
            try
            {
                //Atualizar quantidade real itens ordem produção
                ModeloItensOrdemProducao modIop = new ModeloItensOrdemProducao();
                BLLItensOrdemProducao bllIop = new BLLItensOrdemProducao(cx);

                modIop.OdpCod = Convert.ToInt32(txbApOdpCod.Text);
                modIop.Iopcod = Convert.ToInt32(txbApOdpItem.Text);
                modIop.ProCod = Convert.ToInt32(txbApOdpProCod.Text);
                modIop.IopQtdReal = Convert.ToDouble(txbOdpQtde.Text);
                bllIop.Apontamento(modIop);

                //Atualiza status item
                modIop.OdpCod = Convert.ToInt32(txbApOdpCod.Text);
                modIop.Iopcod = Convert.ToInt32(txbApOdpItem.Text);
                modIop.IopStatus = 3;
                bllIop.AtualizaStatus(modIop);

                //Atualza status ordem
                ModeloOrdemProducao modOp = new ModeloOrdemProducao();
                BLLOrdemProducao bllOp = new BLLOrdemProducao(cx);

                modOp.OdpCod = Convert.ToInt32(txbApOdpCod.Text);
                modOp.OdpStatus = 3;
                bllOp.AtualizaStatus(modOp);

                //Atualizar custo real custo ordem produção
                ModeloCustoOrdemProducao modCop = new ModeloCustoOrdemProducao();
                BLLCustoOrdemProducao bllCop = new BLLCustoOrdemProducao(cx);

                modCop.IcoCod = Convert.ToInt32(txbApOdpItem.Text);
                modCop.OdpCod = Convert.ToInt32(txbApOdpCod.Text);
                modCop.CopCstReal = custoUnit * Convert.ToDouble(txbOdpQtde.Text);
                bllCop.Apontamento(modCop);

                //Atualizar estoque matéria prima
                ModeloEstoque modEst = new ModeloEstoque();
                BLLEstoque bllEst = new BLLEstoque(cx);

                modEst.EstTm = 2;//código saída
                modEst.ProdCod = Convert.ToInt32(txbApOdpProCod.Text);
                modEst.DepAbrev = txbApOdpDeposito.Text;
                modEst.EstSaldo = Convert.ToDouble(txbOdpQtde.Text);
                modEst.EstSaldoRevservado = Convert.ToDouble(txbOdpQtde.Text);
                modEst.VlrEstq = modCop.CopCstReal;
                bllEst.AtualizaEstoque(modEst);
                bllEst.Reserva(modEst);

                cx.TerminarTransacao();
                LimpaTela();
                btnSair_Click(sender,e);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Apomtamento Ordem Produção, Salvar - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cx.CancelarTransacao();
            }
            finally
            {
                cx.Desconectar();
            }
        }
    }
}
