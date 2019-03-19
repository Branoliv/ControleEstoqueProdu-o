using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace GUI
{
    public partial class frmPrincipal : Form
    {
        Form f;
        
        public frmPrincipal()
        {
            InitializeComponent();
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

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader arquivo = new StreamReader("ConfiguracaoBanco.txt");
                DadosDaConexao.servidor = arquivo.ReadLine();
                DadosDaConexao.banco = arquivo.ReadLine();
                DadosDaConexao.usuario = arquivo.ReadLine();
                DadosDaConexao.senha = arquivo.ReadLine();
                arquivo.Close();

                //testar conexao
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = DadosDaConexao.StringDeConexao;
                conexao.Open();
                conexao.Close();
                
            }
            catch (SqlException errosql)
            {
                MessageBox.Show(errosql.Message);
                frmConfigBancoDados f = new frmConfigBancoDados();
               
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                
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
    }    
}

