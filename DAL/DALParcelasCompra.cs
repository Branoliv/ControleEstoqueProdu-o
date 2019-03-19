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
    public class DALParcelasCompra
    {
        private DALConexao conexao;

        public DALParcelasCompra(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloParcelasCompra modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "insert into parcelascompra (pco_cod,com_cod,pco_datavecto,pco_valor, pco_status) values (@pco_cod,@com_cod,@pco_datavecto,@pco_valor, @pco_status);";
                cmd.Parameters.AddWithValue("@pco_cod", modelo.PcoCod);
                cmd.Parameters.AddWithValue("@com_cod", modelo.ComCod);                
                cmd.Parameters.AddWithValue("@pco_valor", modelo.PcoValor);
                cmd.Parameters.AddWithValue("@pco_datavecto", System.Data.SqlDbType.Date);
                cmd.Parameters["@pco_datavecto"].Value = modelo.PcoDtVecto;
                cmd.Parameters.AddWithValue("@pco_status", modelo.PcoStatus);
              
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception("DALIncluir Parcelas Compra /n" + ex.Message);
            }           
        }

        public void Alterar(ModeloParcelasCompra modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "update parcelascompra set  pco_valor = @pco_valor," +
                    "pco_datapagto = @pco_datapagto, pco_datavecto = @pco_datavecto, pco_status = @pco_status" +
                    " where pco_cod = @pco_cod and com_cod = @com_cod";

                cmd.Parameters.AddWithValue("@pco_cod", modelo.PcoCod);
                cmd.Parameters.AddWithValue("@com_cod", modelo.ComCod);
                cmd.Parameters.AddWithValue("@pco_valor", modelo.PcoValor);
                cmd.Parameters.AddWithValue("@pco_datavecto", System.Data.SqlDbType.DateTime);
                cmd.Parameters["@pco_datavecto"].Value = modelo.PcoDtVecto;
                cmd.Parameters.AddWithValue("@pco_datapagto", System.Data.SqlDbType.DateTime);
                if(modelo.PcoDtPagto == null)
                {
                    cmd.Parameters["@pco_datapagto"].Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters["@pco_datapagto"].Value = modelo.PcoDtPagto;
                }
                cmd.Parameters.AddWithValue("@pco_status", modelo.PcoStatus);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception("DALAlterar Parcelas Compra /n" + ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public void Excluir(ModeloParcelasCompra modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "delete from parcelasCompra " +
                    " where pco_cod = @pco_cod and com_cod = @com_cod ";

                cmd.Parameters.AddWithValue("@pco_cod", modelo.PcoCod);
                cmd.Parameters.AddWithValue("@com_cod", modelo.ComCod);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception("DALExcluir Parcelas Compra /n" + ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public void ExcluirTodasParcelas(int comcod)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "delete from parcelasCompra " +
                    " where com_cod = @com_cod ";                
                cmd.Parameters.AddWithValue("@com_cod", comcod);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("DALExcluir Todas Parcelas Compra /n" + ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public DataTable Localizar(int comcod)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select p.pco_cod, p.pco_valor, p.pco_datavecto, p.pco_status from parcelascompra p where com_cod =" +
                comcod.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarPgto(int comcod)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from parcelascompra where com_cod =" +
                comcod.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloParcelasCompra CarregaModeloParcelasCompra(int comcod)
        {
            ModeloParcelasCompra modelo = new ModeloParcelasCompra();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from parcelascompra  where com_cod = @com_cod ";            
            cmd.Parameters.AddWithValue("@com_cod", comcod);            
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.PcoCod = Convert.ToInt32(registro["pco_cod"]);
                modelo.PcoValor = Convert.ToDouble(registro["pco_valor"]);
                cmd.Parameters.AddWithValue("@pco_datapagto", System.Data.SqlDbType.DateTime);
                if (modelo.PcoDtPagto == null)
                {
                    cmd.Parameters["@pco_datapagto"].Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters["@pco_datapagto"].Value = modelo.PcoDtPagto;
                }
                modelo.PcoDtVecto = Convert.ToDateTime(registro["pco_datavecto"]);
                modelo.ComCod = Convert.ToInt32(registro["com_cod"]);
                modelo.PcoStatus = Convert.ToInt32(registro["pco_status"]);
            }
            conexao.Desconectar();
            return modelo;
        }

        public void Estono(ModeloParcelasCompra modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "update parcelascompra set  pco_valor = @pco_valor," +
                    "pco_datavecto = @pco_datavecto, pco_status = @pco_status" +
                    " where pco_cod = @pco_cod and com_cod = @com_cod";

                cmd.Parameters.AddWithValue("@pco_cod", modelo.PcoCod);
                cmd.Parameters.AddWithValue("@com_cod", modelo.ComCod);
                cmd.Parameters.AddWithValue("@pco_valor", modelo.PcoValor);
                cmd.Parameters.AddWithValue("@pco_datavecto", System.Data.SqlDbType.DateTime);
                cmd.Parameters["@pco_datavecto"].Value = modelo.PcoDtVecto;
                cmd.Parameters.AddWithValue("@pco_datapagto", System.Data.SqlDbType.DateTime);
                //if (modelo.PcoDtPagto == null)
                //{
                //    cmd.Parameters["@pco_datapagto"].Value = DBNull.Value;
                //}
                //else
                //{
                //    cmd.Parameters["@pco_datapagto"].Value = modelo.PcoDtPagto;
                //}
                cmd.Parameters.AddWithValue("@pco_status", modelo.PcoStatus);
               
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("DALEstorno Parcelas Compra " + ex.Message);
            }            
        }

        public void PagtoCompra(ModeloParcelasCompra modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "update parcelascompra set pco_datapagto = @pco_datapagto" +
                    " where pco_cod = @pco_cod and com_cod = @com_cod";

                cmd.Parameters.AddWithValue("@pco_cod", modelo.PcoCod);
                cmd.Parameters.AddWithValue("@com_cod", modelo.ComCod);                
                cmd.Parameters.AddWithValue("@pco_datapagto", System.Data.SqlDbType.DateTime);
                if (modelo.PcoDtPagto == DateTime.MinValue)
                {
                    cmd.Parameters["@pco_datapagto"].Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters["@pco_datapagto"].Value = modelo.PcoDtPagto;
                }
               
                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("DALAlterar Parcelas Compra /n" + ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }
    }
}
