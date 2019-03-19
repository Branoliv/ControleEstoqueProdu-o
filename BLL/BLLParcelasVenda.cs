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
    public class BLLParcelasVenda
    {
        private DALConexao conexao;

        public BLLParcelasVenda(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloParcelasVenda modelo)
        {
            if (modelo.VenCod <= 0)
            {
                throw new Exception("BLLParcelasVenda - O código da venda é obrigatório");
            }

            if (modelo.PveCod <= 0)
            {
                throw new Exception("BLLParcelasVenda - O código da parcela é obrigatório");
            }

            if (modelo.PveValor <= 0)
            {
                throw new Exception("BLLParcelasVenda - O valor da parcela é obrigatório");
            }

            DateTime data = DateTime.Now;
            if (modelo.PveDtVecto < data)
            {
                throw new Exception("BLLParcelasVendaa - A data de vencimento deve ser igual ou maior que a data atual.");
            }

            DALParcelasVenda DALobj = new DALParcelasVenda(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloParcelasVenda modelo)
        {
            if (modelo.VenCod <= 0)
            {
                throw new Exception("BLLParcelasVenda - O código da venda é obrigatório");
            }

            if (modelo.PveCod <= 0)
            {
                throw new Exception("BLLParcelasVenda - O código da parcela é obrigatório");
            }

            if (modelo.PveValor <= 0)
            {
                throw new Exception("BLLParcelasVenda - O valor da parcela é obrigatório");
            }

            DateTime data = DateTime.Now;
            if (modelo.PveDtVecto < data)
            {
                throw new Exception("BLLParcelasVenda - A data de vencimento deve ser igual ou maior que a data atual.");
            }

            DALParcelasVenda DALobj = new DALParcelasVenda(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(ModeloParcelasVenda modelo)
        {
            if (modelo.VenCod <= 0)
            {
                throw new Exception("BLLParcelasVenda - O código da venda é obrigatório");
            }

            if (modelo.VenCod <= 0)
            {
                throw new Exception("BLLParcelasVenda - O código da parcela é obrigatório");
            }

            DALParcelasVenda DALobj = new DALParcelasVenda(conexao);
            DALobj.Excluir(modelo);
        }

        public void ExcluirTodasParcelas(int vencod)
        {
            if (vencod <= 0)
            {
                throw new Exception("BLLParcelasVenda - O código da venda é obrigatório");
            }

            DALParcelasCompra DALobj = new DALParcelasCompra(conexao);
            DALobj.ExcluirTodasParcelas(vencod);
        }

        public DataTable Localizar(int vencod)
        {
            if (vencod <= 0)
            {
                throw new Exception("BLLParcelasVenda - O código da venda é obrigatório");
            }

            DALParcelasVenda DALobj = new DALParcelasVenda(conexao);
            return DALobj.Localizar(vencod);
        }

        public ModeloParcelasVenda CarregaModeloParcelasVenda(int vencod)
        {
            if (vencod <= 0)
            {
                throw new Exception("BLLParcelasVenda - O código da venda é obrigatório");
            }

            DALParcelasVenda DALobj = new DALParcelasVenda(conexao);
            return DALobj.CarregaModeloItensVenda(vencod);
        }
    }
}
