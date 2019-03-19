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
    public class BLLCustoOrdemProducao
    {
        private DALConexao conexao;

        public BLLCustoOrdemProducao(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCustoOrdemProducao modelo)
        {
            DALCustoOrdemProducao DALObj = new DALCustoOrdemProducao(conexao);
            DALObj.Incluir(modelo);
        }

        public DataTable Localizar(int odpCod)
        {
            DALCustoOrdemProducao DALObj = new DALCustoOrdemProducao(conexao);
            return DALObj.Localizar(odpCod);
        }

        public DataTable recuperaCusto(int proCod)
        {
            DALCustoOrdemProducao DALObj = new DALCustoOrdemProducao(conexao);
            return DALObj.recuperaCusto(proCod);
        }

        public DataTable Grupo(int catCod, int scatCod)
        {
            DALCustoOrdemProducao DALObj = new DALCustoOrdemProducao(conexao);
            return DALObj.Grupo(catCod, scatCod);
        }

        public bool ContemItem(int odpCod, int icoCod)
        {
            DALCustoOrdemProducao DALObj = new DALCustoOrdemProducao(conexao);
            return DALObj.ContemItem(odpCod,icoCod);
        }

        public void Excluir(int proCod)
        {
            DALCustoOrdemProducao DALObj = new DALCustoOrdemProducao(conexao);
            DALObj.Excluir(proCod);
        }

        public void Apontamento(ModeloCustoOrdemProducao modelo)
        {
            DALCustoOrdemProducao DALObj = new DALCustoOrdemProducao(conexao);
            DALObj.Apontamento(modelo);
        }

    }
}
