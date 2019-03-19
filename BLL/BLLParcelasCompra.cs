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
    public class BLLParcelasCompra
    {
        private DALConexao conexao;

        public BLLParcelasCompra(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloParcelasCompra modelo)
        {
            if (modelo.ComCod <= 0)
            {
                throw new Exception("BLLParcelasCompra - O código da parcela é obrigatório");
            }

            if (modelo.PcoCod <= 0)
            {
                throw new Exception("BLLParcelasCompra - O código da parcela é obrigatório");
            }

            if (modelo.PcoValor <= 0)
            {
                throw new Exception("BLLParcelasCompra - O valor da parcela é obrigatório");
            }

            DateTime data = DateTime.Now;
            if (modelo.PcoDtVecto < data.Date)
            {
                throw new Exception("BLLParcelasCompra - A data de vencimento deve ser igual ou maior que a data atual.");
            }

            if (modelo.PcoStatus < 0)
            {
                throw new Exception("Status não informado");
            }

            DALParcelasCompra DALobj = new DALParcelasCompra(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloParcelasCompra modelo)
        {
            if (modelo.ComCod <= 0)
            {
                throw new Exception("BLLParcelasCompra - O código da parcela é obrigatório");
            }

            if (modelo.PcoCod <= 0)
            {
                throw new Exception("BLLParcelasCompra - O código da parcela é obrigatório");
            }

            if (modelo.PcoValor <= 0)
            {
                throw new Exception("BLLParcelasCompra - O valor da parcela é obrigatório");
            }

            DateTime data = DateTime.Now;
            if (modelo.PcoDtVecto < data)
            {
                throw new Exception("BLLParcelasCompra - A data de vencimento deve ser igual ou maior que a data atual.");
            }

            if (modelo.PcoStatus < 0)
            {
                throw new Exception("Status não informado");
            }

            DALParcelasCompra DALobj = new DALParcelasCompra(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(ModeloParcelasCompra modelo)
        {
            if (modelo.ComCod <= 0)
            {
                throw new Exception("BLLParcelasCompra - O código da compra é obrigatório");
            }

            if (modelo.PcoCod <= 0)
            {
                throw new Exception("BLLParcelasCompra - O código da parcela é obrigatório");
            }

            DALParcelasCompra DALobj = new DALParcelasCompra(conexao);
            DALobj.Excluir(modelo);
        }

        public void ExcluirTodasParcelas(int comcod)
        {
            if (comcod <= 0)
            {
                throw new Exception("BLLParcelasCompra - O código da compra é obrigatório");
            }

            DALParcelasCompra DALobj = new DALParcelasCompra(conexao);
            DALobj.ExcluirTodasParcelas(comcod);
        }
    
        public DataTable Localizar(int comcod)
        {
            if (comcod <= 0)
            {
                throw new Exception("BLLParcelasCompra - O código da compra é obrigatório");
            }

            DALParcelasCompra DALobj = new DALParcelasCompra(conexao);
            return DALobj.Localizar(comcod);
        }

        public DataTable LocalizarPgto(int comcod)
        {
            if (comcod <= 0)
            {
                throw new Exception("BLLParcelasCompra - O código da compra é obrigatório");
            }

            DALParcelasCompra DALobj = new DALParcelasCompra(conexao);
            return DALobj.LocalizarPgto(comcod);
        }

        public ModeloParcelasCompra CarregaModeloParcelasCompra(int comcod)
        {
            if (comcod <= 0)
            {
                throw new Exception("BLLParcelasCompra - O código da compra é obrigatório");
            }
            DALParcelasCompra DALobj = new DALParcelasCompra(conexao);
            return DALobj.CarregaModeloParcelasCompra(comcod);
        }

        public void Estorno(ModeloParcelasCompra modelo)
        {
            if (modelo.ComCod <= 0)
            {
                throw new Exception("BLLParcelasCompra - O código da parcela é obrigatório");
            }

            if (modelo.PcoCod <= 0)
            {
                throw new Exception("BLLParcelasCompra - O código da parcela é obrigatório");
            }

            if (modelo.PcoValor <= 0)
            {
                throw new Exception("BLLParcelasCompra - O valor da parcela é obrigatório");
            }

            //DateTime data = DateTime.Now;
            //if (modelo.PcoDtVecto < data)
            //{
            //    throw new Exception("BLLParcelasCompra - A data de vencimento deve ser igual ou maior que a data atual.");
            //}

            if (modelo.PcoStatus < 0)
            {
                throw new Exception("Status não informado");
            }

            DALParcelasCompra DALobj = new DALParcelasCompra(conexao);
            DALobj.Estono(modelo);
        }

        public void PagtoCompra(ModeloParcelasCompra modelo)
        {
            if (modelo.ComCod <= 0)
            {
                throw new Exception("BLLParcelasCompra - O código da parcela é obrigatório");
            }

            if (modelo.PcoCod <= 0)
            {
                throw new Exception("BLLParcelasCompra - O código da parcela é obrigatório");
            }           
          
            if (modelo.PcoStatus == 1)
            {
                throw new Exception("Parcela estornada. O pagamento não pode ser efetuado.");
            }

            DALParcelasCompra DALobj = new DALParcelasCompra(conexao);
            DALobj.PagtoCompra(modelo);
        }
    }
}
