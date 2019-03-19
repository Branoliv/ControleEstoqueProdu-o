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
    public class BLLItensOrdemProducao
    {
        private DALConexao conexao;

        public BLLItensOrdemProducao(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloItensOrdemProducao modelo)
        {
            if (modelo.OdpCod <= 0)
            {
                throw new Exception("BLL Itens Ordem Producao, Incluir - O código da ordem é obrigatório");
            }

            if (modelo.ProCod <= 0)
            {
                throw new Exception("BLL Itens Ordem Producao, Incluir - O código do produto é obrigatório");
            }

            if (modelo.IopQtdPlano <= 0)
            {
                throw new Exception("BLL Itens Ordem Producao, Incluir - Informe uma quantidade válida.");
            }

            DALItensOrdemProducao DALobj = new DALItensOrdemProducao(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloItensOrdemProducao modelo)
        {
            if (modelo.OdpCod <= 0)
            {
                throw new Exception("BLLItensPlanoProducao, Alterar - O código da ordem é obrigatório");
            }

            if (modelo.ProCod <= 0)
            {
                throw new Exception("BLLItensPlanoProducao, Alterar - O código do produto é obrigatório");
            }

            if (modelo.IopQtdReal <= 0)
            {
                throw new Exception("BLLItensPlanoProducao, Alterar - Informe uma quantidade válida.");
            }

            DALItensOrdemProducao DALobj = new DALItensOrdemProducao(conexao);
            DALobj.Alterar(modelo);
        }

        public void Apontamento(ModeloItensOrdemProducao modelo)
        {
            DALItensOrdemProducao DALObj = new DALItensOrdemProducao(conexao);
            DALObj.Apontamento(modelo);
        }

        public DataTable Localizar(int codigo)
        {
            DALItensOrdemProducao DALobj = new DALItensOrdemProducao(conexao);
            return DALobj.Localizar(codigo);
        }

        public void ExcluirItem(int codigo)
        {
            DALItensOrdemProducao DALobj = new DALItensOrdemProducao(conexao);
            DALobj.ExcluirItem(codigo);
        }

        public void AtualizaStatus(ModeloItensOrdemProducao modelo)
        {
            DALItensOrdemProducao DALObj = new DALItensOrdemProducao(conexao);
            DALObj.AtualizaStatus(modelo);
        }
    }
}
