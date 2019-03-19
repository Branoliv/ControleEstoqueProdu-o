using MODELO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALDeposito
    {
        private DALConexao conexao;

        public DALDeposito(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloDeposito modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "insert into deposito (dep_abreviacao, dep_nome) values (@dep_abreviacao, @dep_nome); select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@dep_abreviacao", modelo.DepAbrev);
                cmd.Parameters.AddWithValue("@dep_nome", modelo.DepNome);
                conexao.Conectar();
                modelo.DepCod = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch
            {
                //throw erro
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public void Alterar(ModeloDeposito modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "update deposito set dep_abreviacao = @dep_abreviacao, dep_nome = @dep_nome where dep_cod = @codigo";
                cmd.Parameters.AddWithValue("@dep_abreviacao", modelo.DepAbrev);
                cmd.Parameters.AddWithValue("@dep_nome", modelo.DepNome);
                cmd.Parameters.AddWithValue("@codigo", modelo.DepCod);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                //throw 
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public void Excluir(int codigo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "delete from deposito where dep_cod = @codigo";
                cmd.Parameters.AddWithValue("@codigo", codigo);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                //throw 
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from deposito where dep_nome like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarAbreviacao(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from deposito where dep_abreviacao like '" +
                valor + "'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloDeposito CarregaModeloDeposito(int codigo)
        {
            ModeloDeposito modelo = new ModeloDeposito();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from deposito where dep_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.DepCod = Convert.ToInt32(registro["dep_cod"]);
                modelo.DepAbrev = Convert.ToString(registro["dep_abreviacao"]);
                modelo.DepNome = Convert.ToString(registro["dep_nome"]);
            }
            conexao.Desconectar();
            return modelo;
        }

        public ModeloDeposito CarregaModeloDepositoAbr(string abreviacao)
        {
            ModeloDeposito modelo = new ModeloDeposito();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from deposito where dep_abreviacao = @dep_abreviacao";
            cmd.Parameters.AddWithValue("@dep_abreviacao", abreviacao);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.DepCod = Convert.ToInt32(registro["dep_cod"]);
                modelo.DepAbrev = Convert.ToString(registro["dep_abreviacao"]);
                modelo.DepNome = Convert.ToString(registro["dep_nome"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
