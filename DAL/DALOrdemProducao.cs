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
    public class DALOrdemProducao
    {

        private DALConexao conexao;
        
        public DALOrdemProducao(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void incluir(ModeloOrdemProducao modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "insert into ordemproducao (ped_cod,pro_cod,odp_qtde,odp_status,ipv_cod)" +
                    " values (@ped_cod,@pro_cod,@odp_qtde,@odp_status,@ipv_cod); select @@IDENTITY;";

                cmd.Parameters.AddWithValue("@ped_cod", modelo.PedCod);
                cmd.Parameters.AddWithValue("@pro_cod", modelo.ProdCod);
                cmd.Parameters.AddWithValue("@odp_qtde", modelo.OdpQtde);
                cmd.Parameters.AddWithValue("@odp_status", modelo.OdpStatus);
                cmd.Parameters.AddWithValue("@ipv_cod", modelo.IpvCod);

                modelo.OdpCod = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch(Exception ex)
            {
                throw new Exception("DAL Ordem Produção, Incluir - " + ex.Message);
            }
        }

        public void alterar (ModeloOrdemProducao modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "update ordemproducao set ped_cod = @ped_cod,pro_cod = @pro_cod,odp_qtde = @odp_qtde,odp_status = @odp_status,ipv_cod = @ipv_cod" +
                    " where odp_cod = @odp_cod";

                cmd.Parameters.AddWithValue("@odp_cod", modelo.OdpCod);
                cmd.Parameters.AddWithValue("@ped_cod", modelo.PedCod);
                cmd.Parameters.AddWithValue("@pro_cod", modelo.ProdCod);
                cmd.Parameters.AddWithValue("@odp_qtde", modelo.OdpQtde);
                cmd.Parameters.AddWithValue("@odp_status", modelo.OdpStatus);
                cmd.Parameters.AddWithValue("@ipv_cod", modelo.IpvCod);
                //cmd.Parameters.AddWithValue("@odp_dtfinal", System.Data.SqlDbType.DateTime);
                //if (modelo.OdpDtFinal == null)
                //{
                //    cmd.Parameters["@odp_dtfinal"].Value = DBNull.Value;
                //}
                //else
                //{
                //    cmd.Parameters["@odp_dtfinal"].Value = modelo.OdpDtFinal;
                //}

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("DAL Ordem Produção, Alterar - " + ex.Message);
            }
        }

        public DataTable Localizar(int codigo)
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select o.odp_cod,o.ped_cod, o.pro_cod,p.pro_nome,o.odp_qtde,u.umed_simbolo,o.odp_status" +
                    " from ordemproducao o inner join produto p on o.pro_cod = p.pro_cod inner join undmedida u on u.umed_cod = p.umed_cod" +
                    " where o.ped_cod =" + codigo + "order by o.odp_cod", conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch(Exception ex)
            {
                throw new Exception("DAL Ordem Produção, Localizar Pedido Venda - " + ex.Message);
            }
        }

        public DataTable Localizar()
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select o.odp_cod,o.ped_cod, o.pro_cod,p.pro_nome,o.odp_qtde,u.umed_simbolo,o.odp_status" +
                    " from ordemproducao o inner join produto p on o.pro_cod = p.pro_cod inner join undmedida u on u.umed_cod = p.umed_cod order by o.odp_cod", conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception("DAL Ordem Produção, Localizar - " + ex.Message);
            }
        }

        public ModeloOrdemProducao CarregaOrdemProducao(int codigo)
        {
            try
            {
                ModeloOrdemProducao modelo = new ModeloOrdemProducao();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "Select * from ordemproducao where odp_cod = @odp_cod";
                cmd.Parameters.AddWithValue("@odp_cod", codigo);

                conexao.Conectar();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();

                    modelo.OdpCod = Convert.ToInt32(registro["odp_cod"]);
                    modelo.PedCod = Convert.ToInt32(registro["ped_cod"]);
                    modelo.ProdCod = Convert.ToInt32(registro["pro_cod"]);
                    modelo.OdpQtde = Convert.ToDouble(registro["odp_qtde"]);
                    modelo.OdpStatus = Convert.ToInt32(registro["odp_status"]);
                    modelo.IpvCod = Convert.ToInt32(registro["ipv_cod"]);
                    cmd.Parameters.AddWithValue("@odp_dtfinal", System.Data.SqlDbType.DateTime);
                    if(modelo.OdpDtFinal == null)
                    {
                        cmd.Parameters["@odp_dtfinal"].Value = DBNull.Value;
                    }
                    else
                    {
                        cmd.Parameters["@odp_dtfinal"].Value = modelo.OdpDtFinal;
                    }
}
                return modelo;
            }
            catch (Exception ex)
            {
                throw new Exception("DAL Ordem Produção, Carrega Ordem Produção - " + ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public void Excluir (int odpCod)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "delete from ordemproducao where odp_cod = @odp_cod";

            cmd.Parameters.AddWithValue("@odp_cod", odpCod);
            cmd.ExecuteNonQuery();
        }

        public void AtualizaStatus(ModeloOrdemProducao modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "update ordemproducao set odp_status = @odp_status" +
                    " where odp_cod = @odp_cod";

                cmd.Parameters.AddWithValue("@odp_cod", modelo.OdpCod);
                cmd.Parameters.AddWithValue("@odp_status", modelo.OdpStatus);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("DAL Ordem produção, Atualiza status - " + ex.Message);
            }
        }

        public void FinalizaOrdem(ModeloOrdemProducao modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "update ordemproducao set odp_status = @odp_status, odp_dtfinal = @odp_dtfinal" +
                    " where odp_cod = @odp_cod";

                cmd.Parameters.AddWithValue("@odp_status", modelo.OdpStatus);
                cmd.Parameters.AddWithValue("@odp_dtfinal", modelo.OdpDtFinal);
                cmd.Parameters.AddWithValue("@odp_cod", modelo.OdpCod);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("DAL Ordem Produção, Finaliza Ordem - " + ex);
            }
        }
    }
}
