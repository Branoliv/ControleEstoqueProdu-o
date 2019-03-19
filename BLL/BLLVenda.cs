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
    public class BLLVenda
    {
        private DALConexao conexao;

        public BLLVenda(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloVenda modelo)
        {
            //if (modelo.VenData != DateTime.Now)
            //{
            //    throw new Exception("A data da venda não corresponde a data atual.");
            //}

            if (modelo.VenNParcelas <= 0)
            {
                throw new Exception("O número de parcelas deve ser maior que zero.");
            }

            if (modelo.CliCod <= 0)
            {
                throw new Exception("O codigo do cliente deve ser informado.");
            }

            if (modelo.VenTotal <= 0)
            {
                throw new Exception("O valor da venda deve ser informado.");
            }
            
            if (modelo.TpMovimento <= 0)
            {
                throw new Exception("O tipo de movimento é obrigatório.");
            }

            DALVenda DALobj = new DALVenda(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloVenda modelo)
        {
            if (modelo.VenCod <= 0)
            {
                throw new Exception("BLLVendas - O código da venda deve ser maior que zero.");
            }

            if (modelo.VenData != DateTime.Now)
            {
                throw new Exception("BLLVendas - A data da venda não corresponde a data atual.");
            }

            if (modelo.VenNParcelas <= 0)
            {
                throw new Exception("BLLVendas - O número de parcelas deve ser maior que zero.");
            }

            if (modelo.CliCod <= 0)
            {
                throw new Exception("BLLVendas - O codigo do cliente deve ser informado.");
            }

            if (modelo.VenTotal <= 0)
            {
                throw new Exception("BLLVendas - O valor da venda deve ser informado.");
            }

            if (modelo.TpMovimento <= 0)
            {
                throw new Exception("BLLVendas - O tipo de movimento é obrigatório.");
            }

            DALVenda DALobj = new DALVenda(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALVenda DALobj = new DALVenda(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(int codigo)
        {
            DALVenda DALobj = new DALVenda(conexao);
            return DALobj.Localizar(codigo);
        }

        public DataTable Localizar()
        {
            DALVenda DALobj = new DALVenda(conexao);
            return DALobj.Localizar();
        }

        public DataTable Localizar(DateTime dtincial, DateTime dtfinal)
        {
            DALVenda DALobj = new DALVenda(conexao);
            return DALobj.Localizar(dtincial, dtfinal);
        }

        public ModeloVenda CarregaModeloVenda(int codigo)
        {
            DALVenda DALobj = new DALVenda(conexao);
            return DALobj.CarregaModeloVenda(codigo);
        }

        public void Estorno(ModeloVenda modelo)
        {
            if (modelo.VenCod <= 0)
            {
                throw new Exception("BLLVendas - O código da venda deve ser maior que zero.");
            }
           
            if (modelo.VenNParcelas <= 0)
            {
                throw new Exception("BLLVendas - O número de parcelas deve ser maior que zero.");
            }

            if (modelo.CliCod <= 0)
            {
                throw new Exception("BLLVendas - O codigo do cliente deve ser informado.");
            }

            if (modelo.VenTotal <= 0)
            {
                throw new Exception("BLLVendas - O valor da venda deve ser informado.");
            }

            if (modelo.TpMovimento <= 0)
            {
                throw new Exception("BLLVendas - O tipo de movimento é obrigatório.");
            }

            DALVenda DALobj = new DALVenda(conexao);
            DALobj.Estorno(modelo);
        }

        public ModeloVenda VerificaNotaFornecedor(int nota, int tm, int codigo)
        {
            DALVenda DALobj = new DALVenda(conexao);
            return DALobj.VerificaNotaFornecedor(nota, tm, codigo);
        }
    }
}
