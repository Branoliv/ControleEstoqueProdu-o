using BLL;
using DAL;
using MODELO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace GUI
{
    public partial class frmOrdemProducao : Form
    {
        /* status:
        // 0 = ativo
        // 1 = cancelado
        // 2 = finalizado
        // 3 = em processo */

        public String operacao = "";
        double verificaQtdeOp;
        List<Custo> custo = new List<Custo>();
        List<ModeloCustoOrdemProducao> custoInicial = new List<ModeloCustoOrdemProducao>();

        public frmOrdemProducao()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txbOdpCod.Clear();
            txbOdpItemPedido.Clear();
            txbOdpCodPedido.Clear();
            txbOdpProCod.Clear();
            lblOdpDescProduto.Text = "Informe o código do produto acabado.";
            txbOdpQtde.Clear();
            txbOdpPlProducao.Clear();
            cbxOdpUnidMed.DataSource = null;
            iopExcluir.Visible = false;
            dgvItensOrdemProducao.Rows.Clear();
            dgvItensConsOrdemProducao.Rows.Clear();
            txbOdpCstOpTeorico.Clear();
            txbOdpCstOpReal.Clear();
            dgvCustoOrdem.DataSource = null;
            custo.Clear();
            custoInicial.Clear();
            lblOdpStatus.Visible = false;
        }

        public void alterabotoes(int op)
        {
            // op = operações que serão feitas com os botões
            // 1  = Preparar os botões para inserir e localizar
            // 2  = Preparar os para inserir/alterar um registro
            // 3  = Preparar a tela para excluir ou alterar
            // 4  = visualização dos itens sem alterar

            pnlDados.Enabled = false;
            btnInserir.Enabled = false;
            btnAlterar.Enabled = false;
            btnLocalizar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnApontar.Enabled = false;
            gbxIopPa.Enabled = false;
            btnFinalizar.Enabled = false;

            if (op == 1)
            {
                btnInserir.Enabled = true;
                btnLocalizar.Enabled = true;

            }
            if (op == 2)
            {
                pnlDados.Enabled = true;
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
                gbxIopPa.Enabled = true;
            }
            if (op == 3)
            {
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
                btnApontar.Enabled = true;
                btnFinalizar.Enabled = true;
            }

            if (op == 4)
            {
                pnlDados.Enabled = true;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnCancelar.Enabled = true;
            }

            if (op == 5)
            {
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void frmOrdemProducao_Load(object sender, EventArgs e)
        {
            frmPrincipal frt = new frmPrincipal();
            ((frmPrincipal)Application.OpenForms["frmPrincipal"]).LblTituloPrincipal.Text = frt.LblTituloPrincipal.Text + " - " + this.Text;

            alterabotoes(1);
        }

        private void frmOrdemProducao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnSair_Click(sender, e);
            }

            if(e.KeyCode == Keys.F5)
            {
                btnLocalizar_Click(sender, e);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            frmPrincipal frt = new frmPrincipal();
            ((frmPrincipal)Application.OpenForms["frmPrincipal"]).LblTituloPrincipal.Text = frt.LblTituloPrincipal.Text;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            alterabotoes(2);
            frmItensPedidoVenda f = new frmItensPedidoVenda();
            f.ShowDialog();
            txbOdpProCod.Focus();
            if ((f.codigo != 0) || (f.ipvCod != 0))
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);

                try
                {
                    BLLItensPedidoVenda bll = new BLLItensPedidoVenda(cx);
                    ModeloItensPedidoVenda modelo = bll.ItemPedidoOrdemProducao(f.codigo, f.ipvCod);

                    BLLPlanoProducao bllpp = new BLLPlanoProducao(cx);
                    DataTable tb = bllpp.Localizar(modelo.ProCod);

                    int cDt = tb.Rows.Count;
                    if (cDt > 0)
                    {
                        int plpCod = Convert.ToInt32(tb.Rows[0]["plp_cod"]);

                        txbOdpCodPedido.Text = modelo.PedCod.ToString("D9");
                        txbOdpItemPedido.Text = modelo.IpvCod.ToString("D2");
                        txbOdpProCod.Text = modelo.ProCod.ToString("D6");
                        txbOdpQtde.Text = modelo.IpvQtde.ToString("N3");
                        CarregaUnidMed();
                        CarregaPA();
                        txbOdpPlProducao.Text = plpCod.ToString("D9");
                        pnlDados.Enabled = false;
                        CarregaPlano(modelo.ProCod);
                        CalculaCusto();
                        DescricaoCusto<ModeloCustoOrdemProducao>(custoInicial);
                        CarregaCusto<Custo>(custo);
                    }
                    else if(cDt == 0)
                    {
                        LimpaTela();
                        alterabotoes(1);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Não existe plano de produção para o item selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LimpaTela();
                        alterabotoes(1);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ordem Produção, Localizar - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public void CarregaPlano(int codigo)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLPlanoProducao bllpp = new BLLPlanoProducao(cx);
            DataTable tabela = bllpp.LocalizarItemPlano(codigo);

            dgvItensOrdemProducao.Rows.Clear();

            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                int ippCod = i + 1; 

                int proCod = Convert.ToInt32(tabela.Rows[i]["pro_cod"]);
                string proNome = tabela.Rows[i]["pro_nome"].ToString();
                double ippQtde = Convert.ToDouble(tabela.Rows[i]["ipp_qtde"]) * Convert.ToDouble(txbOdpQtde.Text);
                string umedSimb = tabela.Rows[i]["umed_simbolo"].ToString();
                string iopDep = tabela.Rows[i]["ipp_deposito"].ToString();

                string[] itemOp = new string[] {ippCod.ToString("D2"), proCod.ToString("D6"), proNome.ToString(),
                                ippQtde.ToString("N3"), umedSimb.ToString(),iopDep.ToString() };
                dgvItensOrdemProducao.Rows.Add(itemOp);
            }
        }

        public struct Custo
        {
            public string Categoria;
            public string SubCategoria;
            public double CustoTeorico;
            public double CustoReal;
            public int OrdemProducao;
        }

        public void CalculaCusto()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCustoOrdemProducao bllCst = new BLLCustoOrdemProducao(cx);

            custoInicial.Clear();
            
            for (int i = 0; i <dgvItensOrdemProducao.Rows.Count; i++)
            {
                int proCod = Convert.ToInt32(dgvItensOrdemProducao.Rows[i].Cells[1].Value);
                double qtde = Convert.ToDouble(dgvItensOrdemProducao.Rows[i].Cells[3].Value);

                DataTable tbl = bllCst.recuperaCusto(proCod);

                for (int x = 0; x < tbl.Rows.Count; x++)
                {
                    custoInicial.Add(new ModeloCustoOrdemProducao
                    {
                        CatCod = Convert.ToInt32(tbl.Rows[x]["cat_cod"]),
                        Scatcod = Convert.ToInt32(tbl.Rows[x]["scat_cod"]),
                        CopCstTeorico = Convert.ToDouble(tbl.Rows[x]["pro_valorpago"]) * qtde,
                        CopCstReal = 0
                    });

                    int j = custoInicial.Count();
                }
            }
        }

        public void DescricaoCusto<T>(List<ModeloCustoOrdemProducao> custoinic)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCustoOrdemProducao bllCst = new BLLCustoOrdemProducao(cx);

            custo.Clear();

            foreach(var i in  custoInicial)
            {
                int catCod = i.CatCod;
                int scatCod = i.Scatcod;

                DataTable tbl = bllCst.Grupo(catCod, scatCod);

                for (int x = 0; x < tbl.Rows.Count; x++)
                {
                    custo.Add(new Custo
                    {
                        Categoria = tbl.Rows[x]["cat_nome"].ToString(),
                        SubCategoria = tbl.Rows[x]["scat_nome"].ToString(),
                        CustoTeorico = i.CopCstTeorico,
                        CustoReal = i.CopCstReal
                    });

                    int j = custo.Count();
                }
            }
        }

        public void CarregaCusto<T>(List<Custo> cust)
        {
            var query = from l in cust
                        group l by new
                        {
                            Categoria = l.Categoria,
                            SubCategoria = l.SubCategoria,
                        } into g
                        select new
                        {
                            g.Key.Categoria,
                            g.Key.SubCategoria,
                            Teórico = g.Sum(l => l.CustoTeorico),
                            Real = g.Sum(l => l.CustoReal)
                        };

            cust.Sort((comp1, comp2) => comp1.Categoria.CompareTo(comp2.Categoria));

            foreach (var resultado in query)
            {
                dgvCustoOrdem.DataSource = query.ToList();

                dgvCustoOrdem.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvCustoOrdem.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvCustoOrdem.Columns[2].DefaultCellStyle.Format = "N2";
                dgvCustoOrdem.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvCustoOrdem.Columns[3].DefaultCellStyle.Format = "N2";
                dgvCustoOrdem.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            double totalTeorico = 0;
            double totalReal = 0;

            for (int i = 0; i < dgvCustoOrdem.Rows.Count; i++)
            {
                 totalTeorico += Convert.ToDouble(dgvCustoOrdem.Rows[i].Cells[2].Value);
                totalReal += Convert.ToDouble(dgvCustoOrdem.Rows[i].Cells[3].Value);
            }

            txbOdpCstOpTeorico.Text = totalTeorico.ToString("N2");
            txbOdpCstOpReal.Text = totalReal.ToString("N2");

        }

        public void CarregaPA()
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bllprod = new BLLProduto(cx);
                ModeloProduto modelo = bllprod.CarregaModeloProduto(Convert.ToInt32(txbOdpProCod.Text));

                lblOdpDescProduto.Text = modelo.ProdNome;
                cbxOdpUnidMed.SelectedValue = modelo.UmedCodigo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Carrega Descrição PA - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CarregaUnidMed()
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeDeMedida bllund = new BLLUnidadeDeMedida(cx);
                cbxOdpUnidMed.DataSource = bllund.Localizar("");
                cbxOdpUnidMed.ValueMember = "umed_cod";
                cbxOdpUnidMed.DisplayMember = "umed_simbolo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Carrega Unidade Medida - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CarregaGridConsumo()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            ModeloItensOrdemProducao modeloIop = new ModeloItensOrdemProducao();
            BLLItensOrdemProducao bllIop = new BLLItensOrdemProducao(cx);
            DataTable tbl = bllIop.Localizar(Convert.ToInt32(txbOdpCod.Text));

            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                int iopCod = Convert.ToInt32(tbl.Rows[i]["iop_cod"]);
                int proCod = Convert.ToInt32(tbl.Rows[i]["pro_cod"]);
                string proNome = tbl.Rows[i]["pro_nome"].ToString();
                double iopQtdplano = Convert.ToDouble(tbl.Rows[i]["iop_qtdplano"]);
                bool iopQtdReal = Convert.IsDBNull(tbl.Rows[i]["iop_qtdreal"]);
                string umedSimb = tbl.Rows[i]["umed_simbolo"].ToString();
                string iopDep = tbl.Rows[i]["iop_deposito"].ToString();

                double iopQtdeReal = 0;
                if (iopQtdReal)
                {
                    iopQtdeReal = 0;
                }
                else
                {
                    iopQtdeReal = Convert.ToDouble(tbl.Rows[i]["iop_qtdreal"]);
                }

                string[] itemReal = new string[] { iopCod.ToString("D2"), proCod.ToString("D6"), proNome.ToString(),iopQtdplano.ToString("N3"),
                        iopQtdeReal.ToString("N3"), umedSimb.ToString(),iopDep.ToString()};
                this.dgvItensConsOrdemProducao.Rows.Add(itemReal);
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaOrdemProducao f = new frmConsultaOrdemProducao();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                this.LimpaTela();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);

                try
                {
                    BLLOrdemProducao bllOd = new BLLOrdemProducao(cx);
                    ModeloOrdemProducao modeloOd = bllOd.CarregaOrdemProducao(f.codigo);

                    txbOdpCod.Text = modeloOd.OdpCod.ToString("D9");
                    txbOdpCodPedido.Text = modeloOd.PedCod.ToString("D9");
                    txbOdpProCod.Text = modeloOd.ProdCod.ToString("D6");
                    CarregaPA();
                    txbOdpQtde.Text = modeloOd.OdpQtde.ToString("N3");
                    CarregaUnidMed();
                    txbOdpItemPedido.Text = modeloOd.IpvCod.ToString("D2");

                    BLLPlanoProducao bllpp = new BLLPlanoProducao(cx);
                    DataTable tb = bllpp.Localizar(Convert.ToInt32(txbOdpProCod.Text));
                    int plpCod = Convert.ToInt32(tb.Rows[0]["plp_cod"]);
                    txbOdpPlProducao.Text = plpCod.ToString("D9");

                    ModeloItensOrdemProducao modeloIop = new ModeloItensOrdemProducao();
                    BLLItensOrdemProducao bllIop = new BLLItensOrdemProducao(cx);
                    DataTable tabela = bllIop.Localizar(modeloOd.OdpCod);

                    for (int i = 0; i < tabela.Rows.Count; i++)
                    {
                        int iopCod = Convert.ToInt32(tabela.Rows[i]["iop_cod"]);
                        int proCod = Convert.ToInt32(tabela.Rows[i]["pro_cod"]);
                        string proNome = tabela.Rows[i]["pro_nome"].ToString();
                        double iopQtdplano = Convert.ToDouble(tabela.Rows[i]["iop_qtdplano"]);
                        string umedSimb = tabela.Rows[i]["umed_simbolo"].ToString();
                        string iopDep = tabela.Rows[i]["iop_deposito"].ToString();

                        string[] item = new string[] { iopCod.ToString("D2"), proCod.ToString("D6"), proNome.ToString(),iopQtdplano.ToString("N3"),
                        umedSimb.ToString(),iopDep.ToString()};
                        this.dgvItensOrdemProducao.Rows.Add(item);
                    }

                    CarregaGridConsumo();

                    ModeloCustoOrdemProducao modeloCop = new ModeloCustoOrdemProducao();
                    BLLCustoOrdemProducao bllCop = new BLLCustoOrdemProducao(cx);
                    DataTable tblCop = bllCop.Localizar(modeloOd.OdpCod);

                    for (int x = 0; x < tblCop.Rows.Count; x++)
                    {
                        custoInicial.Add(new ModeloCustoOrdemProducao
                        {
                            CatCod = Convert.ToInt32(tblCop.Rows[x]["cat_cod"]),
                            Scatcod = Convert.ToInt32(tblCop.Rows[x]["scat_cod"]),
                            CopCstTeorico = Convert.ToDouble(tblCop.Rows[x]["cop_custoteoricosubit"]),
                            CopCstReal = Convert.ToDouble(tblCop.Rows[x]["cop_custorealsubit"])
                        });

                        int j = custoInicial.Count();
                    }

                   // CalculaCusto();
                    DescricaoCusto<ModeloCustoOrdemProducao>(custoInicial);
                    CarregaCusto<Custo>(custo);

                    if(modeloOd.OdpStatus == 4)
                    {
                        this.alterabotoes(4);
                        lblOdpStatus.ForeColor = Color.Red;
                        lblOdpStatus.Text = "Finalizada";
                        lblOdpStatus.Visible = true;
                    }
                    else if(modeloOd.OdpStatus == 3)
                    {
                        this.alterabotoes(3);
                        lblOdpStatus.ForeColor = Color.Yellow;
                        lblOdpStatus.Text = "Em processo...";
                        lblOdpStatus.Visible = true;
                    }
                    else
                    {
                        this.alterabotoes(3);
                        lblOdpStatus.Visible = false;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ordem Produção, Localizar - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.LimpaTela();
                }
            }
            else
            {
                this.LimpaTela();
                this.alterabotoes(1);
            }
            f.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaTela();
            alterabotoes(1);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            cx.Conectar();
            cx.IniciarTransacao();
            try
            {
                ModeloOrdemProducao modeloOp = new ModeloOrdemProducao();
                modeloOp.PedCod = Convert.ToInt32(txbOdpCodPedido.Text);
                modeloOp.IpvCod = Convert.ToInt32(txbOdpItemPedido.Text);
                modeloOp.ProdCod = Convert.ToInt32(txbOdpProCod.Text);
                modeloOp.OdpQtde = Convert.ToDouble(txbOdpQtde.Text);

                BLLOrdemProducao bll = new BLLOrdemProducao(cx);

                ModeloItensOrdemProducao mitens = new ModeloItensOrdemProducao();
                BLLItensOrdemProducao bllitens = new BLLItensOrdemProducao(cx);

                ModeloEstoque es = new ModeloEstoque();
                BLLEstoque blles = new BLLEstoque(cx);

                ModeloPedidoVenda modeloPv = new ModeloPedidoVenda();
                BLLPedidoVenda bllPv = new BLLPedidoVenda(cx);

                ModeloItensPedidoVenda modeloIpv = new ModeloItensPedidoVenda();
                BLLItensPedidoVenda bllIpv = new BLLItensPedidoVenda(cx);

                ModeloCustoOrdemProducao modeloCop = new ModeloCustoOrdemProducao();
                BLLCustoOrdemProducao bllCop = new BLLCustoOrdemProducao(cx);

                if (this.operacao == "inserir")
                {
                    modeloOp.OdpStatus = 0;

                    bll.Incluir(modeloOp);

                    for (int i = 0; i < dgvItensOrdemProducao.RowCount; i++)
                    {
                        mitens.Iopcod = Convert.ToInt32(dgvItensOrdemProducao.Rows[i].Cells[0].Value);
                        mitens.ProCod = Convert.ToInt32(dgvItensOrdemProducao.Rows[i].Cells[1].Value);
                        mitens.IopQtdPlano = Convert.ToDouble(dgvItensOrdemProducao.Rows[i].Cells[3].Value);
                        mitens.IopDeposito = dgvItensOrdemProducao.Rows[i].Cells[5].Value.ToString();
                        mitens.IopStatus = 0;
                        mitens.OdpCod = modeloOp.OdpCod;
                        bllitens.Incluir(mitens);
                    }

                    for (int i = 0; i < dgvItensOrdemProducao.RowCount; i++)
                    {
                        es.EstTm = 1;
                        es.ProdCod = Convert.ToInt32(dgvItensOrdemProducao.Rows[i].Cells[1].Value);
                        es.EstSaldoRevservado = Convert.ToDouble(dgvItensOrdemProducao.Rows[i].Cells[3].Value);
                        es.DepAbrev = Convert.ToString(dgvItensOrdemProducao.Rows[i].Cells[5].Value);
                        blles.Reserva(es);
                    }

                    foreach (var i in custoInicial)
                    {
                        int d = custoInicial.LastIndexOf(i);
                        d++;
                        int item = d;
                        modeloCop.CatCod = i.CatCod;
                        modeloCop.Scatcod = i.Scatcod;
                        modeloCop.CopCstTeorico = i.CopCstTeorico;
                        modeloCop.CopCstReal = i.CopCstReal;
                        modeloCop.OdpCod = modeloOp.OdpCod;
                        modeloCop.IcoCod = item;
                        bllCop.Incluir(modeloCop);
                    }

                    modeloPv.PedCod = Convert.ToInt32(txbOdpCodPedido.Text);
                    modeloPv.PedStatus = 3;
                    bllPv.AtualizaStatus(modeloPv);

                    modeloIpv.PedCod = Convert.ToInt32(txbOdpCodPedido.Text);
                    modeloIpv.IpvCod = Convert.ToInt32(txbOdpItemPedido.Text);
                    modeloIpv.IpvStatus = 3;
                    bllIpv.AtualizaStatus(modeloIpv);

                    MessageBox.Show("Ordem incluída. \n Código " + modeloOp.OdpCod.ToString());
                }
                else if (this.operacao == "alterar")
                {
                    modeloOp.OdpCod = Convert.ToInt32(txbOdpCod.Text);
                    modeloOp.OdpStatus = 0;

                    for (int x = 0; x < dgvItensOrdemProducao.RowCount; x++)
                    {
                        int iopCod = Convert.ToInt32(dgvItensOrdemProducao.Rows[x].Cells[0].Value);

                        if (!bllCop.ContemItem(modeloOp.OdpCod, iopCod))
                        {
                            throw new Exception("Ordem com apontamento não pode ser alterada.");
                        }
                    }

                    bll.Alterar(modeloOp);
                    DataTable tabela = bllitens.Localizar(Convert.ToInt32(txbOdpCod.Text));

                    //Estorna a reserva no estoque
                    for (int i = 0; i < tabela.Rows.Count; i++)
                    {
                        es.EstTm = 2;
                        es.ProdCod = Convert.ToInt32(tabela.Rows[i]["pro_cod"]);
                        es.EstSaldoRevservado = Convert.ToDouble(tabela.Rows[i]["iop_qtdplano"]);
                        es.DepAbrev = tabela.Rows[i]["iop_deposito"].ToString();
                        blles.Reserva(es);
                    }

                    bllitens.ExcluirItem(Convert.ToInt32(txbOdpCod.Text));

                    for (int i = 0; i < dgvItensOrdemProducao.RowCount; i++)
                    {
                        mitens.Iopcod = Convert.ToInt32(dgvItensOrdemProducao.Rows[i].Cells[0].Value);
                        mitens.ProCod = Convert.ToInt32(dgvItensOrdemProducao.Rows[i].Cells[1].Value);
                        mitens.IopQtdPlano = Convert.ToDouble(dgvItensOrdemProducao.Rows[i].Cells[3].Value);
                        mitens.IopDeposito = dgvItensOrdemProducao.Rows[i].Cells[5].Value.ToString();
                        mitens.IopStatus = 0;
                        mitens.OdpCod = modeloOp.OdpCod;
                        bllitens.Incluir(mitens);
                    }

                    bllCop.Excluir(Convert.ToInt32(txbOdpCod.Text));

                    foreach (var i in custoInicial)
                    {
                        int d = custoInicial.LastIndexOf(i);
                        d++;
                        int item = d;
                        modeloCop.CatCod = i.CatCod;
                        modeloCop.Scatcod = i.Scatcod;
                        modeloCop.CopCstTeorico = i.CopCstTeorico;
                        modeloCop.CopCstReal = i.CopCstReal;
                        modeloCop.OdpCod = modeloOp.OdpCod;
                        modeloCop.IcoCod = item;
                        bllCop.Incluir(modeloCop);
                    }

                    //Inclui a reserva no estoque
                    for (int i = 0; i < dgvItensOrdemProducao.RowCount; i++)
                    {
                        es.EstTm = 1;
                        es.ProdCod = Convert.ToInt32(dgvItensOrdemProducao.Rows[i].Cells[1].Value);
                        es.EstSaldoRevservado = Convert.ToDouble(dgvItensOrdemProducao.Rows[i].Cells[3].Value);
                        es.DepAbrev = Convert.ToString(dgvItensOrdemProducao.Rows[i].Cells[5].Value);
                        blles.Reserva(es);
                    }

                    MessageBox.Show("Alteração efetuada com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                  
                this.LimpaTela();
                this.alterabotoes(1);
                cx.TerminarTransacao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ordem Produção, Salvar - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cx.CancelarTransacao();
                this.LimpaTela();
                this.alterabotoes(1);
            }
            finally
            {
                cx.Desconectar();
            }
        }

        private void txbOdpItemPedido_Enter(object sender, EventArgs e)
        {
            txbOdpItemPedido.BackColor = Color.LemonChiffon;
        }

        private void txbOdpItemPedido_Leave(object sender, EventArgs e)
        {
            txbOdpItemPedido.BackColor = Color.WhiteSmoke;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alterabotoes(2);
          //  iopExcluir.Visible = true;
            verificaQtdeOp = Convert.ToDouble(txbOdpQtde.Text);
        }

        private void txbOdpQtde_Enter(object sender, EventArgs e)
        {
            txbOdpQtde.BackColor = Color.LemonChiffon;
        }

        private void txbOdpQtde_Leave(object sender, EventArgs e)
        {
            txbOdpQtde.BackColor = Color.WhiteSmoke;

            if (!txbOdpProCod.Text.Equals(""))
            {
                txbOdpQtde.Text = Double.Parse(txbOdpQtde.Text).ToString("N3");

                if (Convert.ToDouble(txbOdpQtde.Text) != verificaQtdeOp)
                {
                    CarregaPlano(Convert.ToInt32(txbOdpProCod.Text));
                    CalculaCusto();
                    DescricaoCusto<ModeloCustoOrdemProducao>(custoInicial);
                    CarregaCusto<Custo>(custo);
                }

                verificaQtdeOp = Convert.ToDouble(txbOdpQtde.Text);
            }
        }

        private void txbOdpProCod_Enter(object sender, EventArgs e)
        {
            txbOdpProCod.BackColor = Color.LemonChiffon;
        }

        private void txbOdpProCod_Leave(object sender, EventArgs e)
        {
            txbOdpProCod.BackColor = Color.WhiteSmoke;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            cx.Conectar();
            cx.IniciarTransacao();
            try
            {
                ModeloOrdemProducao modeloOp = new ModeloOrdemProducao();

                modeloOp.PedCod = Convert.ToInt32(txbOdpCodPedido.Text);
                modeloOp.IpvCod = Convert.ToInt32(txbOdpItemPedido.Text);
                modeloOp.ProdCod = Convert.ToInt32(txbOdpProCod.Text);
                modeloOp.OdpQtde = Convert.ToDouble(txbOdpQtde.Text);
                modeloOp.OdpCod = Convert.ToInt32(txbOdpCod.Text);

                BLLOrdemProducao bll = new BLLOrdemProducao(cx);

                ModeloItensOrdemProducao mitens = new ModeloItensOrdemProducao();
                BLLItensOrdemProducao bllitens = new BLLItensOrdemProducao(cx);

                ModeloEstoque modeloEs = new ModeloEstoque();
                BLLEstoque blles = new BLLEstoque(cx);

                ModeloPedidoVenda modeloPv = new ModeloPedidoVenda();
                BLLPedidoVenda bllPv = new BLLPedidoVenda(cx);

                ModeloItensPedidoVenda modeloIpv = new ModeloItensPedidoVenda();
                BLLItensPedidoVenda bllIpv = new BLLItensPedidoVenda(cx);

                ModeloCustoOrdemProducao modeloCop = new ModeloCustoOrdemProducao();
                BLLCustoOrdemProducao bllCop = new BLLCustoOrdemProducao(cx);

                for (int x = 0; x < dgvItensOrdemProducao.RowCount; x++)
                {
                    int iopCod = Convert.ToInt32(dgvItensOrdemProducao.Rows[x].Cells[0].Value);

                    if (!bllCop.ContemItem(modeloOp.OdpCod, iopCod))
                    {
                        throw new Exception("Ordem com apontamento não pode ser excluida.");
                    }
                }

                //Excluir custos ordem produção
                bllCop.Excluir(Convert.ToInt32(txbOdpCod.Text));

                modeloPv.PedCod = Convert.ToInt32(txbOdpCodPedido.Text);
                modeloPv.PedStatus = 0;
                bllPv.AtualizaStatus(modeloPv);

                modeloIpv.PedCod = Convert.ToInt32(txbOdpCodPedido.Text);
                modeloIpv.IpvCod = Convert.ToInt32(txbOdpItemPedido.Text);
                modeloIpv.IpvStatus = 0;
                bllIpv.AtualizaStatus(modeloIpv);

                DataTable tabela = bllitens.Localizar(Convert.ToInt32(txbOdpCod.Text));

                //Estorna a reserva no estoque
                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    modeloEs.EstTm = 2;
                    modeloEs.ProdCod = Convert.ToInt32(tabela.Rows[i]["pro_cod"]);
                    modeloEs.EstSaldoRevservado = Convert.ToDouble(tabela.Rows[i]["iop_qtdplano"]);
                    modeloEs.DepAbrev = tabela.Rows[i]["iop_deposito"].ToString();
                    blles.Reserva(modeloEs);
                }

                //Excluir itens ordem produção
                bllitens.ExcluirItem(Convert.ToInt32(txbOdpCod.Text));

                //Exlcuir ordem produção
                bll.Excluir(Convert.ToInt32(txbOdpCod.Text));

                MessageBox.Show("Exclusão efetuada com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                this.LimpaTela();
                this.alterabotoes(1);
                cx.TerminarTransacao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ordem Produção, Salvar - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cx.CancelarTransacao();
                this.LimpaTela();
                this.alterabotoes(1);
            }
            finally
            {
                cx.Desconectar();
            }
        }

        private void btnApontar_Click(object sender, EventArgs e)
        {
            if (btnApontar.Enabled == true)
            {
                frmApontamentoProducao f = new frmApontamentoProducao();
                int i = Convert.ToInt32(dgvItensOrdemProducao.CurrentCell.RowIndex);

                f.odpCod = Convert.ToInt32(txbOdpCod.Text);
                f.iopCod = Convert.ToInt32(dgvItensOrdemProducao.Rows[i].Cells[0].Value);
                f.proCod = Convert.ToInt32(dgvItensOrdemProducao.Rows[i].Cells[1].Value);
                f.proDep = dgvItensOrdemProducao.Rows[i].Cells[5].Value.ToString();

                f.ShowDialog();
            }

        }

        private void dgvItensOrdemProducao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnApontar_Click(sender, e);
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja finalizar a ordem?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            else
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                cx.Conectar();
                cx.IniciarTransacao();
                try
                {
                    ModeloOrdemProducao modOp = new ModeloOrdemProducao();
                    BLLOrdemProducao bllOp = new BLLOrdemProducao(cx);

                    modOp.OdpCod = Convert.ToInt32(txbOdpCod.Text);
                    modOp.OdpStatus = 4;
                    modOp.OdpDtFinal = DateTime.Now;
                    bllOp.FinalizaOrdem(modOp);

                    ModeloItensOrdemProducao modIop = new ModeloItensOrdemProducao();
                    BLLItensOrdemProducao bllIop = new BLLItensOrdemProducao(cx);

                    for (int i =0;i < dgvItensOrdemProducao.RowCount; i++)
                    {
                        modIop.OdpCod = Convert.ToInt32(txbOdpCod.Text);
                        modIop.Iopcod = Convert.ToInt32(dgvItensOrdemProducao.Rows[i].Cells[0].Value);
                        modIop.IopStatus = 4;
                        bllIop.AtualizaStatus(modIop);
                    }

                    ModeloItensPedidoVenda modIpv = new ModeloItensPedidoVenda();
                    BLLItensPedidoVenda bllIpv = new BLLItensPedidoVenda(cx);

                    modIpv.PedCod = Convert.ToInt32(txbOdpCodPedido.Text);
                    modIpv.IpvCod = Convert.ToInt32(txbOdpItemPedido.Text);
                    DataTable tbl = bllIpv.LocalizarItem(modIpv.PedCod, modIpv.IpvCod);

                    ModeloEstoque modEst = new ModeloEstoque();
                    BLLEstoque bllEst = new BLLEstoque(cx);

                    modEst.ProdCod = Convert.ToInt32(txbOdpProCod.Text);
                    modEst.DepAbrev = tbl.Rows[0]["ipv_dep"].ToString();
                    modEst.EstSaldo = Convert.ToDouble(txbOdpQtde.Text);
                    modEst.VlrEstq = Convert.ToDouble(txbOdpCstOpReal.Text);
                    modEst.EstTm = 1;
                    bllEst.AtualizaEstoque(modEst);

                    cx.TerminarTransacao();
                    MessageBox.Show("Processo concluído com sucesso.", "Finalizar Ordem",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    this.alterabotoes(1);
                    LimpaTela();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ordem Prdoução, Finalizar Ordem - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cx.CancelarTransacao();
                }
                finally
                {
                    cx.Desconectar();
                }
            }
        }
    }
}
