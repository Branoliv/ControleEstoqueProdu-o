using BLL;
using DAL;
using MODELO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmProduto : GUI.frmModeloCadastro
    {
        public string foto = "";

        public frmProduto()
        {            
            InitializeComponent();
        }

        private void LimpaTela()
        {
            txbProdCodigo.Clear();
            txbProdCodBarras.Clear();
            txbProdNome.Clear();
            txbProdDescricao.Clear();
            txbProdValorPago.Clear();
            txbProdMargem.Clear();
            txbProdValorVenda.Clear();
            txbProdQuantidade.Clear();
            cbxProdUnidMed.SelectedValue = 0;
            cbxProdGrupo.SelectedValue = 0;
            cbxProdSubGrupo.SelectedValue = 0;           
            this.foto = "";
            pcbxProd.Image = null;
            ckbProdInativo.Checked = false;
            txbProdCodTpProduto.Clear();
            txbProdTipoProduto.Clear();

        }

        private void LoadCombox()
        {
            try
            {
                frmPrincipal frt = new frmPrincipal();
                ((frmPrincipal)Application.OpenForms["frmPrincipal"]).LblTituloPrincipal.Text = frt.LblTituloPrincipal.Text + " - " + this.Text;

                //this.alterabotoes(1);
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCategoria bll = new BLLCategoria(cx);
                cbxProdGrupo.DataSource = bll.Localizar("");
                cbxProdGrupo.DisplayMember = "cat_nome";
                cbxProdGrupo.ValueMember = "cat_cod";

                BLLSubCategoria sbll = new BLLSubCategoria(cx);
                cbxProdSubGrupo.DataSource = sbll.LocalizarPorCategoria(Convert.ToInt32(cbxProdGrupo.SelectedValue));
                if (cbxProdSubGrupo.Items.Count == 0)
                {
                    cbxProdSubGrupo.Text = "";
                }
                else
                {
                    cbxProdSubGrupo.DisplayMember = "scat_nome";
                    cbxProdSubGrupo.ValueMember = "scat_cod";
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("frmProduto - Load, cbxProdGrupo_Load - " + erro.Message);
            }

            try
            {
                DALConexao ucx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeDeMedida ubll = new BLLUnidadeDeMedida(ucx);
                cbxProdUnidMed.DataSource = ubll.Localizar("");
                cbxProdUnidMed.DisplayMember = "umed_simbolo";
                cbxProdUnidMed.ValueMember = "umed_cod";
            }
            catch
            {

            }
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            frmPrincipal frt = new frmPrincipal();
            ((frmPrincipal)Application.OpenForms["frmPrincipal"]).LblTituloPrincipal.Text = frt.LblTituloPrincipal.Text + " - " + this.Text;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            LoadCombox();
            alterabotoes(2);
            this.operacao = "inserir";
            txbProdCodBarras.Focus();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultaProduto f = new frmConsultaProduto();
                f.ShowDialog();
                if (f.codigo != 0)
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLProduto bll = new BLLProduto(cx);
                    ModeloProduto modelo = bll.CarregaModeloProduto(f.codigo);

                    txbProdCodBarras.Text = modelo.ProdCodBarra.ToString();
                    txbProdCodigo.Text = modelo.ProdCodigo.ToString("D6");
                    txbProdNome.Text = modelo.ProdNome;
                    txbProdNome.Text = modelo.ProdNome;
                    txbProdDescricao.Text = modelo.ProdDescricao;
                    txbProdValorPago.Text = modelo.ProdValorpago.ToString();
                    txbProdValorVenda.Text = modelo.ProdValorvenda.ToString();
                    txbProdQuantidade.Text = modelo.ProdQtde.ToString("N3");
                    LoadCombox();
                    cbxProdUnidMed.SelectedValue = modelo.UmedCodigo;
                    cbxProdGrupo.SelectedValue = modelo.CatCodigo;
                    cbxProdSubGrupo.SelectedValue = modelo.ScatCodigo;
                    txbProdMargem.Text = modelo.ProdMargem.ToString();
                    txbProdCodTpProduto.Text = modelo.TppCodigo.ToString();
                    LocalizarTipoProduto(Convert.ToInt32(txbProdCodTpProduto.Text));


                    if (modelo.ProdAtivo == "N")
                    {
                        ckbProdInativo.Checked = true;
                    }
                    else
                    {
                        ckbProdInativo.Checked = false;
                    }

                    try
                    {
                        MemoryStream ms = new MemoryStream(modelo.ProdFoto);
                        pcbxProd.Image = Image.FromStream(ms);
                        this.foto = "Foto Original";
                        pcbxProd.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch { }

                    txbProdValorPago_Leave(sender, e);
                    txbProdValorVenda_Leave(sender, e);
                    txbProdQuantidade_Leave(sender, e);

                    alterabotoes(3);
                }
                else
                {
                    this.LimpaTela();
                    this.alterabotoes(1);
                }

                f.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show("frmProduto, btnLocalizar - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alterabotoes(2);
            txbProdCodBarras.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitrua dos dados
                ModeloProduto modelo = new ModeloProduto();
                modelo.ProdCodBarra = Convert.ToString(txbProdCodBarras.Text);
                modelo.ProdNome = txbProdNome.Text;
                modelo.ProdDescricao = txbProdDescricao.Text;
                modelo.ProdValorpago = Convert.ToDouble(txbProdValorPago.Text);
                modelo.ProdValorvenda = Convert.ToDouble (txbProdValorVenda.Text);
                modelo.ProdQtde = Convert.ToDouble(txbProdQuantidade.Text);
                modelo.UmedCodigo = Convert.ToInt32(cbxProdUnidMed.SelectedValue);
                modelo.CatCodigo = Convert.ToInt32(cbxProdGrupo.SelectedValue);
                modelo.ScatCodigo = Convert.ToInt32(cbxProdSubGrupo.SelectedValue);
                modelo.ProdMargem = Convert.ToDouble(txbProdMargem.Text);
                modelo.TppCodigo = Convert.ToInt32(txbProdCodTpProduto.Text);

                if(ckbProdInativo.Checked == true)
                {
                    modelo.ProdAtivo = Convert.ToString("N");
                }
                else
                {
                    modelo.ProdAtivo = Convert.ToString("S");
                }
                                           
                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar um produto
                    modelo.CarregaIagem(this.foto);
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuadio: Código " + modelo.ProdCodigo.ToString());
                }
                else
                {
                    //alterar um prduto
                    modelo.ProdCodigo = Convert.ToInt32(txbProdCodigo.Text);
                    
                    if(this.foto == "Foto Original")
                    {
                        ModeloProduto mt = bll.CarregaModeloProduto(modelo.ProdCodigo);
                        modelo.ProdFoto = mt.ProdFoto;
                    }
                    else
                    {
                        modelo.CarregaIagem(this.foto);
                    }

                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado com sucesso.");
                }

                this.LimpaTela();
                this.alterabotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show("frmProduto, btnSalvar - " + erro.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaTela();
            this.alterabotoes(1);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLProduto bll = new BLLProduto(cx);
                    bll.Excluir(Convert.ToInt32(txbProdCodigo.Text));
                    this.LimpaTela();
                    this.alterabotoes(1);
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro esta sendo utilizado em outro local.");
                this.alterabotoes(3);
            }        
        }
      
        private void txbProdValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txbProdValorPago.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }           
        }

        private void txbProdValorVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if(e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txbProdValorVenda.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }        
       
        private void txbProdQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txbProdQuantidade.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }       

        private void cbxProdGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            try
            {
                BLLSubCategoria sbll = new BLLSubCategoria(cx);
                cbxProdSubGrupo.DataSource = sbll.LocalizarPorCategoria(Convert.ToInt32(cbxProdGrupo.SelectedValue));
                if(cbxProdSubGrupo.Items.Count == 0)
                {
                    cbxProdSubGrupo.Text = "";
                }
                else
                {
                    cbxProdSubGrupo.DisplayMember = "scat_nome";
                    cbxProdSubGrupo.ValueMember = "scat_cod";
                }               
            }
            catch 
            {
                cbxProdSubGrupo.Text = "";                
            }
        }
        
        private void btnpcbxProdCarrega_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.ShowDialog();
            if (!string.IsNullOrEmpty(od.FileName))
            {
                this.foto = od.FileName;
                pcbxProd.Load(this.foto);
                pcbxProd.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnpcbxProdRemover_Click(object sender, EventArgs e)
        {
            this.foto = "";
            pcbxProd.Image = null;
        }

        private void txbProdCodigo_Enter(object sender, EventArgs e)
        {
            txbProdCodigo.BackColor = Color.LemonChiffon;
        }

        private void txbProdCodigo_Leave(object sende, EventArgs e)
        {
            txbProdCodigo.BackColor = Color.WhiteSmoke;
        }

        private void txbProdNome_Enter(object sender, EventArgs e)
        {
            txbProdNome.BackColor = Color.LemonChiffon;
        }

        private void txbProdNome_Leave(object sender, EventArgs e)
        {
            txbProdNome.BackColor = Color.WhiteSmoke;
        }

        private void txbProdDescricao_Enter(object sender, EventArgs e)
        {
            txbProdDescricao.BackColor = Color.LemonChiffon;
        }

        private void txbProdDescricao_Leave(object sender, EventArgs e)
        {
            txbProdDescricao.BackColor = Color.WhiteSmoke;
        }

        private void txbProdValorPago_Enter(object sender, EventArgs e)
        {
            txbProdValorPago.BackColor = Color.LemonChiffon;
        }

        private void txbProdValorPago_Leave(object sender, EventArgs e)
        {
            txbProdValorPago.BackColor = Color.WhiteSmoke;
            txbProdMargem_Leave(sender, e);

            int vg = txbProdValorPago.Text.Split(',').Length - 1;
            if (vg >= 2)
            {
                MessageBox.Show("Não é permitido mais de uma virgula.");
            }

            if (txbProdValorPago.Text.IndexOf(",") == txbProdValorPago.Text.Length - 1)
            {
                txbProdValorPago.Text += "00";
            }

            if (txbProdValorPago.Text.Contains(",") == false)
            {
                txbProdValorPago.Text += ",00";
            }

            try
            {
                Double d = Convert.ToDouble(txbProdValorPago.Text);
            }
            catch
            {
                txbProdValorPago.Text = "0,00";
            }

            txbProdValorPago.Text = Double.Parse(txbProdValorPago.Text).ToString("N2");
        }

        private void txbProdValorVenda_Enter(object sender, EventArgs e)
        {
            txbProdValorVenda.BackColor = Color.LemonChiffon;
        }

        private void txbProdValorVenda_Leave(object sender, EventArgs e)
        {
            txbProdValorVenda.BackColor = Color.WhiteSmoke;

            int vg = txbProdValorVenda.Text.Split(',').Length - 1;
            if (vg >= 2)
            {
                MessageBox.Show("Não é permitido mais de uma virgula.");
            }

            if (txbProdValorVenda.Text.IndexOf(",") == txbProdValorVenda.Text.Length - 1)
            {
                txbProdValorVenda.Text += "00";
            }

            if (txbProdValorVenda.Text.Contains(",") == false)
            {
                txbProdValorVenda.Text += ",00";
            }

            try
            {
                Double d = Convert.ToDouble(txbProdValorVenda.Text);
            }
            catch
            {
                txbProdValorVenda.Text = "0,00";
            }

            txbProdValorVenda.Text = Double.Parse(txbProdValorVenda.Text).ToString("N2");
        }

        private void txbProdQuantidade_Enter(object sender, EventArgs e)
        {
            txbProdQuantidade.BackColor = Color.LemonChiffon;
        }

        private void txbProdQuantidade_Leave(object sender, EventArgs e)
        {
            txbProdQuantidade.BackColor = Color.WhiteSmoke;

            int vg = txbProdQuantidade.Text.Split(',').Length - 1;
            if (vg >= 2)
            {
                MessageBox.Show("Não é permitido mais de uma virgula.");
            }

            if (txbProdQuantidade.Text.IndexOf(",") == txbProdQuantidade.Text.Length - 1)
            {
                txbProdQuantidade.Text += "00";
            }

            if (txbProdQuantidade.Text.Contains(",") == false)
            {
                txbProdQuantidade.Text += ",00";
            }


            try
            {
                Double d = Convert.ToDouble(txbProdQuantidade.Text);
            }
            catch
            {
                txbProdQuantidade.Text = "0,00";
            }

            txbProdQuantidade.Text = Double.Parse(txbProdQuantidade.Text).ToString("N3");
        }
       
        private void cbxProdGrupo_Enter(object sender, EventArgs e)
        {
            cbxProdGrupo.BackColor = Color.LemonChiffon;
        }

        private void cbxProdGrupo_Leave(object sender, EventArgs e)
        {
            cbxProdGrupo.BackColor = Color.WhiteSmoke;
        }

        private void cbxProdSubGrupo_Enter(object sender, EventArgs e)
        {
            cbxProdSubGrupo.BackColor = Color.LemonChiffon;
        }

        private void cbxProdSubGrupo_Leave(object sender, EventArgs e)
        {
            cbxProdSubGrupo.BackColor = Color.WhiteSmoke;
        }

        private void cbxProdUnidMed_Enter(object sender, EventArgs e)
        {
            cbxProdUnidMed.BackColor = Color.LemonChiffon;
        }

        private void cbxProdUnidMed_Leave(object sender, EventArgs e)
        {
            cbxProdUnidMed.BackColor = Color.WhiteSmoke;
        }

        private void txbProdCodBarras_Enter(object sender, EventArgs e)
        {
            txbProdCodBarras.BackColor = Color.LemonChiffon;
        }

        private void txbProdCodBarras_Leave(object sender, EventArgs e)
        {
            txbProdCodBarras.BackColor = Color.WhiteSmoke;
            LocalizaCodBarras();
            txbProdValorPago_Leave(sender, e);
            txbProdValorVenda_Leave(sender, e);
            txbProdQuantidade_Leave(sender, e);
        }

        private void txbProdMargem_Enter(object sender, EventArgs e)
        {
            txbProdMargem.BackColor = Color.LemonChiffon;
        }

        private void txbProdMargem_Leave(object sender, EventArgs e)
        {
            txbProdMargem.BackColor = Color.WhiteSmoke;

            if (txbProdMargem.Text != "")
            {
                Double a = Convert.ToDouble(txbProdValorPago.Text);
                Double b = (Convert.ToDouble(txbProdMargem.Text) / 100);
                Double Vd = a + (a * b);
                txbProdValorVenda.Text = Convert.ToString(Vd);
            }
        }
      
        private void txbProdValorVenda_TextChanged(object sender, EventArgs e)
        {
            txbProdValorVenda_Leave(sender, e);
        }

        private void txbProdCodBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txbProdCodBarras.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void LocalizaCodBarras()
        {
            if (txbProdCodBarras.Text != "" && this.operacao == "inserir")
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProdutoCodBarras(txbProdCodBarras.Text);

                if (modelo.ProdCodigo > 0)
                {
                    // txbProdCodBarras.Text = modelo.ProdCodBarra.ToString();
                    txbProdCodigo.Text = modelo.ProdCodigo.ToString("D6");
                    txbProdNome.Text = modelo.ProdNome;
                    txbProdNome.Text = modelo.ProdNome;
                    txbProdDescricao.Text = modelo.ProdDescricao;
                    txbProdValorPago.Text = modelo.ProdValorpago.ToString();
                    txbProdValorVenda.Text = modelo.ProdValorvenda.ToString();
                    txbProdQuantidade.Text = modelo.ProdQtde.ToString("N3");
                    cbxProdUnidMed.SelectedValue = modelo.UmedCodigo;
                    cbxProdGrupo.SelectedValue = modelo.CatCodigo;
                    cbxProdSubGrupo.SelectedValue = modelo.ScatCodigo;
                    txbProdMargem.Text = modelo.ProdMargem.ToString();

                    if (modelo.ProdAtivo == "N")
                    {
                        ckbProdInativo.Checked = true;
                    }
                    else
                    {
                        ckbProdInativo.Checked = false;
                    }

                    try
                    {
                        MemoryStream ms = new MemoryStream(modelo.ProdFoto);
                        pcbxProd.Image = Image.FromStream(ms);
                        this.foto = "Foto Original";
                        pcbxProd.SizeMode = PictureBoxSizeMode.StretchImage;
                        //LoadCombox();
                    }
                    catch { }

                    alterabotoes(3);
                }
                          
            }            
        }

        private void txbProdCodTpProduto_Enter(object sender, EventArgs e)
        {
            txbProdCodTpProduto.BackColor = Color.LemonChiffon;
        }

        private void txbProdCodTpProduto_Leave(object sender, EventArgs e)
        {
            txbProdCodTpProduto.BackColor = Color.WhiteSmoke;

            if (!txbProdCodTpProduto.Text.Equals(""))
            {
                LocalizarTipoProduto(Convert.ToInt32(txbProdCodTpProduto.Text));
            }
        }

        public void LocalizarTipoProduto(int Tpp_cod)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLTipoProduto bllTp = new BLLTipoProduto(cx);
                ModeloTipoProduto modTp = bllTp.CarregaTipoProduto(Tpp_cod);

                txbProdTipoProduto.Text = modTp.TppDescricao;
            }
            catch(Exception ex)
            {
                MessageBox.Show("LocalizarTipoProduto - " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProdTpProduto_Click(object sender, EventArgs e)
        {
            frmConsultaSpTipoProduto f = new frmConsultaSpTipoProduto();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txbProdCodTpProduto.Text = Convert.ToString(f.codigo);
                LocalizarTipoProduto(f.codigo);
            }
        }
    }
}
