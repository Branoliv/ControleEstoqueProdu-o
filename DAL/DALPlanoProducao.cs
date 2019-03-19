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
    public class DALPlanoProducao
    {
        private DALConexao conexao;

        public DALPlanoProducao(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloPlanoProducao modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "insert into planoproducao (pro_cod,plp_qtde,umed_cod)" +
                "values (@pro_cod,@plp_qtde,@umed_cod); select @@IDENTITY;";
               
                //dados primitivos
                cmd.Parameters.AddWithValue("@pro_cod", modelo.Procod);
                cmd.Parameters.AddWithValue("@plp_qtde", modelo.PlpQtde);
                cmd.Parameters.AddWithValue("@umed_cod", modelo.UmdeCod);
                

                modelo.PlpCod = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception("DALPlanoProducao, Incluir " + ex.Message);
            }
        }

        public void Alterar(ModeloPlanoProducao modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "update planoproducao set pro_cod = @pro_cod,plp_qtde = @plp_qtde,umed_cod = @umed_cod where plp_cod = @plp_cod";

                //dados primitivos
                cmd.Parameters.AddWithValue("@pro_cod", modelo.Procod);
                cmd.Parameters.AddWithValue("@plp_qtde", modelo.PlpQtde);
                cmd.Parameters.AddWithValue("@umed_cod", modelo.UmdeCod);
                cmd.Parameters.AddWithValue("@plp_cod", modelo.PlpCod);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("DAL Plano Producao, Alterar " + ex.Message);
            }
        }

        public void Excluir(int codigo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "delete from planoproducao where plp_cod = @codigo";
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("DALPlanoProducao, Excluir - " + ex.Message);
            }
        }

        public DataTable Localizar(int codigo)
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select p.plp_cod,p.pro_cod,m.pro_nome,p.plp_qtde,u.umed_simbolo" +
                    " from planoproducao p inner join produto m on p.pro_cod = m.pro_cod inner join undmedida u" +
                   " on p.umed_cod = u.umed_cod where p.pro_cod =" + codigo, conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception("DAL Plano Producao, Localizar " + ex.Message);
            }
        }

        public ModeloPlanoProducao CarregaModeloPlanoProducao(int codigo)
        {
            try
            {
                ModeloPlanoProducao modelo = new ModeloPlanoProducao();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "select * from planoproducao where plp_cod = @plp_cod";
                cmd.Parameters.AddWithValue("@plp_cod", codigo);
                conexao.Conectar();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();

                    modelo.PlpCod = Convert.ToInt32(registro["plp_cod"]);
                    modelo.Procod = Convert.ToInt32(registro["pro_cod"]);
                    modelo.PlpQtde = Convert.ToInt32(registro["plp_qtde"]);
                    modelo.UmdeCod = Convert.ToInt32(registro["umed_cod"]);
                    
                }
                conexao.Desconectar();
                return modelo;
            }
            catch (Exception ex)
            {
                throw new Exception("DALPlanoProducao, CarregaModeloPlanoProducao " + ex.Message);
            }
        }

        public DataTable LocalizarItemPlano(int codigo)
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select i.ipp_cod,p.plp_cod,i.pro_cod,m.pro_nome,i.ipp_qtde,u.umed_simbolo,i.ipp_deposito" +
                    " from planoproducao p inner join itensplanoproducao i on p.plp_cod = i.plp_cod " +
                    "inner join produto m on m.pro_cod = i.pro_cod inner join undmedida u" +
                   " on m.umed_cod = u.umed_cod where p.pro_cod =" + codigo, conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception("DAL Plano Producao, Localizar Item Plano " + ex.Message);
            }
        }

    }
}
