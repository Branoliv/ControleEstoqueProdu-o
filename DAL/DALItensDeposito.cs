using MODELO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALItensDeposito
    {
        private DALConexao conexao;

        public DALItensDeposito(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloItensDeposito modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "insert into itensdeposito (dep_codprod,dep_abreviacao) values (@dep_codprod,@dep_abreviacao);";
                cmd.Parameters.AddWithValue("@dep_codprod", Convert.ToInt32(modelo.DepCodProd));
                cmd.Parameters.AddWithValue("@dep_abreviacao", modelo.DepProdAbrev);                
                conexao.Conectar();
                cmd.ExecuteScalar();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public void Alterar(ModeloItensDeposito modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "update itensdeposito set dep_abreviacao = @dep_abreviacao where dep_codprod = @codigo";
                cmd.Parameters.AddWithValue("@dep_abreviacao", modelo.DepProdAbrev);                
                cmd.Parameters.AddWithValue("@codigo", modelo.DepCodProd);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
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
                cmd.CommandText = "delete from itensdeposito where dep_codprod = @codigo";
                cmd.Parameters.AddWithValue("@codigo", codigo);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public DataTable Localizar(int codigo)
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select d.dep_codprod, p.pro_nome, d.dep_abreviacao from itensdeposito d inner join produto p on d.dep_codprod = p.pro_cod where dep_codprod =" +
                    codigo, conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ModeloItensDeposito CarregaModeloItensDeposito(int codigo)
        {
            try
            {
                ModeloItensDeposito modelo = new ModeloItensDeposito();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "select * from itensdeposito where dep_codprod = @codigo";
                cmd.Parameters.AddWithValue("@codigo", codigo);
                conexao.Conectar();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    modelo.DepCodProd = Convert.ToInt32(registro["dep_codprod"]);
                    modelo.DepProdAbrev = Convert.ToString(registro["dep_abreviacao"]);
                }
                
                return modelo;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }
    }
}
