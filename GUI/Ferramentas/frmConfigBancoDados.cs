using DAL;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmConfigBancoDados : GUI.frmModeloCadastro
    {
        private frmLoading loading = new frmLoading();
        private delegate void FechaPopUp();
        public frmConfigBancoDados()
        {
            InitializeComponent();
        }

        private void frmConfigBancoDados_Load(object sender, EventArgs e)
        {
            frmPrincipal frt = new frmPrincipal();
            ((frmPrincipal)Application.OpenForms["frmPrincipal"]).LblTituloPrincipal.Text = frt.LblTituloPrincipal.Text + " - " + this.Text;
        }

        public void LimpaTela()
        {
            txbConfBdServidor.Clear();
            txbConfBdBancoDados.Clear();
            txbConfBdUsuario.Clear();
            txbConfBdSenha.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter arquivo = new StreamWriter("ConfiguracaoBanco.txt", false);
                arquivo.WriteLine(txbConfBdServidor.Text);
                arquivo.WriteLine(txbConfBdBancoDados.Text);
                arquivo.WriteLine(txbConfBdUsuario.Text);
                arquivo.WriteLine(txbConfBdSenha.Text);
                arquivo.Close();
                MessageBox.Show("Arquivo salvo com sucesso.");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

            this.LimpaTela();
            this.alterabotoes(1);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            alterabotoes(2);
            this.operacao = "inserir";
            txbConfBdServidor.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaTela();
            this.alterabotoes(1);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alterabotoes(2);            
            txbConfBdServidor.Focus();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {           
            try
            {
                StreamReader arquivo = new StreamReader("ConfiguracaoBanco.txt");
                txbConfBdServidor.Text = arquivo.ReadLine();
                txbConfBdBancoDados.Text = arquivo.ReadLine();
                txbConfBdUsuario.Text = arquivo.ReadLine();
                txbConfBdSenha.Text = arquivo.ReadLine();
                arquivo.Close();                
            }           
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                LimpaTela();
                this.alterabotoes(1);
            }

            alterabotoes(3);
        }

        private void ProcessarInfo()
        {            
            try
            {                
                StreamReader arquivo = new StreamReader("ConfiguracaoBanco.txt");
                DadosDaConexao.servidor = txbConfBdServidor.Text;
                DadosDaConexao.banco = txbConfBdBancoDados.Text;
                DadosDaConexao.usuario = txbConfBdUsuario.Text;
                DadosDaConexao.senha = txbConfBdSenha.Text;
                arquivo.Close();

                //testar conexao
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = DadosDaConexao.StringDeConexao;
                conexao.Open();
                conexao.Close();                                                
                this.Invoke(new FechaPopUp(this.FecharPopUp));               
            }
            catch (SqlException errosql)
            {
                this.Invoke(new FechaPopUp(this.FecharPopUp));
                MessageBox.Show(errosql.Message);
            }            
        }

        private void btnConfBdTesteConexao_Click(object sender, EventArgs e)
        {
            Thread thProcessa = new Thread(new ThreadStart(ProcessarInfo));
            thProcessa.Start();
            loading.ShowDialog();                                   
        } 
        
        private void FecharPopUp()
        {
            loading.Close();
        }       
    }
}
