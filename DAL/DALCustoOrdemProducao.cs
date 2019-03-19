using MODELO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALCustoOrdemProducao
    {
        double vlReal = 0;

        private DALConexao conexao;
        public double cstUnit = 0;

        public DALCustoOrdemProducao(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCustoOrdemProducao modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "insert into custoordemproducao (cat_cod,scat_cod,cop_custoteoricosubit,cop_custorealsubit,odp_cod,ico_cod) " +
                    "values (@cat_cod,@scat_cod,@cop_custoteoricosubit,@cop_custorealsubit,@odp_cod,@ico_cod);";

                cmd.Parameters.AddWithValue("@cat_cod", modelo.CatCod);
                cmd.Parameters.AddWithValue("@scat_cod", modelo.Scatcod);
                cmd.Parameters.AddWithValue("@cop_custoteoricosubit", modelo.CopCstTeorico);
                cmd.Parameters.AddWithValue("@cop_custorealsubit", modelo.CopCstReal);
                cmd.Parameters.AddWithValue("@odp_cod", modelo.OdpCod);
                cmd.Parameters.AddWithValue("@ico_cod", modelo.IcoCod);

                cmd.ExecuteNonQuery();
               
            }
            catch(Exception ex)
            {
                throw new Exception("DALCustoOrdemProdução, Inculir - " + ex.Message);
            }
        }

        public void Excluir(int odpCod)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "delete from custoordemproducao where odp_cod = @odp_cod";

                cmd.Parameters.AddWithValue("@odp_cod", odpCod);

                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception("DALCustoOrdemProdução, Excluir - " + ex.Message);
            }
        }

        public DataTable Localizar(int odpCod)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from custoordemproducao where odp_cod =" + odpCod, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable recuperaCusto(int proCod)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select c.cat_cod,s.scat_cod,p.pro_valorpago" +
                " from produto p inner join categoria c on p.cat_cod = c.cat_cod inner join"+
                " subcategoria s on p.scat_cod = s.scat_cod where p.pro_cod ="+ proCod, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable Grupo(int catCod, int scatCod)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select c.cat_nome,s.scat_nome" +
                " from categoria c ,subcategoria s" +
                "  where c.cat_cod =" + catCod + " and s.scat_cod =" + scatCod, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public bool ContemItem(int odpCod,int icoCod)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "select odp_cod,ico_cod from custoordemproducao where odp_cod = @odp_cod and ico_cod = @ico_cod and cop_custorealsubit = 0";

                cmd.Parameters.AddWithValue("@odp_cod", odpCod);
                cmd.Parameters.AddWithValue("@ico_cod", icoCod);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                bool verificado = (count > 0);
                return verificado;
            }
            catch (Exception ex)
            {
                throw new Exception("DALCustoOrdemProdução, ContemItem - " + ex.Message);
            }
        }

        public void Apontamento (ModeloCustoOrdemProducao modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;

            vlReal = RecuperaValor(modelo.OdpCod, modelo.IcoCod);

            modelo.CopCstReal = ValorEntrada(modelo.CopCstReal, vlReal);

            cmd.CommandText = "update custoordemproducao set cop_custorealsubit = @cop_custorealsubit where odp_cod = @odp_cod and ico_cod = @ico_cod";

            cmd.Parameters.AddWithValue("@odp_cod", modelo.OdpCod);
            cmd.Parameters.AddWithValue("@ico_cod", modelo.IcoCod);
            cmd.Parameters.AddWithValue("@cop_custorealsubit", modelo.CopCstReal);

            cmd.ExecuteNonQuery();
        }

        public double RecuperaValor(int odpCod, int iopCod)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "select cop_custorealsubit from custoordemproducao " +
                    "where odp_cod = @odp_cod and ico_cod = @ico_cod";

                cmd.Parameters.AddWithValue("@odp_cod", odpCod);
                cmd.Parameters.AddWithValue("@ico_cod", iopCod);

                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    if (registro["cop_custorealsubit"] != DBNull.Value)
                    {
                        vlReal = Convert.ToDouble(registro["cop_custorealsubit"]);
                    }
                }

                registro.Close();
                return vlReal;
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
    }
}
