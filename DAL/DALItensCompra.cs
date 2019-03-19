using MODELO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALItensCompra
    {
        private DALConexao conexao;

        public DALItensCompra(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloItensCompra modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "insert into itenscompra (itc_cod, itc_qtde,itc_valor,com_cod,pro_cod,dep_cod,itc_status) values (@itc_cod, @itc_qtde, @itc_valor, @com_cod, @pro_cod,@dep_cod, @itc_status);";

                cmd.Parameters.AddWithValue("@itc_cod", modelo.ItcCod);
                cmd.Parameters.AddWithValue("@itc_qtde", modelo.ItcQtde);
                cmd.Parameters.AddWithValue("@itc_valor", modelo.ItcValor);
                cmd.Parameters.AddWithValue("@com_cod", modelo.ComCod);
                cmd.Parameters.AddWithValue("@pro_cod", modelo.ProCod);
                cmd.Parameters.AddWithValue("@dep_cod", modelo.DepCod);
                cmd.Parameters.AddWithValue("@itc_status", modelo.ItcStatus);
             
                cmd.ExecuteScalar();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }            
        }

        public void Alterar(ModeloItensCompra modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "update itenscompra set itc_qtde = @itc_qtde, itc_valor = @itc_valor, dep_cod = @dep_cod, itc_status = @itc_status" +
                    " where itc_cod = @itc_cod and com_cod = @com_cod and pro_cod = @pro_cod ";

                cmd.Parameters.AddWithValue("@itc_cod", modelo.ItcCod);
                cmd.Parameters.AddWithValue("@itc_qtde", modelo.ItcQtde);
                cmd.Parameters.AddWithValue("@itc_valor", modelo.ItcValor);
                cmd.Parameters.AddWithValue("@com_cod", modelo.ComCod);
                cmd.Parameters.AddWithValue("@pro_cod", modelo.ProCod);
                cmd.Parameters.AddWithValue("@dep_cod", modelo.DepCod);
                cmd.Parameters.AddWithValue("@itc_status", modelo.ItcStatus);

                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }            
        }

        public void Excluir(ModeloItensCompra modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "delete from itenscompra " +
                    " where itc_cod = @itc_cod and com_cod = @com_cod and pro_cod = @pro_cod ";

                cmd.Parameters.AddWithValue("@itc_cod", modelo.ItcCod);                
                cmd.Parameters.AddWithValue("@com_cod", modelo.ComCod);
                cmd.Parameters.AddWithValue("@pro_cod", modelo.ProCod);        
                       
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }           
        }

        public DataTable Localizar(int comcod)
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select i.com_cod, i.itc_cod, i.pro_cod, p.pro_nome, i.itc_qtde, u.umed_simbolo, i.dep_cod, i.itc_valor, i.itc_status " +
                    "from itenscompra i inner join produto p on i.pro_cod = p.pro_cod inner join undmedida u on p.umed_cod = u.umed_cod  where com_cod =" +
                    comcod.ToString(), conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch(Exception ex)
            {
                throw new Exception("DALItensCompras, Localizar " + ex.Message);
            }
        }

        public ModeloItensCompra CarregaModeloItensCompra(int ItcCod, int ComCod, int ProCod)
        {
            ModeloItensCompra modelo = new ModeloItensCompra();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from itenscompra  where itc_cod = @itc_cod and com_cod = @com_cod and pro_cod = @pro_cod ";

            cmd.Parameters.AddWithValue("@itc_cod", ItcCod);
            cmd.Parameters.AddWithValue("@com_cod", ComCod);
            cmd.Parameters.AddWithValue("@pro_cod", ProCod);            
            conexao.Conectar();

            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                modelo.ItcCod = ItcCod;
                modelo.ProCod = ProCod;
                modelo.ComCod = ComCod;
                modelo.ItcQtde = Convert.ToDouble(registro["itc_qtde"]);
                modelo.ItcValor = Convert.ToDouble(registro["itc_valor"]);
                modelo.DepCod = Convert.ToString(registro["dep_cod"]);
                modelo.ItcStatus = Convert.ToInt32(registro["itc_status"]);
            }
            conexao.Desconectar();
            return modelo;
        }

        public ModeloItensCompra CarregaModeloItensCompra(int ComCod)
        {
            ModeloItensCompra modelo = new ModeloItensCompra();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from itenscompra  where com_cod = @com_cod";  
                     
            cmd.Parameters.AddWithValue("@com_cod", ComCod);           
            conexao.Conectar();

            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                modelo.ItcCod = Convert.ToInt32(registro["itc_cod"]);
                modelo.ProCod = Convert.ToInt32(registro["pro_cod"]);
                modelo.ComCod = ComCod;
                modelo.ItcQtde = Convert.ToDouble(registro["itc_qtde"]);
                modelo.ItcValor = Convert.ToDouble(registro["itc_valor"]);
                modelo.ItcStatus = Convert.ToInt32(registro["itc_status"]);
            }
            conexao.Desconectar();
            return modelo;
        }

        public void Estorno(ModeloItensCompra modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "update itenscompra set itc_qtde = @itc_qtde, itc_valor = @itc_valor, dep_cod = @dep_cod, itc_status = @itc_status" +
                    " where itc_cod = @itc_cod and com_cod = @com_cod and pro_cod = @pro_cod ";

                cmd.Parameters.AddWithValue("@itc_cod", modelo.ItcCod);
                cmd.Parameters.AddWithValue("@itc_qtde", modelo.ItcQtde);
                cmd.Parameters.AddWithValue("@itc_valor", modelo.ItcValor);
                cmd.Parameters.AddWithValue("@com_cod", modelo.ComCod);
                cmd.Parameters.AddWithValue("@pro_cod", modelo.ProCod);
                cmd.Parameters.AddWithValue("@dep_cod", modelo.DepCod);
                cmd.Parameters.AddWithValue("@itc_status", modelo.ItcStatus);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
