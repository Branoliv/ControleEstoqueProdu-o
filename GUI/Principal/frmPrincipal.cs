using System;
using System.Windows.Forms;


namespace GUI
{
    public partial class frmPrincipal : Form
    {
        Form f;
        
        public frmPrincipal()
        {
            InitializeComponent();

            frmSplash f = new frmSplash();
            f.ShowDialog();
            //f.Dispose();
        }
        
        private void FecharFormulariosFilhos()
        {
            // percorre todos os formulários abertos
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                // se o formulário for filho
                if (Application.OpenForms[i].IsMdiChild)
                {
                    // fecha o formulário
                    Application.OpenForms[i].Close();
                }
            }
        }

        void f_FormClosed(object sender, EventArgs e)
        {
            f = null;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();

            if (f == null)
            {
                f = new frmCliente();
                f.MdiParent = this;
                f.FormClosed += new FormClosedEventHandler(f_FormClosed);
                f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                f.Show();
            }
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();

            if (f == null)
            {
                f = new frmFornecedor();
                f.MdiParent = this;
                f.FormClosed += new FormClosedEventHandler(f_FormClosed);
                f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                f.Show();
            }
        }

        private void grupoMaterailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();

            if (f == null)
            {
                f = new frmGrupoMaterial();
                f.MdiParent = this;
                f.FormClosed += new FormClosedEventHandler(f_FormClosed);
                f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                f.Show();         
            }
        }

        private void subCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();

            if (f == null)
            {
                f = new frmSubGrupoMaterial();
                f.MdiParent = this;
                f.FormClosed += new FormClosedEventHandler(f_FormClosed);
                f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                f.Show();
            }            
        }

        private void unidMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();

            if (f == null)
            {
                f = new frmUnidadeDeMedida();
                f.MdiParent = this;
                f.FormClosed += new FormClosedEventHandler(f_FormClosed);
                f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                f.Show();
            }

        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();

            if (f == null)
            {
                f = new frmProduto();
                f.MdiParent = this;
                f.FormClosed += new FormClosedEventHandler(f_FormClosed);
                f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                f.Show();
            }

        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();

            if (f == null)
            {
                f = new frmConfigBancoDados();
                f.MdiParent = this;
                f.FormClosed += new FormClosedEventHandler(f_FormClosed);
                f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                f.Show();
            }
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBackupBandoDados f = new frmBackupBandoDados();
            f.ShowDialog();
            f.Dispose();
        }

        private void tipoPagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();

            if (f == null)
            {
                f = new frmTipoPagamento();
                f.MdiParent = this;
                f.FormClosed += new FormClosedEventHandler(f_FormClosed);
                f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                f.Show();
            }
        }

        private void LblTituloPrincipal_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();

            if (f == null)
            {
                f = new frmMenu();
                f.MdiParent = this;
                f.FormClosed += new FormClosedEventHandler(f_FormClosed);
                f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                f.Show();
            }
        }
       
        private void cadastroDepósitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();

            if (f == null)
            {
                f = new frmDeposito();
                f.MdiParent = this;
                f.FormClosed += new FormClosedEventHandler(f_FormClosed);
                f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                f.Show();
            }
        }

        private void depósitoPorProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();

            if (f == null)
            {
                f = new frmItensDeposito();
                f.MdiParent = this;
                f.FormClosed += new FormClosedEventHandler(f_FormClosed);
                f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                f.Show();
            }
        }

        private void estoquePorMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();

            if (f == null)
            {
                f = new frmConsultaEstoque();
                f.MdiParent = this;
                f.FormClosed += new FormClosedEventHandler(f_FormClosed);
                f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                f.Show();
            }
        }

        private void pagamentoComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();

            if (f == null)
            {
                f = new frmPagamentoCompra();
                f.MdiParent = this;
                f.FormClosed += new FormClosedEventHandler(f_FormClosed);
                f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                f.Show();
            }
        }

        private void planoDeProduçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();

            if (f == null)
            {
                f = new frmPlanoDeProducao();
                f.MdiParent = this;
                f.FormClosed += new FormClosedEventHandler(f_FormClosed);
                f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                f.Show();
            }
        }

        private void ordemProduçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();

            if (f == null)
            {
                f = new frmOrdemProducao();
                f.MdiParent = this;
                f.FormClosed += new FormClosedEventHandler(f_FormClosed);
                f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                f.Show();
            }
        }

        private void entradaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();

            if (f == null)
            {
                f = new frmMovimentacaoCompra();
                f.MdiParent = this;
                f.FormClosed += new FormClosedEventHandler(f_FormClosed);
                f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                f.Show();
            }
        }

        private void pedidoVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();

            if (f == null)
            {
                f = new frmPedidoVenda();
                f.MdiParent = this;
                f.FormClosed += new FormClosedEventHandler(f_FormClosed);
                f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                f.Show();
            }
        }

        private void tipoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();

            if(f == null)
            {
                f = new frmTipoProduto();
                f.MdiParent = this;
                f.FormClosed += new FormClosedEventHandler(f_FormClosed);
                f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                f.Show();
            }
        }
    }    
}

