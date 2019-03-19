using MODELO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALEstoque
    {
        public int Tm = 0;
        public double qtdeAtual = 0;
        public double ctMedio = 0;
        public double vlrEstoque = 0;
        protected double qtdeSaldo = 0;
        protected double qtdeReservado = 0;
        protected double qtdeBloqueado = 0;
        protected double vlrSaldo = 0;
        protected double saldoDe = 0;
        protected double saldoPara = 0;
        protected string coluna = "";

        private DALConexao conexao;

        public DALEstoque(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloEstoque modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "insert into estoque (pro_cod,est_saldo,dep_abreviacao,est_customedio,est_vlrestq)" +
                    " values (@codigo,@saldo,@dep_abreviacao,@est_customedio,@est_vlrestq);";

                cmd.Parameters.AddWithValue("@codigo", modelo.ProdCod);
                cmd.Parameters.AddWithValue("@saldo", modelo.EstSaldo);
                cmd.Parameters.AddWithValue("@dep_abreviacao", modelo.DepAbrev);
                cmd.Parameters.AddWithValue("@est_customedio", ctMedio);
                cmd.Parameters.AddWithValue("@est_vlrestq", modelo.VlrEstq);

                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(ModeloEstoque modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "update estoque set est_saldo = @saldo, est_customedio = @est_customedio, est_vlrestq = @est_vlrestq   where pro_cod = @codigo and dep_abreviacao = @dep_abreviacao;" +
                    "update produto set pro_valorpago = @est_customedio where pro_cod = @codigo;";
                cmd.Parameters.AddWithValue("@codigo", modelo.ProdCod);
                cmd.Parameters.AddWithValue("@saldo", qtdeAtual);
                cmd.Parameters.AddWithValue("@dep_abreviacao", modelo.DepAbrev);
                cmd.Parameters.AddWithValue("@est_customedio", ctMedio);
                cmd.Parameters.AddWithValue("@est_vlrestq", vlrEstoque);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("DALEstoque; Alterar - " + ex.Message);
            }
        }

        public void Excluir(int codigo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "delete from estoque where pro_cod = @codigo and dep_abreviacao = @dep_abreviacao";
                cmd.Parameters.AddWithValue("@codigo", codigo);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                //throw 
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public DataTable Localizar(int codigo)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from estoque where pro_cod = " +
                codigo, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloEstoque CarregaModeloEstoque(int codigo)
        {
            ModeloEstoque modelo = new ModeloEstoque();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from estoque where pro_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ProdCod = Convert.ToInt32(registro["pro_cod"]);
                modelo.EstSaldo = Math.Round(Convert.ToDouble(registro["est_saldo"]), 3);
                modelo.DepAbrev = Convert.ToString(registro["dep_abreviacao"]);
                modelo.CstMedio = Convert.ToDouble(registro["est_customedio"]);
                modelo.VlrEstq = Convert.ToDouble(registro["est_vlrestq"]);
                modelo.EstSaldoRevservado = Convert.ToDouble(registro["est_saldoreservado"]);
                modelo.EstSaldoBloqueado = Convert.ToDouble(registro["est_saldobloqueado"]);
            }
            conexao.Desconectar();
            return modelo;
        }

        public void VerificaSaldoNegativo(ModeloEstoque modelo)
        {
            Tm = modelo.EstTm;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "select * from estoque where pro_cod = @codigo and dep_abreviacao = @dep_abreviacao";
                cmd.Parameters.AddWithValue("@codigo", modelo.ProdCod);
                cmd.Parameters.AddWithValue("@dep_abreviacao", modelo.DepAbrev);
                conexao.Conectar();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                SqlDataReader registro = cmd.ExecuteReader();

                if (Tm == 2)
                {
                    if (count > 0)
                    {
                        double qtdeSaldo = 0;
                        while (registro.Read())
                        {
                            qtdeSaldo = Convert.ToDouble(registro["est_saldo"]);
                        }

                        qtdeAtual = Math.Round(qtdeSaldo - modelo.EstSaldo, 3);
                        if (qtdeAtual < 0)
                        {
                            throw new Exception("Não há saldo disponível para esse movimento.");
                        }
                    }
                    registro.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public void incluirReservaEstq(ModeloEstoque modelo)
        {
            saldoPara = saldoReservado(modelo.ProdCod, modelo.DepAbrev);
            modelo.EstSaldoRevservado += saldoPara;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;

                if (saldoPara == 0)
                {
                    cmd.CommandText = "insert into estoque (pro_cod,dep_abreviacao,est_saldoreservado)" +
                " values (@pro_cod,@dep_abreviacao,@est_saldoreservado)";
                }
                else
                {
                    cmd.CommandText = "update estoque set est_saldoreservado = @est_saldoreservado" +
                                        " where pro_cod = @pro_cod and dep_abreviacao = @dep_abreviacao";
                }

                cmd.Parameters.AddWithValue("@pro_cod", modelo.ProdCod);
                cmd.Parameters.AddWithValue("@dep_abreviacao", modelo.DepAbrev);
                cmd.Parameters.AddWithValue("@est_saldoreservado", modelo.EstSaldoRevservado);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("DAL Estoque, Reserva Estoque - " + ex.Message);
            }
        }

        public double saldoReservado(int proCod, string depAbrev)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "select est_saldoreservado from estoque " +
                "where pro_cod = @pro_cod and dep_abreviacao = @dep_abreviacao";

            cmd.Parameters.AddWithValue("@pro_cod", proCod);
            cmd.Parameters.AddWithValue("@dep_abreviacao", depAbrev);

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            SqlDataReader registro = cmd.ExecuteReader();

            if (count > 0)
            {
                while (registro.Read())
                {
                    saldoDe = Convert.ToDouble(registro["est_saldoreservado"]);
                    saldoDe = Convert.ToDouble(registro["est_saldoreservado"]);
                    saldoDe = Convert.ToDouble(registro["est_saldoreservado"]);
                }
            }
            registro.Close();
            return saldoDe;
        }

        public double EntradaEstoque(double saldo1, double saldo2)
        {
            saldo1 += saldo2;
            return saldo1;
        }

        public double SaidaEstoque(double saldo1, double saldo2)
        {
            saldo2 -= saldo1;
            return saldo2;
        }

        public double ValorEntrada(double valor1, double valor2)
        {
            valor1 += valor2;
            return valor1;
        }

        public double ValorSaida(double valor1, double valor2)
        {
            valor2 -= valor1;
            return valor2;
        }

        public double CustoMedio( double valor2, double saldo1)
        {
            double valor1 = Math.Round((valor2 / saldo1),2);
            
            if (Double.IsNaN(valor1))
            {
                valor1 = 0;
            }

            return valor1;
        }

        // Verifica se existe material na tabela
        public bool VerificaMaterialEstoque(int proCod, string depAbrev)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "select * from estoque " +
                "where pro_cod = @pro_cod and dep_abreviacao = @dep_abreviacao";

            cmd.Parameters.AddWithValue("@pro_cod", proCod);
            cmd.Parameters.AddWithValue("@dep_abreviacao", depAbrev);

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            bool verificado = (count > 0);
            return verificado;
        }

        // Recupera saldo da coluna indicada na variavel coluna
        public double RecuperaSaldo(int proCod, string depAbrev)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "select * from estoque " +
                    "where pro_cod = @pro_cod and dep_abreviacao = @dep_abreviacao";

                cmd.Parameters.AddWithValue("@pro_cod", proCod);
                cmd.Parameters.AddWithValue("@dep_abreviacao", depAbrev);

                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    if(registro[coluna] != DBNull.Value)
                    {
                        saldoDe = Convert.ToDouble(registro[coluna]);
                    }
                }
                
                registro.Close();
                return saldoDe;
            }
            catch(Exception ex)
            {
                throw new Exception("DAL Estoque, Recupera Saldo - " + ex.Message);
            }
        }

        public double RecuperaValor(int proCod, string depAbrev)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "select est_vlrestq from estoque " +
                    "where pro_cod = @pro_cod and dep_abreviacao = @dep_abreviacao";

                cmd.Parameters.AddWithValue("@pro_cod", proCod);
                cmd.Parameters.AddWithValue("@dep_abreviacao", depAbrev);

                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    if (registro["est_vlrestq"] != DBNull.Value)
                    {
                        vlrSaldo = Convert.ToDouble(registro["est_vlrestq"]);
                    }
                }

                registro.Close();
                return vlrSaldo;
            }
            catch (Exception ex)
            {
                throw new Exception("DAL Estoque, Recupera Saldo - " + ex.Message);
            }
        }

        // Entrada ou Saida do saldo de reserva
        public void Reserva(ModeloEstoque modelo)
        {
            coluna = @"est_saldoreservado";
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                if (VerificaMaterialEstoque(modelo.ProdCod, modelo.DepAbrev))
                {
                    saldoPara  = RecuperaSaldo(modelo.ProdCod, modelo.DepAbrev);

                    Tm = modelo.EstTm;
                    switch (Tm)
                    {
                        case 1:
                            modelo.EstSaldoRevservado = EntradaEstoque(modelo.EstSaldoRevservado, saldoPara);

                            cmd.CommandText = "update estoque set est_saldoreservado = @est_saldoreservado" +
                                            " where pro_cod = @pro_cod and dep_abreviacao = @dep_abreviacao";

                            break;

                        case 2:
                            modelo.EstSaldoRevservado = SaidaEstoque(modelo.EstSaldoRevservado, saldoPara);

                            cmd.CommandText = "update estoque set est_saldoreservado = @est_saldoreservado" +
                                            " where pro_cod = @pro_cod and dep_abreviacao = @dep_abreviacao";

                            break;
                    }
                }
                else
                {
                    modelo.EstSaldoRevservado = EntradaEstoque(modelo.EstSaldoRevservado, saldoPara);

                    cmd.CommandText = "insert into estoque (pro_cod,dep_abreviacao,est_saldoreservado)" +
                        " values (@pro_cod,@dep_abreviacao,@est_saldoreservado)";
                }

                cmd.Parameters.AddWithValue("@pro_cod", modelo.ProdCod);
                cmd.Parameters.AddWithValue("@dep_abreviacao", modelo.DepAbrev);
                cmd.Parameters.AddWithValue("@est_saldoreservado", modelo.EstSaldoRevservado);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("DAL Estoque, Reserva - " + ex.Message);
            }
        }

        public void Bloqueio(ModeloEstoque modelo)
        {
            coluna = @"est_saldobloqueado";
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                if (VerificaMaterialEstoque(modelo.ProdCod, modelo.DepAbrev))
                {
                    saldoPara = RecuperaSaldo(modelo.ProdCod, modelo.DepAbrev);

                    Tm = modelo.EstTm;
                    switch (Tm)
                    {
                        case 1:
                            modelo.EstSaldoRevservado = EntradaEstoque(modelo.EstSaldoRevservado, saldoPara);

                            cmd.CommandText = "update estoque set est_saldoreservado = @est_saldoreservado" +
                                            " where pro_cod = @pro_cod and dep_abreviacao = @dep_abreviacao";

                            break;

                        case 2:
                            modelo.EstSaldoRevservado = SaidaEstoque(modelo.EstSaldoRevservado, saldoPara);

                            cmd.CommandText = "update estoque set est_saldoreservado = @est_saldoreservado" +
                                            " where pro_cod = @pro_cod and dep_abreviacao = @dep_abreviacao";

                            break;
                    }
                }
                else
                {
                    modelo.EstSaldoRevservado = EntradaEstoque(modelo.EstSaldoRevservado, saldoPara);

                    cmd.CommandText = "insert into estoque (pro_cod,dep_abreviacao,est_saldoreservado)" +
                        " values (@pro_cod,@dep_abreviacao,@est_saldoreservado)";
                }

                cmd.Parameters.AddWithValue("@pro_cod", modelo.ProdCod);
                cmd.Parameters.AddWithValue("@dep_abreviacao", modelo.DepAbrev);
                cmd.Parameters.AddWithValue("@est_saldoreservado", modelo.EstSaldoRevservado);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("DAL Estoque, Reserva - " + ex.Message);
            }
        }

        public void AtualizaEstoque(ModeloEstoque modelo)
        {
            coluna = @"est_saldo";
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                if (VerificaMaterialEstoque(modelo.ProdCod, modelo.DepAbrev))
                {
                    saldoPara = RecuperaSaldo(modelo.ProdCod, modelo.DepAbrev);

                    vlrSaldo = RecuperaValor(modelo.ProdCod, modelo.DepAbrev);

                    if(Double.IsNaN(ctMedio))
                    {
                        ctMedio = modelo.CstMedioAt;
                    }

                    Tm = modelo.EstTm;
                    switch (Tm)
                    {
                        case 1:
                            modelo.EstSaldo = EntradaEstoque(modelo.EstSaldo, saldoPara);
                            modelo.VlrEstq = ValorEntrada(modelo.VlrEstq, vlrSaldo);
                            ctMedio = CustoMedio(modelo.VlrEstq, modelo.EstSaldo);

                            cmd.CommandText = "update estoque set est_saldo = @est_saldo,est_customedio = @est_customedio," +
                                " est_vlrestq = @est_vlrestq where pro_cod = @pro_cod and dep_abreviacao = @dep_abreviacao;" +
                                "update produto set pro_valorpago = @est_customedio where pro_cod = @pro_cod;";

                            break;

                        case 2:
                            modelo.EstSaldo = SaidaEstoque(modelo.EstSaldo, saldoPara);
                            modelo.VlrEstq = ValorSaida(modelo.VlrEstq, vlrSaldo);
                            ctMedio = CustoMedio(modelo.VlrEstq, modelo.EstSaldo);

                            cmd.CommandText = "update estoque set est_saldo = @est_saldo,est_customedio = @est_customedio," +
                                " est_vlrestq = @est_vlrestq where pro_cod = @pro_cod and dep_abreviacao = @dep_abreviacao;" +
                                "update produto set pro_valorpago = @est_customedio where pro_cod = @pro_cod;";

                            break;
                    }
                }
                else
                {
                    modelo.EstSaldo = EntradaEstoque(modelo.EstSaldo, saldoPara);
                    ctMedio = CustoMedio(modelo.VlrEstq, modelo.EstSaldo);

                    cmd.CommandText = "insert into estoque (pro_cod,est_saldo,dep_abreviacao,est_customedio,est_vlrestq)" +
                    " values (@pro_cod,@est_saldo,@dep_abreviacao,@est_customedio,@est_vlrestq);" +
                    "update produto set pro_valorpago = @est_customedio where pro_cod = @pro_cod;";
                }

                cmd.Parameters.AddWithValue("@pro_cod", modelo.ProdCod);
                cmd.Parameters.AddWithValue("@est_saldo", modelo.EstSaldo);
                cmd.Parameters.AddWithValue("@dep_abreviacao", modelo.DepAbrev);
                cmd.Parameters.AddWithValue("@est_customedio", ctMedio);
                cmd.Parameters.AddWithValue("@est_vlrestq", modelo.VlrEstq);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("DALEstoque, Atualiza Estoque - " + ex.Message);
            }
        }
    }
}
