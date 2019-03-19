using DAL;
using MODELO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLDeposito
    {
        private DALConexao conexao;

        public BLLDeposito(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloDeposito modelo)
        {
            if (modelo.DepAbrev.Trim().Length == 0)
            {
                throw new Exception("O nome da deposito é obrigatório");
            }
            modelo.DepAbrev = modelo.DepAbrev.ToUpper();


            if (modelo.DepNome.Trim().Length == 0)
            {
                throw new Exception("O nome do deposito é obrigatório");
            }
            modelo.DepNome = modelo.DepNome.ToUpper();

            DALDeposito DALobj = new DALDeposito(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloDeposito modelo)
        {
            if (modelo.DepCod <= 0)
            {
                throw new Exception("O código da deposito é obrigatório");
            }

            if (modelo.DepAbrev.Trim().Length == 0)
            {
                throw new Exception("O nome da deposito é obrigatório");
            }
            modelo.DepAbrev = modelo.DepAbrev.ToUpper();


            if (modelo.DepNome.Trim().Length == 0)
            {
                throw new Exception("O nome do deposito é obrigatório");
            }
            modelo.DepNome = modelo.DepNome.ToUpper();

            DALDeposito DALobj = new DALDeposito(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int Codigo)
        {
            DALDeposito DALobj = new DALDeposito(conexao);
            DALobj.Excluir(Codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALDeposito DALobj = new DALDeposito(conexao);
            return DALobj.Localizar(valor);
        }

        public DataTable LocalizarAbreviacao(String valor)
        {
            DALDeposito DALobj = new DALDeposito(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloDeposito CarregaModeloDeposito(int codigo)
        {
            DALDeposito DALobj = new DALDeposito(conexao);
            return DALobj.CarregaModeloDeposito(codigo);
        }

        public ModeloDeposito CarregaModeloDepositoAbr(string abreviacao)
        {
            DALDeposito DALobj = new DALDeposito(conexao);
            return DALobj.CarregaModeloDepositoAbr(abreviacao);
        }
    }
}
