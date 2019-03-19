using MODELO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALFornecedor
    {
        private DALConexao conexao;

        public DALFornecedor(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloFornecedor modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "insert into fornecedor (for_nome,for_cnpj,for_ie,for_rsocial,for_cep,for_endereco,for_endnumero,for_bairro,for_fone,for_cel,for_email,for_cidade,for_estado,for_obs)" +
                                               "values (@nome,@cpfcnpj,@rgie,@rsocial,@cep,@endereco,@endnumero,@bairro,@fone,@cel,@email,@cidade,@estado,@obs); select @@IDENTITY;";

                cmd.Parameters.AddWithValue("@nome", modelo.ForNome);
                cmd.Parameters.AddWithValue("@cpfcnpj", modelo.ForCnpj);
                cmd.Parameters.AddWithValue("@rgie", modelo.ForIe);
                cmd.Parameters.AddWithValue("@rsocial", modelo.ForRzSocial);                
                cmd.Parameters.AddWithValue("@cep", modelo.ForCep);
                cmd.Parameters.AddWithValue("@endereco", modelo.ForEndereco);
                cmd.Parameters.AddWithValue("@endnumero", modelo.ForEndNumero);
                cmd.Parameters.AddWithValue("@bairro", modelo.ForBairro);
                cmd.Parameters.AddWithValue("@fone", modelo.ForFone);
                cmd.Parameters.AddWithValue("@cel", modelo.ForCelular);
                cmd.Parameters.AddWithValue("@email", modelo.ForEmail);
                cmd.Parameters.AddWithValue("@cidade", modelo.ForCidade);
                cmd.Parameters.AddWithValue("@estado", modelo.ForEstado);
                cmd.Parameters.AddWithValue("@obs", modelo.ForObservacao);
                conexao.Conectar();
                modelo.ForCod = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public void Alterar(ModeloFornecedor modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "update fornecedor set for_nome = @nome,for_cnpj = @cnpj, for_ie = @ie,for_rsocial = @rsocial, for_cep = @cep,for_endereco = @endereco," +
                    "for_endnumero = @endnumero,for_bairro = @bairro,for_fone=@fone,for_cel = @cel,for_email = @email,for_cidade = @cidade,for_estado = @estado, for_obs = @obs where for_cod = @codigo";
                cmd.Parameters.AddWithValue("@nome", modelo.ForNome);
                cmd.Parameters.AddWithValue("@cnpj", modelo.ForCnpj);
                cmd.Parameters.AddWithValue("@ie", modelo.ForIe);
                cmd.Parameters.AddWithValue("@rsocial", modelo.ForRzSocial);                
                cmd.Parameters.AddWithValue("@cep", modelo.ForCep);
                cmd.Parameters.AddWithValue("@endereco", modelo.ForEndereco);
                cmd.Parameters.AddWithValue("@endnumero", modelo.ForEndNumero);
                cmd.Parameters.AddWithValue("@bairro", modelo.ForBairro);
                cmd.Parameters.AddWithValue("@fone", modelo.ForFone);
                cmd.Parameters.AddWithValue("@cel", modelo.ForCelular);
                cmd.Parameters.AddWithValue("@email", modelo.ForEmail);
                cmd.Parameters.AddWithValue("@cidade", modelo.ForCidade);
                cmd.Parameters.AddWithValue("@estado", modelo.ForEstado);
                cmd.Parameters.AddWithValue("@obs", modelo.ForObservacao);
                cmd.Parameters.AddWithValue("@codigo", modelo.ForCod);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("DALAlterar Fornecedor" + ex.Message);
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
                cmd.CommandText = "delete from fornecedor where for_cod = @codigo";
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
            SqlDataAdapter da = new SqlDataAdapter("Select * from fornecedor where for_nome like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloFornecedor CarregaModeloFornecedor(int codigo)
        {
            ModeloFornecedor modelo = new ModeloFornecedor();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from fornecedor where for_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ForCod = Convert.ToInt32(registro["for_cod"]);
                modelo.ForNome = Convert.ToString(registro["for_nome"]);
                modelo.ForCnpj = Convert.ToString(registro["for_cnpj"]);
                modelo.ForIe = Convert.ToString(registro["for_ie"]);
                modelo.ForRzSocial = Convert.ToString(registro["for_rsocial"]);
                modelo.ForCep = Convert.ToString(registro["for_cep"]);
                modelo.ForEndereco = Convert.ToString(registro["for_endereco"]);
                modelo.ForEndNumero = Convert.ToString(registro["for_endnumero"]);
                modelo.ForBairro = Convert.ToString(registro["for_bairro"]);
                modelo.ForFone = Convert.ToString(registro["for_fone"]);
                modelo.ForCelular = Convert.ToString(registro["for_cel"]);
                modelo.ForEmail = Convert.ToString(registro["for_email"]);
                modelo.ForCidade = Convert.ToString(registro["for_cidade"]);
                modelo.ForEstado = Convert.ToString(registro["for_estado"]);
                modelo.ForObservacao = Convert.ToString(registro["for_obs"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
