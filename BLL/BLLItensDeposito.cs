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
    public class BLLItensDeposito
    {
        private DALConexao conexao;

        public BLLItensDeposito(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloItensDeposito modelo)
        {
            if (modelo.DepCodProd <= 0)
            {
                throw new Exception("BLL - O código do produto é obrigatório");
            }
            
            if (modelo.DepProdAbrev.Trim().Length == 0)
            {
                throw new Exception("BLL - O nome do deposito é obrigatório");
            }
            modelo.DepProdAbrev = modelo.DepProdAbrev.ToUpper();

            DALItensDeposito DALobj = new DALItensDeposito(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloItensDeposito modelo)
        {
            if (modelo.DepCodProd <= 0)
            {
                throw new Exception("BLL - O código da itensdeposito é obrigatório");
            }

            if (modelo.DepProdAbrev.Trim().Length == 0)
            {
                throw new Exception("BLL - O nome da itensdeposito é obrigatório");
            }
            modelo.DepProdAbrev = modelo.DepProdAbrev.ToUpper();            

            DALItensDeposito DALobj = new DALItensDeposito(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int Codigo)
        {
            DALItensDeposito DALobj = new DALItensDeposito(conexao);
            DALobj.Excluir(Codigo);
        }

        public DataTable Localizar(int valor)
        {
            DALItensDeposito DALobj = new DALItensDeposito(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloItensDeposito CarregaModeloItensDeposito(int codigo)
        {
            DALItensDeposito DALobj = new DALItensDeposito(conexao);
            return DALobj.CarregaModeloItensDeposito(codigo);
        }
    }
}
