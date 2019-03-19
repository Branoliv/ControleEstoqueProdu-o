using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using MODELO;
using System.Data;

namespace BLL
{
    public class BLLTipoProduto
    {
        private DALConexao conexao;

        public BLLTipoProduto(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloTipoProduto modelo)
        {
            if (modelo.TppDescricao.Trim().Length.Equals(0))
            {
                throw new Exception("BLLTipoProduto, Incluir \nNecessário informar a descrição do tipo de produto.");
            }

            if (modelo.TppAbrev.Trim().Length.Equals(0))
            {
                throw new Exception("BLLTipoProduto, Incluir \nNecessário informar a abreviação do tipo de produto.");
            }

            DALTipoProduto DALObj = new DALTipoProduto(conexao);
            DALObj.Incluir(modelo);
        }

        public void Alterar(ModeloTipoProduto modelo)
        {
            if(modelo.TppCod <= 0)
            {
                throw new Exception("BLLTipProduto, Alterar \nNecessário informar o código do tipo de produto.");
            }

            if (modelo.TppDescricao.Trim().Length.Equals(0))
            {
                throw new Exception("BLLTipoProduto, Alterar \nNecessário informar a descrição do tipo de produto.");
            }

            if (modelo.TppAbrev.Trim().Length.Equals(0))
            {
                throw new Exception("BLLTipoProduto, Alterar \nNecessário informar a abreviação do tipo de produto.");
            }

            DALTipoProduto DALObj = new DALTipoProduto(conexao);
            DALObj.Incluir(modelo);

        }

        public DataTable Localizar()
        {
            DALTipoProduto DALObj = new DALTipoProduto(conexao);
            return DALObj.Localizar();
        }

        public DataTable Localizar(String valor)
        {
            if (valor.Trim().Length.Equals(0))
            {
                throw new Exception("BLLTipoProduto, Incluir \nNecessário informar a descrição do tipo de produto.");
            }

            DALTipoProduto DALObj = new DALTipoProduto(conexao);
            return DALObj.Localizar(valor);
        }

        public void Excluir(int codigo)
        {
            DALTipoProduto DALObj = new DALTipoProduto(conexao);
            DALObj.Excluir(codigo);
        }

        public ModeloTipoProduto CarregaTipoProduto(int codigo)
        {
            DALTipoProduto DALObj = new DALTipoProduto(conexao);
            return DALObj.CarregaTipoProduto(codigo);
        }
    }
}
