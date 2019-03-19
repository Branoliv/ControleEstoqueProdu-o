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
    public class BLLPlanoProducao
    {
        private DALConexao conexao;

        public BLLPlanoProducao(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloPlanoProducao modelo)
        {
            if (modelo.Procod <= 0)
            {
                throw new Exception("O código do produto é obrigatório");
            }

            if (modelo.PlpQtde <= 0)
            {
                throw new Exception("Informe uma quantidade válida.");
            }

            if (modelo.UmdeCod < 0)
            {
                throw new Exception("Informe o valor do item.");
            }

            DALPlanoProducao DALobj = new DALPlanoProducao(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloPlanoProducao modelo)
        {
            if (modelo.PlpCod <= 0)
            {
                throw new Exception("O código do plano é obrigatório");
            }

            if (modelo.Procod <= 0)
            {
                throw new Exception("O código do produto é obrigatório");
            }

            if (modelo.PlpQtde <= 0)
            {
                throw new Exception("Informe uma quantidade válida.");
            }

            if (modelo.UmdeCod < 0)
            {
                throw new Exception("Informe o valor do item.");
            }

            DALPlanoProducao DALobj = new DALPlanoProducao(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALPlanoProducao DALobj = new DALPlanoProducao(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(int codigo)
        {
            DALPlanoProducao DALobj = new DALPlanoProducao(conexao);
            return DALobj.Localizar(codigo);
        }

        public ModeloPlanoProducao CarregaModeloPlanoProducao(int plpCod)
        {
            DALPlanoProducao DALobj = new DALPlanoProducao(conexao);
            return DALobj.CarregaModeloPlanoProducao(plpCod);
        }

        public DataTable LocalizarItemPlano(int codigo)
        {
            DALPlanoProducao DALobj = new DALPlanoProducao(conexao);
            return DALobj.LocalizarItemPlano(codigo);
        }
    }
}
