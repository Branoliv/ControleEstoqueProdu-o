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
    public class BLLItensPlanoProducao
    {
        private DALConexao conexao;

        public BLLItensPlanoProducao(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloItensPlanoProducao modelo)
        {
            if (modelo.PlpCod <= 0)
            {
                throw new Exception("BLL Itens Plano Producao, Incluir - O código do plano é obrigatório");
            }

            if (modelo.ProCod <= 0)
            {
                throw new Exception("BLL Itens Plano Producao, Incluir - O código do produto é obrigatório");
            }

            if (modelo.IppQtde <= 0)
            {
                throw new Exception("BLL Itens Plano Producao, Incluir - Informe uma quantidade válida.");
            }

            DALItensPlanoProducao DALobj = new DALItensPlanoProducao(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloItensPlanoProducao modelo)
        {
            if (modelo.PlpCod <= 0)
            {
                throw new Exception("BLLItensPlanoProducao, Alterar - O código do plano é obrigatório");
            }

            if (modelo.ProCod <= 0)
            {
                throw new Exception("BLLItensPlanoProducao, Alterar - O código do produto é obrigatório");
            }

            if (modelo.IppQtde <= 0)
            {
                throw new Exception("BLLItensPlanoProducao, Alterar - Informe uma quantidade válida.");
            }

            DALItensPlanoProducao DALobj = new DALItensPlanoProducao(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(ModeloItensPlanoProducao modelo)
        {
            DALItensPlanoProducao DALobj = new DALItensPlanoProducao(conexao);
            DALobj.Excluir(modelo);
        }

        public void ExcluirItem(ModeloItensPlanoProducao modelo)
        {
            DALItensPlanoProducao DALobj = new DALItensPlanoProducao(conexao);
            DALobj.ExcluirItem(modelo);
        }

        public DataTable Localizar(int codigo)
        {
            if (codigo <= 0)
            {
                throw new Exception("BLL Itens Plano Producao, Localizar - O código do plano é obrigatório");
            }

            DALItensPlanoProducao DALobj = new DALItensPlanoProducao(conexao);
            return DALobj.Localizar(codigo);
        }

        public ModeloItensPlanoProducao CarregaModeloItensPlanoProducao(int plpCod)
        {
            if (plpCod <= 0)
            {
                throw new Exception("BLLItensPlanoProducao, CarregaModeloItensPlanoProducao - O código do plano é obrigatório");
            }


            DALItensPlanoProducao DALobj = new DALItensPlanoProducao(conexao);
            return DALobj.CarregaModeloItensPlanoProducao(plpCod);
        }

        public DataTable LocalizarItem(int codigo, int item)
        {
            if (codigo <= 0)
            {
                throw new Exception("BLLItensPlanoProducao, Localizar - O código do plano é obrigatório");
            }

            if (item <= 0)
            {
                throw new Exception("BLLItensPlanoProducao, Localizar - O item do plano é obrigatório");
            }

            DALItensPlanoProducao DALobj = new DALItensPlanoProducao(conexao);
            return DALobj.LocalizarItem(codigo,item);
        }

    }
}
