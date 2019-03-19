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
    public class DALItensPedidoVenda
    {
        private DALConexao conexao;

        public DALItensPedidoVenda(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloItensPedidoVenda modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "insert into itenspedidovenda (ipv_cod,ped_cod,pro_cod,ipv_qtde,ipv_valor,ipv_status,ipv_dep)" +
                "values (@ipv_cod,@ped_cod,@pro_cod,@ipv_qtde,@ipv_valor,@ipv_status,@ipv_dep); select @@IDENTITY;";

                cmd.Parameters.AddWithValue("@ipv_cod", modelo.IpvCod);
                cmd.Parameters.AddWithValue("@ped_cod", modelo.PedCod);
                cmd.Parameters.AddWithValue("@pro_cod", modelo.ProCod);
                cmd.Parameters.AddWithValue("@ipv_qtde", modelo.IpvQtde);
                cmd.Parameters.AddWithValue("@ipv_valor", modelo.IpvValor);
                cmd.Parameters.AddWithValue("@ipv_status", modelo.IpvStatus);
                cmd.Parameters.AddWithValue("@ipv_dep", modelo.IpvDep);
                
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("DAL Itens Pedido Venda, Incluir - " + ex.Message);
            }
        }

        public void Alterar(ModeloItensPedidoVenda modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "update itenspedidovenda set ipv_cod = @ipv_cod,pro_cod = @pro_cod,ipv_qtde = @ipv_qtde,ipv_valor = @ipv_valor,ipv_status = @ipv_status, ipv_dep = @ipv_dep" +
                    " where ped_cod = @ped_cod and ipv_cod = @ipv_cod";

                cmd.Parameters.AddWithValue("@ped_cod", modelo.PedCod);
                cmd.Parameters.AddWithValue("@ipv_cod", modelo.IpvCod);
                cmd.Parameters.AddWithValue("@pro_cod", modelo.ProCod);
                cmd.Parameters.AddWithValue("@ipv_qtde", modelo.IpvQtde);
                cmd.Parameters.AddWithValue("@ipv_valor", modelo.IpvValor);
                cmd.Parameters.AddWithValue("@ipv_status", modelo.IpvStatus);
                cmd.Parameters.AddWithValue("@ipv_dep", modelo.IpvDep);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("DAL Itens Pedido Venda, Alterar - " + ex.Message);
            }
        }

        //localizar pelo código do Cliente
        public DataTable Localizar(int codigo)
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select p.ipv_cod, p.pro_cod, m.pro_nome, p.ipv_qtde, u.umed_simbolo, p.ipv_valor, p.ipv_status, p.ipv_dep" +
                    " from itenspedidovenda p inner join produto m on p.pro_cod = m.pro_cod inner join undmedida u on u.umed_cod = m.umed_cod" +
                    " where ped_cod =" + codigo + "order by p.ipv_cod", conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception("DALItensPedidoVenda, Localizar - " + ex.Message);
            }
        }

        public DataTable Localizar()
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * from itenspedidovenda  order by ped_cod,ipv_cod", conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception("DAL Itens Pedido Venda, Localizar - " + ex.Message);
            }
        }

        public ModeloItensPedidoVenda CarregaModeloItensPedidoVenda(int codigo)
        {
            try
            {
                ModeloItensPedidoVenda modelo = new ModeloItensPedidoVenda();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "select * from itenspedidovenda where ped_cod = @codigo";
                cmd.Parameters.AddWithValue("@codigo", codigo);
                conexao.Conectar();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();

                    modelo.PedCod = Convert.ToInt32(registro["ped_cod"]);
                    modelo.IpvCod = Convert.ToInt32(registro["ipv_cod"]);
                    modelo.ProCod = Convert.ToInt32(registro["pro_cod"]);
                    modelo.IpvQtde = Convert.ToDouble(registro["ipv_qtde"]);
                    modelo.IpvValor = Convert.ToDouble(registro["ipv_valor"]);
                    modelo.IpvStatus = Convert.ToInt32(registro["ipv_status"]);
                    modelo.IpvDep = registro["ipv_dep"].ToString();
                }
               
                return modelo;
            }
            catch (Exception ex)
            {
                throw new Exception("DAL Itens Pedido Venda, CarregaModeloItensPedidoVenda - " + ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public void CancelarPedido(ModeloItensPedidoVenda modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "update itenspedidovenda set ipv_status = @ipv_status" +
                    " where ipv_cod = @ipv_cod and ped_cod = @codigo";

                cmd.Parameters.AddWithValue("@ipv_cod", modelo.IpvCod);
                cmd.Parameters.AddWithValue("@codigo", modelo.PedCod);
                cmd.Parameters.AddWithValue("@ipv_status", modelo.IpvStatus);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("DAL Itens Pedido Vendas, Cancelar Itens Pedido - " + ex.Message);
            }
        }

        public DataTable LocalizarItem(int codigo, int item)
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "Select * from itenspedidovenda" +
                    " where ped_cod = @ped_cod and ipv_cod = @ipv_cod";

                cmd.Parameters.AddWithValue("@ped_cod", codigo);
                cmd.Parameters.AddWithValue("@ipv_cod", item);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabela);
                return tabela;

            }
            catch (Exception ex)
            {
                throw new Exception("DAL Itens Pedido Venda, Localizar Item - " + ex.Message);
            }
        }

        public void ExcluirItem(ModeloItensPedidoVenda modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "delete from itenspedidovenda where ped_cod = @ped_cod";
                cmd.Parameters.AddWithValue("@ped_cod", modelo.PedCod);
                // conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("DAL Itens Pedido Venda, Excluir Item - " + ex.Message);
            }
        }

        public ModeloItensPedidoVenda ItemPedidoOrdemProducao(int pedCod,int pedItem)
        {
            try
            {
                ModeloItensPedidoVenda modelo = new ModeloItensPedidoVenda();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "Select * from itenspedidovenda where ped_cod = @ped_cod and ipv_cod = @ipv_cod";
                cmd.Parameters.AddWithValue("@ped_cod", pedCod);
                cmd.Parameters.AddWithValue("@ipv_cod", pedItem);
                conexao.Conectar();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();

                    modelo.PedCod = Convert.ToInt32(registro["ped_cod"]);
                    modelo.IpvCod = Convert.ToInt32(registro["ipv_cod"]);
                    modelo.ProCod = Convert.ToInt32(registro["pro_cod"]);
                    modelo.IpvQtde = Convert.ToDouble(registro["ipv_qtde"]);
                    modelo.IpvValor = Convert.ToDouble(registro["ipv_valor"]);
                    modelo.IpvStatus = Convert.ToInt32(registro["ipv_status"]);
                    modelo.IpvDep = registro["ipv_dep"].ToString();
                }
               
                return modelo;
            }
            catch (Exception ex)
            {
                throw new Exception("DAL Itens Pedido Venda, CarregaModeloItensPedidoVenda - " + ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public void AtualizaStatus(ModeloItensPedidoVenda modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "update itenspedidovenda set ipv_status = @ipv_status" +
                    " where ped_cod = @ped_cod and ipv_cod = @ipv_cod";

                cmd.Parameters.AddWithValue("@ped_cod", modelo.PedCod);
                cmd.Parameters.AddWithValue("@ipv_cod", modelo.IpvCod);
                cmd.Parameters.AddWithValue("@ipv_status", modelo.IpvStatus);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("DAL Itens Pedido Venda, Alterar - " + ex.Message);
            }
        }

    }
}
