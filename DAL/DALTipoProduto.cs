using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DALTipoProduto
    {
        private DALConexao conexao;

        public DALTipoProduto(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloTipoProduto modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "insert into tipo_produto (tpp_descricao,tpp_abrev)" +
                    " values (@tpp_descricao,@tpp_abrev); select @@IDENTITY;" ;

                cmd.Parameters.AddWithValue("@tpp_descricao", modelo.TppDescricao);
                cmd.Parameters.AddWithValue("@tpp_abrev", modelo.TppAbrev);

                conexao.Conectar();
                modelo.TppCod = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch(Exception ex)
            {
                throw new Exception("DALTipoProduto, Inserir - " + ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public void Alterar (ModeloTipoProduto modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "update from tipo_produto set tpp_descricao = @tpp_descricao, tpp_abrev = @tpp_abrev " +
                    "where tpp_cod = @tpp_cod";

                cmd.Parameters.AddWithValue("@tpp_descricao", modelo.TppDescricao);
                cmd.Parameters.AddWithValue("@tpp_abrev", modelo.TppAbrev);
                cmd.Parameters.AddWithValue("@tpp_cod", modelo.TppCod);

                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception("DALTipProduto, Alterar - " + ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public DataTable Localizar()
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from tipo_produto",conexao.StringConexao);
                da.Fill(tabela);
                return (tabela);
            }
            catch(Exception ex)
            {
                throw new Exception("DALTipoProduto, Localizar - " + ex.Message);
            }
        }

        public DataTable Localizar(string nome)
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from tipo_produto where tpp_descricao like '%" +
                    nome + "%'", conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch(Exception ex)
            {
                throw new Exception("DALTipoProduto, Localizar - " + ex.Message);
            }
        }

        public void Excluir(int tppCod)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = " delete * from tipo_produto where tpp_cod = @tpp_cod";
                cmd.Parameters.AddWithValue("@tpp_cod", tppCod);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception("DALTipProduto, Excluir - " + ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public ModeloTipoProduto CarregaTipoProduto(int tppCod)
        {
            try
            {
                ModeloTipoProduto modelo = new ModeloTipoProduto();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "select * from tipo_produto where tpp_cod = @tpp_cod";
                cmd.Parameters.AddWithValue("@tpp_cod", tppCod);

                conexao.Conectar();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    modelo.TppCod = Convert.ToInt32(registro["tpp_cod"]);
                    modelo.TppDescricao = registro["tpp_descricao"].ToString();
                    modelo.TppAbrev = registro["tpp_abrev"].ToString();
                }

                return modelo;
            }
            catch(Exception ex)
            {
                throw new Exception("DALTipoProduto, CarregaTipoProduto - " + ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }
    }
}
