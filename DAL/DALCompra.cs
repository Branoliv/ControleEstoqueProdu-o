using MODELO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALCompra
    {
        private DALConexao conexao;

        public DALCompra(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCompra modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "insert into compra (com_data,com_nfiscal,com_total,com_nparcelas,com_status,for_cod,tpa_cod,com_tpmovimento)" +
                "values (@com_data,@com_nfiscal,@com_total,@com_nparcelas,@com_status,@for_cod,@tpa_cod,@com_tpmovimento); select @@IDENTITY;";
                //valor data 
                cmd.Parameters.AddWithValue("@com_data", System.Data.SqlDbType.DateTime);
                cmd.Parameters["@com_data"].Value = modelo.ComData;
                //dados primitivos
                cmd.Parameters.AddWithValue("@com_nfiscal", modelo.ComNFiscal);
                cmd.Parameters.AddWithValue("@com_total", modelo.ComTotal);
                cmd.Parameters.AddWithValue("@com_nparcelas", modelo.ComNParcelas);
                cmd.Parameters.AddWithValue("@com_status", modelo.ComStatus);
                cmd.Parameters.AddWithValue("@for_cod", modelo.ForCod);
                cmd.Parameters.AddWithValue("@tpa_cod", modelo.TpaCod);
                cmd.Parameters.AddWithValue("@com_tpmovimento", modelo.TpMovimento);
              
                modelo.ComCod = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }            
        }

        public void Alterar(ModeloCompra modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "update compra set com_data = @com_data,com_nfiscal = @com_nfiscal,com_total = @com_total,com_nparcelas = @com_nparcelas,"+
                    "com_status = @com_status,for_cod = @for_cod,tpa_cod = @tpa_cod, com_tpmovimento = @com_tpmovimento where com_cod = @codigo";

                //valor data 
                cmd.Parameters.AddWithValue("@com_data", System.Data.SqlDbType.DateTime);
                cmd.Parameters["@com_data"].Value = modelo.ComData;
                //dados primitivos
                cmd.Parameters.AddWithValue("@com_nfiscal", modelo.ComNFiscal);
                cmd.Parameters.AddWithValue("@com_total", modelo.ComTotal);
                cmd.Parameters.AddWithValue("@com_nparcelas", modelo.ComNParcelas);
                cmd.Parameters.AddWithValue("@com_status", modelo.ComStatus);
                cmd.Parameters.AddWithValue("@for_cod", modelo.ForCod);
                cmd.Parameters.AddWithValue("@tpa_cod", modelo.TpaCod);
                cmd.Parameters.AddWithValue("@codigo", modelo.ComCod);
                cmd.Parameters.AddWithValue("@com_tpmovimento", modelo.TpMovimento);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
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
                cmd.CommandText = "delete from compra where com_cod = @codigo";
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

        //localizar pelo código do fornecedor
        public DataTable Localizar(int codigo)
        {
            try { 
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select c.com_cod, c.com_data, c.com_nfiscal, c.com_tpmovimento, c.com_nparcelas, c.for_cod," +
                " c.com_status, f.for_nome, c.tpa_cod, c.com_total from compra c inner join fornecedor f on c.for_cod = f.for_cod" +
                " where c.for_cod =" + codigo, conexao.StringConexao);            
            da.Fill(tabela);
            return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception("DALCompra, Localizar " + ex.Message);
            }
        }

        //localizar pelo nome do fornecedor
        public DataTable Localizar()
        {
            try { 
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select c.com_cod, c.com_data, c.com_nfiscal, c.com_tpmovimento, c.com_nparcelas, c.for_cod," +
                " c.com_status, f.for_nome, c.tpa_cod, c.com_total from compra c inner join fornecedor f on c.for_cod = f.for_cod", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception("DALCompra, Localizar " + ex.Message);
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
                cmd.CommandText = "Select c.com_cod, c.com_data, c.com_nfiscal, c.com_tpmovimento, c.com_nparcelas, c.for_cod," +
                    " c.com_status, f.for_nome, c.tpa_cod, c.com_total from compra c inner join fornecedor f on c.for_cod = f.for_cod" +
                    " where c.com_data BETWEEN @dtinicial and @dtfinal";

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
                throw new Exception("DALCompra, Localizar " + ex.Message);
            }
        }

        public ModeloCompra CarregaModeloCompra(int codigo)
        {
            try
            {
                ModeloCompra modelo = new ModeloCompra();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "select * from compra where com_cod = @codigo";
                cmd.Parameters.AddWithValue("@codigo", codigo);
                conexao.Conectar();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();

                    modelo.ComCod = Convert.ToInt32(registro["com_cod"]);
                    modelo.ComData = Convert.ToDateTime(registro["com_data"]);
                    modelo.ComNFiscal = Convert.ToInt32(registro["com_nfiscal"]);
                    modelo.ComTotal = Convert.ToDouble(registro["com_total"]);
                    modelo.ComNParcelas = Convert.ToInt32(registro["com_nparcelas"]);
                    modelo.ComStatus = Convert.ToInt32(registro["com_status"]);
                    modelo.ForCod = Convert.ToInt32(registro["for_cod"]);
                    modelo.TpaCod = Convert.ToInt32(registro["tpa_cod"]);
                    modelo.TpMovimento = Convert.ToInt32(registro["com_tpmovimento"]);
                }
                conexao.Desconectar();
                return modelo;
            }
            catch (Exception ex)
            {
                throw new Exception("DALCompra, CarregaModeloCompra " + ex.Message);
            }
        }

        public void Estorno(ModeloCompra modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "update compra set com_data = @com_data,com_nfiscal = @com_nfiscal,com_total = @com_total,com_nparcelas = @com_nparcelas," +
                    "com_status = @com_status,for_cod = @for_cod,tpa_cod = @tpa_cod, com_tpmovimento = @com_tpmovimento where com_cod = @codigo";

                //valor data 
                cmd.Parameters.AddWithValue("@com_data", System.Data.SqlDbType.DateTime);
                cmd.Parameters["@com_data"].Value = modelo.ComData;
                //dados primitivos
                cmd.Parameters.AddWithValue("@com_nfiscal", modelo.ComNFiscal);
                cmd.Parameters.AddWithValue("@com_total", modelo.ComTotal);
                cmd.Parameters.AddWithValue("@com_nparcelas", modelo.ComNParcelas);
                cmd.Parameters.AddWithValue("@com_status", modelo.ComStatus);
                cmd.Parameters.AddWithValue("@for_cod", modelo.ForCod);
                cmd.Parameters.AddWithValue("@tpa_cod", modelo.TpaCod);
                cmd.Parameters.AddWithValue("@codigo", modelo.ComCod);
                cmd.Parameters.AddWithValue("@com_tpmovimento", modelo.TpMovimento);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("DALCompras - Estorno " + ex.Message);
            }
        }

        public ModeloCompra VerificaNotaFornecedor(int nota, int tm, int codigo)
        {
            try
            {
                ModeloCompra modelo = new ModeloCompra();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "select * from compra where for_cod = @for_cod and com_nfiscal = @com_nfiscal and com_tpmovimento = @com_tpmovimento";
                cmd.Parameters.AddWithValue("@for_cod", codigo);
                cmd.Parameters.AddWithValue("@com_nfiscal", nota);
                cmd.Parameters.AddWithValue("@com_tpmovimento", tm);
                conexao.Conectar();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();

                    //modelo.ComCod = Convert.ToInt32(registro["com_cod"]);                   
                    //modelo.ComNFiscal = Convert.ToInt32(registro["com_nfiscal"]);                                        
                    modelo.ComStatus = Convert.ToInt32(registro["com_status"]);                    
                    modelo.TpMovimento = Convert.ToInt32(registro["com_tpmovimento"]);
                }
                conexao.Desconectar();
                return modelo;
            }
            catch (Exception ex)
            {
                throw new Exception("DALCompra, VerificaNotaFornecedor. " + ex.Message);
            }
        }
    }
}
