using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DALProduto
    {
        private DALConexao conexao;

        public DALProduto(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir (ModeloProduto obj)
        {
            try
            {                
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into produto (pro_nome, pro_descricao, pro_foto,pro_valorpago,pro_valorvenda,pro_qtde,umed_cod,cat_cod,scat_cod,pro_margemvenda,pro_ativo,pro_codigobarra,tpp_cod)"+
                "values (@nome,@descricao,@foto,@valorpago,@valorvenda,@qtde,@undmedcod,@catcod,@scatcod,@margem,@ativo,@codbarra,@tpp_cod);select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", obj.ProdNome);
            cmd.Parameters.AddWithValue("@descricao", obj.ProdDescricao);
            cmd.Parameters.Add("@foto", System.Data.SqlDbType.Image);

                if (obj.ProdFoto == null)
            {
                //cmd.Parameters.AddWithValue("@pro_fot", DBNull.Value);
                cmd.Parameters["@foto"].Value = DBNull.Value;
            }
            else
            {
               //cmd.Parameters.AddWithValue("@prod_foto", obj.ProdFoto);
                cmd.Parameters["@foto"].Value = obj.ProdFoto;
            }

            cmd.Parameters.AddWithValue("@valorpago", obj.ProdValorpago);
            cmd.Parameters.AddWithValue("@valorvenda", obj.ProdValorvenda);
            cmd.Parameters.AddWithValue("@qtde", obj.ProdQtde);
            cmd.Parameters.AddWithValue("@undmedcod", obj.UmedCodigo);
            cmd.Parameters.AddWithValue("@catcod", obj.CatCodigo);
            cmd.Parameters.AddWithValue("@scatcod", obj.ScatCodigo);
            cmd.Parameters.AddWithValue("@margem", obj.ProdMargem);
            cmd.Parameters.AddWithValue("@ativo", obj.ProdAtivo);
            cmd.Parameters.AddWithValue("@codbarra", obj.ProdCodBarra);
            cmd.Parameters.AddWithValue("@tpp_cod", obj.TppCodigo);                      
            conexao.Conectar();
            obj.ProdCodigo = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception erro)
            {
                throw new Exception("DALProduto, Incluir - " + erro.Message);
            }   
            finally
            {
                conexao.Desconectar();
            }
        }

        public void Excluir (int Codigo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "delete from produto where (pro_cod) = (@codigo)";
                cmd.Parameters.AddWithValue("@codigo", Codigo);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception("DAL SubCategoria Excluir - " + erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }            
        }

        public void Alterar (ModeloProduto obj)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "UPDATE produto SET pro_nome = (@nome), pro_descricao = (@descricao)," +
                    " pro_foto = (@foto), pro_valorpago =(@valorpago), pro_valorvenda = (@valorvenda),"+
                    "pro_qtde = (@qtde), umed_cod = (@undmedcod), cat_cod = (@catcod), scat_cod = (@scatcod),"+
                    " pro_margemvenda = (@margem), pro_ativo = (@ativo), pro_codigobarra = (@codbarra), tpp_cod = (@tpp_cod) WHERE pro_cod = (@codigo) ";
                cmd.Parameters.AddWithValue("@nome", obj.ProdNome);
                cmd.Parameters.AddWithValue("@descricao", obj.ProdDescricao);
                cmd.Parameters.Add("@foto", System.Data.SqlDbType.Image);
                if (obj.ProdFoto == null)
                {
                    //cmd.Parameters.AddWithValue("@pro_fot", DBNull.Value);
                    cmd.Parameters["@foto"].Value = DBNull.Value;
                }
                else
                {
                    //cmd.Parameters.AddWithValue("@prod_foto", obj.ProdFoto);
                    cmd.Parameters["@foto"].Value = obj.ProdFoto;
                }
                cmd.Parameters.AddWithValue("@valorpago", obj.ProdValorpago);
                cmd.Parameters.AddWithValue("@valorvenda", obj.ProdValorvenda);
                cmd.Parameters.AddWithValue("@qtde", obj.ProdQtde);
                cmd.Parameters.AddWithValue("@undmedcod", obj.UmedCodigo);
                cmd.Parameters.AddWithValue("@catcod", obj.CatCodigo);
                cmd.Parameters.AddWithValue("@scatcod", obj.ScatCodigo);
                cmd.Parameters.AddWithValue("@margem", obj.ProdMargem);
                cmd.Parameters.AddWithValue("@ativo", obj.ProdAtivo);
                cmd.Parameters.AddWithValue("@codbarra", obj.ProdCodBarra);
                cmd.Parameters.AddWithValue("@codigo", obj.ProdCodigo);
                cmd.Parameters.AddWithValue("@tpp_cod", obj.TppCodigo);
                conexao.Conectar();
                obj.ProdCodigo = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception erro)
            {
                throw new Exception("DAL Produto Incluir - " + erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public DataTable Localizar(String valor)
        {
            try
            {            
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT p.pro_cod, p.pro_codigobarra, p.pro_nome, p.pro_descricao, p.pro_foto, p.pro_valorpago, " +
                    "p.pro_valorvenda, p.pro_qtde, u.umed_simbolo, c.cat_nome, sc.scat_nome, p.pro_ativo,p.tpp_cod " +
                    " from produto p inner join undmedida u on p.umed_cod = u.umed_cod inner join categoria c on p.cat_cod = c.cat_cod " +
                    "inner join subcategoria sc on p.scat_cod = sc.scat_cod where p.pro_nome like '%" + valor + "%'", conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception erro)
            {
                throw new Exception("DAL Produto Localizar - " + erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public DataTable LocalizarPesqSimples(String valor)
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT p.pro_cod, p.pro_nome"+
                    " FROM produto p WHERE p.pro_nome LIKE '%" + valor + "%'", conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception erro)
            {
                throw new Exception("DAL Produto Localizar - " + erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public DataTable LocalizarCodigoBarras(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT p.pro_cod, p.pro_codigobarra, p.pro_nome, p.pro_descricao, p.pro_foto, p.pro_valorpago, " +
                "p.pro_valorvenda, p.pro_qtde, u.umed_simbolo, c.cat_nome, sc.scat_nome, p.pro_margemvenda, p.pro_ativo,p.tpp_cod " +
                " from produto p inner join undmedida u on p.umed_cod = u.umed_cod inner join categoria c on p.cat_cod = c.cat_cod " +
                "inner join subcategoria sc on p.scat_cod = sc.scat_cod where p.pro_codigobarra like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloProduto CarregaModeloProduto(int codigo)
        {
            try
            {
                ModeloProduto modelo = new ModeloProduto();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "select * from produto where (pro_cod) =" + codigo.ToString();
                conexao.Conectar();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();

                    modelo.ProdCodigo = Convert.ToInt32(registro["pro_cod"]);
                    modelo.ProdCodBarra = Convert.ToString(registro["pro_codigobarra"]);
                    modelo.ProdNome = Convert.ToString(registro["pro_nome"]);
                    modelo.ProdDescricao = Convert.ToString(registro["pro_descricao"]);
                    try
                    {
                        modelo.ProdFoto = (byte[])registro["pro_foto"];
                    }
                    catch { }
                    modelo.ProdValorpago = Convert.ToDouble(registro["pro_valorpago"]);
                    modelo.ProdValorvenda = Convert.ToDouble(registro["pro_valorvenda"]);
                    modelo.ProdQtde = Convert.ToDouble(registro["pro_qtde"]);
                    modelo.UmedCodigo = Convert.ToInt32(registro["umed_cod"]);
                    modelo.CatCodigo = Convert.ToInt32(registro["cat_cod"]);
                    modelo.ScatCodigo = Convert.ToInt32(registro["scat_cod"]);
                    modelo.ProdMargem = Convert.ToDouble(registro["pro_margemvenda"]);
                    modelo.ProdAtivo = Convert.ToString(registro["pro_ativo"]);
                    modelo.TppCodigo = Convert.ToInt32(registro["tpp_cod"]);
                }
                conexao.Desconectar();
                return modelo;
            }
            catch(Exception ex)
            {
                throw new Exception("DALProduto, CarregaModeloProduto - " + ex.Message);
            }
        }

        public ModeloProduto CarregaModeloProdutoCodBarras(String codbarras)
        {
            ModeloProduto modelo = new ModeloProduto();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from produto where (pro_codigobarra) LIKE '" + codbarras.ToString() + "'";
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();

                modelo.ProdCodigo = Convert.ToInt32(registro["pro_cod"]);
                modelo.ProdCodBarra = Convert.ToString(registro["pro_codigobarra"]);
                modelo.ProdNome = Convert.ToString(registro["pro_nome"]);
                modelo.ProdDescricao = Convert.ToString(registro["pro_descricao"]);
                try
                {
                    modelo.ProdFoto = (byte[])registro["pro_foto"];
                }
                catch { }
                modelo.ProdValorpago = Convert.ToDouble(registro["pro_valorpago"]);
                modelo.ProdValorvenda = Convert.ToDouble(registro["pro_valorvenda"]);
                modelo.ProdQtde = Convert.ToDouble(registro["pro_qtde"]);
                modelo.UmedCodigo = Convert.ToInt32(registro["umed_cod"]);
                modelo.CatCodigo = Convert.ToInt32(registro["cat_cod"]);
                modelo.ScatCodigo = Convert.ToInt32(registro["scat_cod"]);
                modelo.ProdMargem = Convert.ToDouble(registro["pro_margemvenda"]);
                modelo.ProdAtivo = Convert.ToString(registro["pro_ativo"]);
                modelo.TppCodigo = Convert.ToInt32(registro["tpp_cod"]);
            }
            conexao.Desconectar();
            return modelo;
        }


    }
}
