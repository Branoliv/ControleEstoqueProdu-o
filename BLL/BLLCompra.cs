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
    public class BLLCompra
    {
        private DALConexao conexao;

        public BLLCompra(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCompra modelo)
        {
            //if (modelo.ComData != DateTime.Now)
            //{
            //    throw new Exception("A data da compra não corresponde a data atual.");
            //}

            if (modelo.ComNParcelas <= 0)
            {
                throw new Exception("O número de parcelas deve ser maior que zero.");
            }

            if (modelo.ForCod <= 0)
            {
                throw new Exception("O codigo do fornecedor deve ser informado.");
            }

            if (modelo.ComTotal<=0)
            {
                throw new Exception("O valor da compra deve ser informado.");
            }

            if (modelo.DepProd <=0)
            {
                throw new Exception("Informe um depósito valido.");
            }     
            
            if (modelo.TpMovimento <= 0)
            {
                throw new Exception("O tipo de movimento é obrigatório.");
            }      

            DALCompra DALobj = new DALCompra(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloCompra modelo)
        {
            if (modelo.ComCod <= 0)
            {
                throw new Exception("BLLCompras - O código da compra deve ser maior que zero.");
            }

            if (modelo.ComData != DateTime.Now)
            {
                throw new Exception("BLLCompras - A data da compra não corresponde a data atual.");
            }

            if (modelo.ComNParcelas <= 0)
            {
                throw new Exception("BLLCompras - O número de parcelas deve ser maior que zero.");
            }

            if (modelo.ForCod <= 0)
            {
                throw new Exception("BLLCompras - O codigo do fornecedor deve ser informado.");
            }

            if (modelo.ComTotal <= 0)
            {
                throw new Exception("BLLCompras - O valor da compra deve ser informado.");
            }

            if (modelo.TpMovimento <= 0)
            {
                throw new Exception("BLLCompras - O tipo de movimento é obrigatório.");
            }

            DALCompra DALobj = new DALCompra(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALCompra DALobj = new DALCompra(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(int codigo)
        {
            DALCompra DALobj = new DALCompra(conexao);
            return DALobj.Localizar(codigo);
        }

        public DataTable Localizar()
        {
            DALCompra DALobj = new DALCompra(conexao);
            return DALobj.Localizar();
        }

        public DataTable Localizar(DateTime dtincial, DateTime dtfinal)
        {
            DALCompra DALobj = new DALCompra(conexao);
            return DALobj.Localizar(dtincial,dtfinal);
        }

        public ModeloCompra CarregaModeloCompra(int codigo)
        {
            DALCompra DALobj = new DALCompra(conexao);
            return DALobj.CarregaModeloCompra(codigo);
        }

        public void Estorno(ModeloCompra modelo)
        {
            if (modelo.ComCod <= 0)
            {
                throw new Exception("BLLCompras - O código da compra deve ser maior que zero.");
            }

            //if (modelo.ComData != DateTime.Now)
            //{
            //    throw new Exception("BLLCompras - A data da compra não corresponde a data atual.");
            //}

            if (modelo.ComNParcelas <= 0)
            {
                throw new Exception("BLLCompras - O número de parcelas deve ser maior que zero.");
            }

            if (modelo.ForCod <= 0)
            {
                throw new Exception("BLLCompras - O codigo do fornecedor deve ser informado.");
            }

            if (modelo.ComTotal <= 0)
            {
                throw new Exception("BLLCompras - O valor da compra deve ser informado.");
            }

            if (modelo.TpMovimento <= 0)
            {
                throw new Exception("BLLCompras - O tipo de movimento é obrigatório.");
            }

            DALCompra DALobj = new DALCompra(conexao);
            DALobj.Estorno(modelo);
        }

        public ModeloCompra VerificaNotaFornecedor(int nota, int tm, int codigo)
        {
            DALCompra DALobj = new DALCompra(conexao);
            return DALobj.VerificaNotaFornecedor( nota,tm,codigo);         
        }
    }
}
