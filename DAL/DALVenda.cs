using MODELO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALVenda
    {
        private DALConexao conexao;

        public DALVenda(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloVenda modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "insert into venda (ven_data,ven_nfiscal,ven_total,ven_nparcelas,ven_status,cli_cod,tpa_cod,ven_tpmovimento)" +
                "values (@ven_data,@ven_nfiscal,@ven_total,@ven_nparcelas,@ven_status,@cli_cod,@tpa_cod,@ven_tpmovimento); select @@IDENTITY;";
                
                //valor data 
                cmd.Parameters.AddWithValue("@ven_data", System.Data.SqlDbType.DateTime);
                cmd.Parameters["@ven_data"].Value = modelo.VenData;
                //dados primitivos
                cmd.Parameters.AddWithValue("@ven_nfiscal", modelo.VenNFiscal);
                cmd.Parameters.AddWithValue("@ven_total", modelo.VenTotal);
                cmd.Parameters.AddWithValue("@ven_nparcelas", modelo.VenNParcelas);
                cmd.Parameters.AddWithValue("@ven_status", modelo.Status);
                cmd.Parameters.AddWithValue("@cli_cod", modelo.CliCod);
                cmd.Parameters.AddWithValue("@tpa_cod", modelo.TpaCod);
                cmd.Parameters.AddWithValue("@ven_tpmovimento", modelo.TpMovimento);

                modelo.VenCod = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(ModeloVenda modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "update venda set ven_data = @ven_data,ven_nfiscal = @ven_nfiscal,ven_total = @ven_total,ven_nparcelas = @ven_nparcelas," +
                    "ven_status = @ven_status,cli_cod = @cli_cod,tpa_cod = @tpa_cod, ven_tpmovimento = @ven_tpmovimento where ven_cod = @codigo";

                //valor data 
                cmd.Parameters.AddWithValue("@ven_data", System.Data.SqlDbType.DateTime);
                cmd.Parameters["@ven_data"].Value = modelo.VenData;
                //dados primitivos
                cmd.Parameters.AddWithValue("@ven_nfiscal", modelo.VenNFiscal);
                cmd.Parameters.AddWithValue("@ven_total", modelo.VenTotal);
                cmd.Parameters.AddWithValue("@ven_nparcelas", modelo.VenNParcelas);
                cmd.Parameters.AddWithValue("@ven_status", modelo.Status);
                cmd.Parameters.AddWithValue("@cli_cod", modelo.CliCod);
                cmd.Parameters.AddWithValue("@tpa_cod", modelo.TpaCod);
                cmd.Parameters.AddWithValue("@ven_tpmovimento", modelo.TpMovimento);
                cmd.Parameters.AddWithValue("@codigo", modelo.VenCod);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Excluir(int codigo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "delete from venda where ven_cod = @codigo";
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

        //localizar pelo código do cliente
        public DataTable Localizar(int codigo)
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select c.ven_cod, c.ven_data, c.ven_nfiscal, c.ven_tpmovimento, c.ven_nparcelas, c.cli_cod," +
                    " c.ven_status, f.cli_nome, c.tpa_cod, c.ven_total from venda c inner join cliente f on c.cli_cod = f.cli_cod" +
                    " where c.cli_cod =" + codigo, conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception("DALVenda, Localizar " + ex.Message);
            }
        }

        //localizar geral
        public DataTable Localizar()
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select c.ven_cod, c.ven_data, c.ven_nfiscal, c.ven_tpmovimento, c.ven_nparcelas, c.cli_cod," +
                    " c.ven_status, f.cli_nome, c.tpa_cod, c.ven_total from venda c inner join cliente f on c.cli_cod = f.cli_cod", conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception("DALVenda, Localizar " + ex.Message);
            }
        }

        //localizar por periodo pré definido
        public DataTable Localizar(DateTime dtincial, DateTime dtfinal)
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "Select c.ven_cod, c.ven_data, c.ven_nfiscal, c.ven_tpmovimento, c.ven_nparcelas, c.cli_cod," +
                    " c.ven_status, f.cli_nome, c.tpa_cod, c.ven_total from venda c inner join cliente f on c.cli_cod = f.cli_cod" +
                    " where c.ven_data BETWEEN @dtinicial and @dtfinal";

                cmd.Parameters.Add("@dtinicial", System.Data.SqlDbType.Date);
                cmd.Parameters["@dtinicial"].Value = dtincial;

                cmd.Parameters.Add("@dtfinal", System.Data.SqlDbType.Date);
                cmd.Parameters["@dtfinal"].Value = dtfinal;
                //conexao.Conectar();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabela);
                //conexao.Desconectar();
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception("DALVenda, Localizar " + ex.Message);
            }
        }

        public ModeloVenda CarregaModeloVenda(int codigo)
        {
            try
            {
                ModeloVenda modelo = new ModeloVenda();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "select * from venda where ven_cod = @codigo";
                cmd.Parameters.AddWithValue("@codigo", codigo);
                conexao.Conectar();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();

                    modelo.VenCod = Convert.ToInt32(registro["ven_cod"]);
                    modelo.VenData = Convert.ToDateTime(registro["ven_data"]);
                    modelo.VenNFiscal = Convert.ToInt32(registro["ven_nfiscal"]);
                    modelo.VenTotal = Convert.ToDouble(registro["ven_total"]);
                    modelo.VenNParcelas = Convert.ToInt32(registro["ven_nparcelas"]);
                    modelo.Status = Convert.ToInt32(registro["ven_status"]);
                    modelo.CliCod = Convert.ToInt32(registro["cli_cod"]);
                    modelo.TpaCod = Convert.ToInt32(registro["tpa_cod"]);
                    modelo.TpMovimento = Convert.ToInt32(registro["ven_tpmovimento"]);
                }
                conexao.Desconectar();
                return modelo;
            }
            catch (Exception ex)
            {
                throw new Exception("DALVenda, CarregaModeloVenda " + ex.Message);
            }
        }

        public void Estorno(ModeloVenda modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "update venda set ven_data = @ven_data,ven_nfiscal = @ven_nfiscal,ven_total = @ven_total,ven_nparcelas = @ven_nparcelas," +
                    "ven_status = @ven_status,cli_cod = @cli_cod,tpa_cod = @tpa_cod, ven_tpmovimento = @ven_tpmovimento where ven_cod = @codigo";

                //valor data 
                cmd.Parameters.AddWithValue("@ven_data", System.Data.SqlDbType.DateTime);
                cmd.Parameters["@ven_data"].Value = modelo.VenData;
                //dados primitivos
                cmd.Parameters.AddWithValue("@ven_nfiscal", modelo.VenNFiscal);
                cmd.Parameters.AddWithValue("@ven_total", modelo.VenTotal);
                cmd.Parameters.AddWithValue("@ven_nparcelas", modelo.VenNParcelas);
                cmd.Parameters.AddWithValue("@ven_status", modelo.Status);
                cmd.Parameters.AddWithValue("@for_cod", modelo.CliCod);
                cmd.Parameters.AddWithValue("@tpa_cod", modelo.TpaCod);
                cmd.Parameters.AddWithValue("@codigo", modelo.VenCod);
                cmd.Parameters.AddWithValue("@ven_tpmovimento", modelo.TpMovimento);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("DALVendas - Estorno " + ex.Message);
            }
        }

        public ModeloVenda VerificaNotaFornecedor(int nota, int tm, int codigo)
        {
            try
            {
                ModeloVenda modelo = new ModeloVenda();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "select * from venda where cli_cod = @cli_cod and ven_nfiscal = @ven_nfiscal and ven_tpmovimento = @ven_tpmovimento";
                cmd.Parameters.AddWithValue("@cli_cod", codigo);
                cmd.Parameters.AddWithValue("@ven_nfiscal", nota);
                cmd.Parameters.AddWithValue("@ven_tpmovimento", tm);
                conexao.Conectar();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                                                          
                    modelo.Status = Convert.ToInt32(registro["ven_status"]);
                    modelo.TpMovimento = Convert.ToInt32(registro["ven_tpmovimento"]);
                }
                conexao.Desconectar();
                return modelo;
            }
            catch (Exception ex)
            {
                throw new Exception("DALVenda, VerificaNotaFornecedor. " + ex.Message);
            }
        }
    }
}
