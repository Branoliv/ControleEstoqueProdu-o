using DAL;
using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;


namespace GUI
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            //cpgbLoading.Value = 0;
            //cpgbLoading.Minimum = 0;
            //cpgbLoading.Maximum = 100;

            cpgbLoading.Style = ProgressBarStyle.Marquee;

            lblSplashNomeSis.Text += "CMP";
            lblSplashVersao.Text += " " + Application.ProductVersion;
            backgroundWorkerSplash.RunWorkerAsync();
           // progress();
            

        }

        private void backgroundWorkerSplash_DoWork(object sender, DoWorkEventArgs e)
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
                MessageBox.Show(errosql.Message,"Sql Exception",MessageBoxButtons.OK,MessageBoxIcon.Error);
                frmConfigBancoDados f = new frmConfigBancoDados();
                Application.Exit();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void backgroundWorkerSplash_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            this.Close();
            this.Dispose();
        }

        public void progress()
        {
           

            for (int i = 0; i < 100; i++)
            {
                cpgbLoading.Value = i;
                cpgbLoading.Update();
                if (i < 1)
                {
                   
                }
            }
        }

    }
}
