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
    public class DALPedidoVenda
    {

        private DALConexao conexao;

        public DALPedidoVenda(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloPedidoVenda modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "insert into pedidovenda (cli_cod,ped_data,ped_total,ped_status,ped_dataentrega)" +
                "values (@cli_cod,@ped_data,@ped_total,@ped_status,@ped_dataentrega); select @@IDENTITY;";
                //data pedido 
                cmd.Parameters.AddWithValue("@ped_data", System.Data.SqlDbType.DateTime);
                cmd.Parameters["@ped_data"].Value = modelo.PedData;
                //dados primitivos
                cmd.Parameters.AddWithValue("@cli_cod", modelo.CliCod);
                cmd.Parameters.AddWithValue("@ped_total", modelo.PedTotal);
                cmd.Parameters.AddWithValue("@ped_status", modelo.PedStatus);
                //data entrega
                cmd.Parameters.AddWithValue("@ped_dataentrega", System.Data.SqlDbType.DateTime);
                cmd.Parameters["@ped_dataentrega"].Value = modelo.PedDtEntrega;

                modelo.PedCod = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception("DALPedidoVenda, Incluir - " + ex.Message);
            }
        }

        public void Alterar(ModeloPedidoVenda modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "update pedidovenda set cli_cod = @cli_cod,ped_data = @ped_data,ped_total = @ped_total,ped_status = @ped_status,ped_dataentrega = @ped_dataentrega" +
                    " where ped_cod = @codigo";
                cmd.Parameters.AddWithValue("@codigo", modelo.PedCod);
                //valor data 
                cmd.Parameters.AddWithValue("@ped_data", System.Data.SqlDbType.DateTime);
                cmd.Parameters["@ped_data"].Value = modelo.PedData;
                //dados primitivos
                cmd.Parameters.AddWithValue("@cli_cod", modelo.CliCod);
                cmd.Parameters.AddWithValue("@ped_total", modelo.PedTotal);
                cmd.Parameters.AddWithValue("@ped_status", modelo.PedStatus);
                cmd.Parameters.AddWithValue("@ped_dataentrega", System.Data.SqlDbType.DateTime);
                cmd.Parameters["@ped_dataentrega"].Value = modelo.PedDtEntrega;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("DALPedidoVenda, Alterar - " + ex.Message);
            }
        }

        //localizar pelo código do Cliente
        public DataTable Localizar(int codigo)
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select c.ped_cod, c.ped_data, c.ped_total, c.ped_status," +
                    "  f.cli_nome from pedidovenda c inner join cliente f on c.cli_cod = f.cli_cod" +
                    " where c.cli_cod =" + codigo, conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception("DALPedidoVenda, Localizar - " + ex.Message);
            }
        }

        //localizar todos pedidos
        public DataTable Localizar()
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select c.ped_cod, c.ped_data, c.ped_total, c.ped_status," +
                    "  f.cli_nome from pedidovenda c inner join cliente f on c.cli_cod = f.cli_cod",conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception("DALPedidoVenda, Localizar " + ex.Message);
            }
        }

        //localizar por periodo pré definido
        public DataTable Localizar(DateTime dtincial , DateTime dtfinal)
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "Select c.ped_cod, c.ped_data, c.ped_total, c.ped_status," +
                    "  f.cli_nome from pedidovenda c inner join cliente f on c.cli_cod = f.cli_cod" +
                    " where c.ped_data BETWEEN @dtinicial and @dtfinal";

                cmd.Parameters.Add("@dtinicial", System.Data.SqlDbType.Date );
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
                throw new Exception("DALPedidoVenda, Localizar " + ex.Message);
            }
        }

        public ModeloPedidoVenda CarregaModeloPedidoVenda(int codigo)
        {
            try
            {
                ModeloPedidoVenda modelo = new ModeloPedidoVenda();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "select * from pedidovenda where ped_cod = @codigo";
                cmd.Parameters.AddWithValue("@codigo", codigo);
                conexao.Conectar();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();

                    modelo.PedCod = Convert.ToInt32(registro["ped_cod"]);
                    modelo.PedData = Convert.ToDateTime(registro["ped_data"]);
                    modelo.PedTotal = Convert.ToDouble(registro["ped_total"]);
                    modelo.PedStatus = Convert.ToInt32(registro["ped_status"]);
                    modelo.CliCod = Convert.ToInt32(registro["cli_cod"]);
                    modelo.PedDtEntrega = Convert.ToDateTime(registro["ped_dataentrega"]);
                }
                conexao.Desconectar();
                return modelo;
            }
            catch (Exception ex)
            {
                throw new Exception("DALPedidoVenda, CarregaModeloPedidoVenda - " + ex.Message);
            }
        }

        public void AtualizaStatus(ModeloPedidoVenda modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "update pedidovenda set ped_status = @ped_status" +
                    " where ped_cod = @codigo";

                cmd.Parameters.AddWithValue("@codigo", modelo.PedCod);
                cmd.Parameters.AddWithValue("@ped_status", modelo.PedStatus);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("DAL Pedido Vendas, Cancelar Pedido - " + ex.Message);
            }
        }
    }
}
