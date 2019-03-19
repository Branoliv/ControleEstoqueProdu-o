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
    public class DALParcelasVenda
    {
        private DALConexao conexao;

        public DALParcelasVenda(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloParcelasVenda modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "insert into parcelasvenda (pve_cod,ven_cod,pcodatavecto,pve_valor) values (@pve_cod,@ven_cod,@pcodatavecto,@pve_valor);";
                cmd.Parameters.AddWithValue("@pve_cod", modelo.PveCod);
                cmd.Parameters.AddWithValue("@ven_cod", modelo.VenCod);
                cmd.Parameters.AddWithValue("@pve_valor", modelo.PveValor);
                cmd.Parameters.AddWithValue("@pve_datavecto", System.Data.SqlDbType.DateTime);
                cmd.Parameters["@pve_datavecto"].Value = modelo.PveDtVecto;
                conexao.Conectar();
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("DALIncluir Parcelas Venda /n" + ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public void Alterar(ModeloParcelasVenda modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "update parcelasvenda set  pve_valor = @pve_valor," +
                    "pve_datapagto = @pve_datapagto, pcodatavecto = @pcodatavecto" +
                    " where pve_cod = @pve_cod and ven_cod = @ven_cod";

                cmd.Parameters.AddWithValue("@pve_cod", modelo.PveCod);
                cmd.Parameters.AddWithValue("@ven_cod", modelo.VenCod);
                cmd.Parameters.AddWithValue("@pve_valor", modelo.PveValor);
                cmd.Parameters.AddWithValue("@pve_datavecto", System.Data.SqlDbType.DateTime);
                cmd.Parameters["@pve_datavecto"].Value = modelo.PveDtVecto;
                cmd.Parameters.AddWithValue("@pve_datapagto", System.Data.SqlDbType.DateTime);
                if (modelo.PveDtPagto == null)
                {
                    cmd.Parameters["@pve_datapagto"].Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters["@pve_datapagto"].Value = modelo.PveDtPagto;
                }
                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("DALAlterar Parcelas Venda /n" + ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public void Excluir(ModeloParcelasVenda modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "delete from parcelasvenda " +
                    " where pve_cod = @pve_cod and ven_cod = @ven_cod ";

                cmd.Parameters.AddWithValue("@pve_cod", modelo.PveCod);
                cmd.Parameters.AddWithValue("@ven_cod", modelo.VenCod);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("DALExcluir Parcelas Venda /n" + ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public void ExcluirTodasParcelas(int vencod)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "delete from parcelasvenda " +
                    " where ven_cod = @ven_cod ";
                cmd.Parameters.AddWithValue("@ven_cod", vencod);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("DALExcluir Todas Parcelas Venda /n" + ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public DataTable Localizar(int vencod)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from parcelasvenda where ven_cod =" +
                vencod.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloParcelasVenda CarregaModeloItensVenda(int vencod)
        {
            ModeloParcelasVenda modelo = new ModeloParcelasVenda();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from parcelasvenda  where ven_cod = @ven_cod ";
            cmd.Parameters.AddWithValue("@ven_cod", vencod);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.PveCod = Convert.ToInt32(registro["pve_cod"]);
                modelo.PveValor = Convert.ToDouble(registro["pve_valor"]);
                modelo.PveDtPagto = Convert.ToDateTime(registro["pve_datapagto"]);
                modelo.PveDtVecto = Convert.ToDateTime(registro["pve_datavecto"]);
                modelo.VenCod = Convert.ToInt32(registro["ven_cod"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
