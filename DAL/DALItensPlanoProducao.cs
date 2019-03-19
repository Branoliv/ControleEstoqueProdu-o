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
    public class DALItensPlanoProducao
    {
        private DALConexao conexao;

        public DALItensPlanoProducao(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloItensPlanoProducao modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "insert into itensplanoproducao (ipp_cod,pro_cod,ipp_qtde,plp_cod,ipp_deposito)" +
                "values (@ipp_cod,@pro_cod,@ipp_qtde,@plp_cod,@ipp_deposito);";

                //dados primitivos
                cmd.Parameters.AddWithValue("@ipp_cod", modelo.IppCod);
                cmd.Parameters.AddWithValue("@pro_cod", modelo.ProCod);
                cmd.Parameters.AddWithValue("@ipp_qtde", modelo.IppQtde);
                cmd.Parameters.AddWithValue("@plp_cod", modelo.PlpCod);
                cmd.Parameters.AddWithValue("@ipp_deposito", modelo.IppDeposito);

               cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("DAL Itens Plano Producao, Incluir " + ex.Message);
            }
        }

        public void Alterar(ModeloItensPlanoProducao modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "update itensplanoproducao set pro_cod = @pro_cod,ipp_qtde = @ipp_qtde, ipp_deposito = @ipp_deposito" +
                    " where ipp_cod = @ipp_cod and plp_cod = @plp_cod";

                cmd.Parameters.AddWithValue("@ipp_cod", modelo.IppCod);
                cmd.Parameters.AddWithValue("@pro_cod", modelo.ProCod);
                cmd.Parameters.AddWithValue("@ipp_qtde", modelo.IppQtde);
                cmd.Parameters.AddWithValue("@plp_cod", modelo.PlpCod);
                cmd.Parameters.AddWithValue("@ipp_deposito", modelo.IppDeposito);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("DALItensPlanoProducao, Alterar " + ex.Message);
            }
        }

        public void Excluir(ModeloItensPlanoProducao modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "delete from itensplanoproducao where plp_cod = @plp_cod";
                cmd.Parameters.AddWithValue("@plp_cod", modelo.PlpCod);
               // conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception("DALItensPlanoProducao, Excluir - " + ex.Message);
            }
        }

        public void ExcluirItem(ModeloItensPlanoProducao modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "delete from itensplanoproducao where plp_cod = @plp_cod";
                cmd.Parameters.AddWithValue("@plp_cod", modelo.PlpCod);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("DALItensPlanoProducao, Excluir - " + ex.Message);
            }
        }

        public DataTable Localizar(int codigo)
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select i.ipp_cod,i.pro_cod,p.pro_nome,i.ipp_qtde,u.umed_simbolo,i.ipp_deposito" +
                    " from itensplanoproducao i inner join produto p on i.pro_cod = p.pro_cod inner join undmedida u on p.umed_cod = u.umed_cod" + 
                    " where plp_cod =" + codigo + " order by i.ipp_cod", conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception("DAL Itens Plano Producao, Localizar - " + ex.Message);
            }
        }

        public ModeloItensPlanoProducao CarregaModeloItensPlanoProducao(int codigo)
        {
            try
            {
                ModeloItensPlanoProducao modelo = new ModeloItensPlanoProducao();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "select * from itensplanoproducao where plp_cod = @plp_cod";
                cmd.Parameters.AddWithValue("@plp_cod", codigo);
                conexao.Conectar();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    modelo.IppCod = Convert.ToInt32(registro["ipp_cod"]);
                    modelo.ProCod = Convert.ToInt32(registro["pro_cod"]);
                    modelo.IppQtde = Convert.ToInt32(registro["ipp_qtde"]);
                    modelo.PlpCod = Convert.ToInt32(registro["plp_cod"]);
                    modelo.IppDeposito = registro["ipp_deposito"].ToString();
                }
                conexao.Desconectar();
                return modelo;
            }
            catch (Exception ex)
            {
                throw new Exception("DALItensPlanoProducao, CarregaModeloItensPlanoProducao - " + ex.Message);
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
                cmd.CommandText ="Select * from itensplanoproducao" +
                    " where plp_cod = @plp_cod and ipp_cod = @ipp_cod";

                cmd.Parameters.AddWithValue("@plp_cod", codigo);
                cmd.Parameters.AddWithValue("@ipp_cod", item);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabela);
                return tabela;
                
            }
            catch (Exception ex)
            {
                throw new Exception("DALItensPlanoProducao, Localizar Item - " + ex.Message);
            }
        }
    }
}
