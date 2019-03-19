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
    public class BLLOrdemProducao
    {
        private DALConexao conexao;

        public BLLOrdemProducao (DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloOrdemProducao modelo)
        {
           if (modelo.ProdCod <=0)
            {
                throw new Exception("BLL Ordem Produção, Incluir - \n O código do produto é necessário");
            }
           if (modelo.OdpQtde <= 0)
            {
                throw new Exception("BLL Ordem Produção, Incluir - \n A quantidade é necessária.");
            }

            DALOrdemProducao DALObj = new DALOrdemProducao(conexao);
            DALObj.incluir(modelo);
        }

        public void Alterar(ModeloOrdemProducao modelo)
        {
            if (modelo.OdpCod <= 0)
            {
                throw new Exception("BLL Ordem Produção, Alterar - \n O código da ordem é necessária");
            }

            if (modelo.ProdCod <= 0)
            {
                throw new Exception("BLL Ordem Produção, Alterar - \n O código do produto é necessário");
            }
            if (modelo.OdpQtde <= 0)
            {
                throw new Exception("BLL Ordem Produção, Alterar - \n A quantidade é necessária.");
            }

            DALOrdemProducao DALObj = new DALOrdemProducao(conexao);
            DALObj.alterar(modelo);
        }

        public DataTable Localizar(int codigo)
        {
           if (codigo <= 0)
            {
                throw new Exception("BLL Ordem Produção, Localizar - \n O código da ordem é necessária");
            }

            DALOrdemProducao DALObj = new DALOrdemProducao(conexao);
            return DALObj.Localizar(codigo);
        }

        public DataTable Localizar()
        {
            DALOrdemProducao DALObj = new DALOrdemProducao(conexao);
            return DALObj.Localizar();
        }

        public ModeloOrdemProducao CarregaOrdemProducao(int codigo)
        {
            if (codigo <= 0)
            {
                throw new Exception("DAL Ordem Produção, Carrega Ordem Produção - \n O código da ordem é necessária");
            }

            DALOrdemProducao DALObj = new DALOrdemProducao(conexao);
            return DALObj.CarregaOrdemProducao(codigo);
        }

        public void Excluir(int odpCod)
        {
            DALOrdemProducao DALObj = new DALOrdemProducao(conexao);
            DALObj.Excluir(odpCod);
        }

        public void AtualizaStatus(ModeloOrdemProducao modelo)
        {
            DALOrdemProducao DALObj = new DALOrdemProducao(conexao);
            DALObj.AtualizaStatus(modelo);
        }

        public void FinalizaOrdem(ModeloOrdemProducao modelo)
        {
            DALOrdemProducao DALObj = new DALOrdemProducao(conexao);
            DALObj.FinalizaOrdem(modelo);
        }
    }
}
