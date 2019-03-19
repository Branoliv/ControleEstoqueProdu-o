using MODELO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALCliente
    {
        private DALConexao conexao;

        public DALCliente(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCliente modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "insert into cliente (cli_nome,cli_cpfcnpj,cli_rgie,cli_rsocial,cli_tipo,cli_cep,cli_endereco,cli_endnumero,cli_bairro,cli_fone,cli_cel,cli_email,cli_cidade,cli_estado,cli_obs)" +
                                               "values (@nome,@cpfcnpj,@rgie,@rsocial,@tipo,@cep,@endereco,@endnumero,@bairro,@fone,@cel,@email,@cidade,@estado,@obs); select @@IDENTITY;";

                cmd.Parameters.AddWithValue("@nome", modelo.CliNome);
                cmd.Parameters.AddWithValue("@cpfcnpj", modelo.CliCpfCnpj);
                cmd.Parameters.AddWithValue("@rgie", modelo.CliRgIe);
                cmd.Parameters.AddWithValue("@rsocial", modelo.CliRzSocial);
                cmd.Parameters.AddWithValue("@tipo", modelo.CliTipo);
                cmd.Parameters.AddWithValue("@cep", modelo.CliCep);
                cmd.Parameters.AddWithValue("@endereco", modelo.CliEndereco);
                cmd.Parameters.AddWithValue("@endnumero", modelo.CliEndNumero);
                cmd.Parameters.AddWithValue("@bairro", modelo.CliBairro);
                cmd.Parameters.AddWithValue("@fone", modelo.CliFone);
                cmd.Parameters.AddWithValue("@cel", modelo.CliCelular);
                cmd.Parameters.AddWithValue("@email", modelo.CliEmail);                
                cmd.Parameters.AddWithValue("@cidade", modelo.CliCidade);
                cmd.Parameters.AddWithValue("@estado", modelo.CliEstado);
                cmd.Parameters.AddWithValue("@obs", modelo.CliObservacao);
                conexao.Conectar();
                modelo.CliCod = Convert.ToInt32(cmd.ExecuteScalar());
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

        public void Alterar(ModeloCliente modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "update cliente set cli_nome = @nome,cli_cpfcnpj = @cpfcnpj, cli_rgie = @rgie,cli_rsocial = @rsocial, cli_tipo = @tipo, cli_cep = @cep,cli_endereco = @endereco,"+
                    "cli_endnumero = @endnumero,cli_bairro = @bairro,cli_fone=@fone,cli_cel = @cel,cli_email = @email,cli_cidade = @cidade,cli_estado = @estado, cli_obs = @obs where cli_cod = @codigo";                    
                cmd.Parameters.AddWithValue("@nome", modelo.CliNome);
                cmd.Parameters.AddWithValue("@cpfcnpj", modelo.CliCpfCnpj);
                cmd.Parameters.AddWithValue("@rgie", modelo.CliRgIe);
                cmd.Parameters.AddWithValue("@rsocial", modelo.CliRzSocial);
                cmd.Parameters.AddWithValue("@tipo", modelo.CliTipo);
                cmd.Parameters.AddWithValue("@cep", modelo.CliCep);
                cmd.Parameters.AddWithValue("@endereco", modelo.CliEndereco);
                cmd.Parameters.AddWithValue("@endnumero", modelo.CliEndNumero);
                cmd.Parameters.AddWithValue("@bairro", modelo.CliBairro);
                cmd.Parameters.AddWithValue("@fone", modelo.CliFone);
                cmd.Parameters.AddWithValue("@cel", modelo.CliCelular);
                cmd.Parameters.AddWithValue("@email", modelo.CliEmail);                
                cmd.Parameters.AddWithValue("@cidade", modelo.CliCidade);
                cmd.Parameters.AddWithValue("@estado", modelo.CliEstado);
                cmd.Parameters.AddWithValue("@obs", modelo.CliObservacao);
                cmd.Parameters.AddWithValue("@codigo", modelo.CliCod);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("DALAlterar Cliente" + ex.Message); 
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
                cmd.CommandText = "delete from cliente where cli_cod = @codigo";
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
            SqlDataAdapter da = new SqlDataAdapter("Select * from cliente where cli_nome like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloCliente CarregaModeloCliente(int codigo)
        {
            ModeloCliente modelo = new ModeloCliente();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from cliente where cli_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CliCod = Convert.ToInt32(registro["cli_cod"]);
                modelo.CliNome = Convert.ToString(registro["cli_nome"]);
                modelo.CliCpfCnpj = Convert.ToString(registro["cli_cpfcnpj"]);
                modelo.CliRgIe = Convert.ToString(registro["cli_rgie"]);
                modelo.CliRzSocial = Convert.ToString(registro["cli_rsocial"]);
                modelo.CliTipo = Convert.ToInt32(registro["cli_tipo"]);
                modelo.CliCep = Convert.ToString(registro["cli_cep"]);
                modelo.CliEndereco = Convert.ToString(registro["cli_endereco"]);
                modelo.CliEndNumero = Convert.ToString(registro["cli_endnumero"]);
                modelo.CliBairro = Convert.ToString(registro["cli_bairro"]);
                modelo.CliFone = Convert.ToString(registro["cli_fone"]);
                modelo.CliCelular = Convert.ToString(registro["cli_cel"]);
                modelo.CliEmail = Convert.ToString(registro["cli_email"]);               
                modelo.CliCidade = Convert.ToString(registro["cli_cidade"]);
                modelo.CliEstado = Convert.ToString(registro["cli_estado"]);
                modelo.CliObservacao = Convert.ToString(registro["cli_obs"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
