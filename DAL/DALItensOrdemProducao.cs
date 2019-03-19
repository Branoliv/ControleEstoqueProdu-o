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
    public class DALItensOrdemProducao
    {
        double qtdeAtual = 0;

        private DALConexao conexao;

        public DALItensOrdemProducao(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloItensOrdemProducao modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "insert into itensordemproducao (iop_cod,pro_cod,iop_qtdplano,iop_status,odp_cod,iop_deposito)" +
                    " values (@iop_cod,@pro_cod,@iop_qtdplano,@iop_status,@odp_cod,@iop_deposito);";

                cmd.Parameters.AddWithValue("@iop_cod", modelo.Iopcod);
                cmd.Parameters.AddWithValue("@pro_cod", modelo.ProCod);
                cmd.Parameters.AddWithValue("@iop_qtdplano", modelo.IopQtdPlano);
                cmd.Parameters.AddWithValue("@iop_status", modelo.IopStatus);
                cmd.Parameters.AddWithValue("@odp_cod", modelo.OdpCod);
                cmd.Parameters.AddWithValue("@iop_deposito", modelo.IopDeposito);

                cmd.ExecuteScalar();
            }
            catch(Exception ex)
            {
                throw new Exception("DAL Itens Ordem Procução, Incluir - " + ex.Message);
            }
        }

        public void Alterar(ModeloItensOrdemProducao modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "update itensordemproducao set pro_cod = @pro_cod, iop_qtdplano = @iop_qtdplano," +
                    "iop_status = @iop_status, iop_deposito = @iop_deposito where odp_cod = @odp_cod and iop_cod = @ip_cod;";

                cmd.Parameters.AddWithValue("@pro_cod", modelo.ProCod);
                cmd.Parameters.AddWithValue("@iop_qtdplano", modelo.IopQtdPlano);
                cmd.Parameters.AddWithValue("@iop_statu", modelo.IopStatus);
                cmd.Parameters.AddWithValue("@odp_cod", modelo.OdpCod);
                cmd.Parameters.AddWithValue("@iop_cod", modelo.Iopcod);
                cmd.Parameters.AddWithValue("@iop_deposito", modelo.IopDeposito);

                cmd.ExecuteScalar();
                
            }
            catch(Exception ex)
            {
                throw new Exception("DAL Itens Ordem Produção, Alerar - " + ex.Message);
            }

        }

        public void  Apontamento (ModeloItensOrdemProducao modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;

            qtdeAtual = RecuperaValor(modelo.OdpCod, modelo.Iopcod, modelo.ProCod);

            modelo.IopQtdReal = ValorEntrada(modelo.IopQtdReal, qtdeAtual);

            cmd.CommandText = "update itensordemproducao set iop_qtdreal = @iop_qtdreal where odp_cod = @odp_cod and iop_cod = @iop_cod and pro_cod = @pro_cod";

            cmd.Parameters.AddWithValue("@iop_qtdreal", modelo.IopQtdReal);
            cmd.Parameters.AddWithValue("@odp_cod", modelo.OdpCod);
            cmd.Parameters.AddWithValue("@iop_cod", modelo.Iopcod);
            cmd.Parameters.AddWithValue("@pro_cod", modelo.ProCod);

            cmd.ExecuteNonQuery();

        }

        public DataTable Localizar(int codigo)
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select i.iop_cod, i.pro_cod, p.pro_nome, i.iop_qtdplano,i.iop_qtdreal, u.umed_simbolo, i.iop_deposito " +
                    "from itensordemproducao i inner join produto p on i.pro_cod = p.pro_cod" +
                    " inner join undmedida u on p.umed_cod = u.umed_cod " +
                    "where odp_cod =" + codigo.ToString(),conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception("DAL Itens Ordem Produção, Localizar - " + ex.Message);
            }
        }

        public void Cancelar(ModeloItensOrdemProducao modelo)
        {

        }

        public void ExcluirItem(int codigo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "delete from itensordemproducao where odp_cod = @odp_cod";
                cmd.Parameters.AddWithValue("@odp_cod", codigo);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("DAL Itens Ordem Produção, Excluir - " + ex.Message);
            }
        }

        public double RecuperaValor(int odpCod, int iopCod, int proCod)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "select iop_qtdreal from itensordemproducao " +
                    "where odp_cod = @odp_cod and iop_cod = @iop_cod and pro_cod = @pro_cod";

                cmd.Parameters.AddWithValue("@odp_cod", odpCod);
                cmd.Parameters.AddWithValue("@iop_cod", iopCod);
                cmd.Parameters.AddWithValue("@pro_cod", proCod);

                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    if (registro["iop_qtdreal"] != DBNull.Value)
                    {
                        qtdeAtual = Convert.ToDouble(registro["iop_qtdreal"]);
                    }
                }

                registro.Close();
                return qtdeAtual;
            }
            catch (Exception ex)
            {
                throw new Exception("DAL Custo Ordem Produção, Recupera Saldo - " + ex.Message);
            }
        }

        public double ValorEntrada(double valor1, double valor2)
        {
            valor1 += valor2;
            return valor1;
        }

        public void AtualizaStatus(ModeloItensOrdemProducao modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "update ItensOrdemProducao set iop_status = @iop_status" +
                    " where odp_cod = @odp_cod and iop_cod = @iop_cod";

                cmd.Parameters.AddWithValue("@odp_cod", modelo.OdpCod);
                cmd.Parameters.AddWithValue("@iop_cod", modelo.Iopcod);
                cmd.Parameters.AddWithValue("@iop_status", modelo.IopStatus);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("DAL Itens Ordem Produção, Atualiza status - " + ex.Message);
            }
        }
    }
}
