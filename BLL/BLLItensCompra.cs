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
    public class BLLItensCompra
    {
        private DALConexao conexao;

        public BLLItensCompra(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloItensCompra modelo)
        {
            if (modelo.ComCod <= 0)
            {
                throw new Exception("O código da compra é obrigatório");
            }

            if (modelo.ItcQtde <= 0)
            {
                throw new Exception("Informe uma quantidade válida.");
            }

            if (modelo.ItcValor <= 0)
            {
                throw new Exception("Informe o valor do item.");
            }

            if (modelo.ProCod <= 0)
            {
                throw new Exception("O código do produto é obrigatório.");
            }

            if (modelo.DepCod.Trim().Length == 0)
            {
                throw new Exception("O depósito de destino é obrigatório.");
            }

            if(modelo.ItcStatus < 0)
            {
                throw new Exception("Status não informado.");
            }

            DALItensCompra DALobj = new DALItensCompra(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloItensCompra modelo)
        {
            if (modelo.ComCod <= 0)
            {
                throw new Exception("BLLItensCompra - O código da compra é obrigatório");
            }

            if (modelo.ItcQtde <= 0)
            {
                throw new Exception("BLLItensCompra - Informe uma quantidade válida.");
            }

            if (modelo.ItcCod <= 0)
            {
                throw new Exception("BLLItensCompra - Informe o código do item.");
            }

            if (modelo.ItcValor <= 0)
            {
                throw new Exception("BLLItensCompra - Informe o valor do item.");
            }

            if (modelo.ProCod <= 0)
            {
                throw new Exception("BLLItensCompra - BLLItensCompra - O código do produto é obrigatório.");
            }

            if (modelo.DepCod.Trim().Length == 0)
            {
                throw new Exception("BLLItensCompra - O depósito de destino é obrigatório.");
            }

            if (modelo.ItcStatus < 0)
            {
                throw new Exception("BLLItensCompra - Status não informado.");
            }

            DALItensCompra DALobj = new DALItensCompra(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(ModeloItensCompra modelo)
        {
            if (modelo.ComCod <= 0)
            {
                throw new Exception("O código da compra é obrigatório");
            }

            if (modelo.ItcCod <= 0)
            {
                throw new Exception("Informe o código do item.");
            }

            if (modelo.ProCod <= 0)
            {
                throw new Exception("O código do produto é obrigatório.");
            }

            DALItensCompra DALobj = new DALItensCompra(conexao);
            DALobj.Excluir(modelo);
        }

        public DataTable Localizar(int comcod)
        {
            DALItensCompra DALobj = new DALItensCompra(conexao);
            return DALobj.Localizar(comcod);
        }

        public ModeloItensCompra CarregaModeloItensCompra(int ItcCod, int ComCod, int ProCod)
        {
            DALItensCompra DALobj = new DALItensCompra(conexao);
            return DALobj.CarregaModeloItensCompra(ItcCod, ComCod, ProCod);
        }

        public ModeloItensCompra CarregaModeloItensCompra(int ComCod)
        {
            DALItensCompra DALobj = new DALItensCompra(conexao);
            return DALobj.CarregaModeloItensCompra(ComCod);
        }

        public void Estorno(ModeloItensCompra modelo)
        {
            if (modelo.ComCod <= 0)
            {
                throw new Exception("BLLItensCompra - O código da compra é obrigatório");
            }

            if (modelo.ItcQtde <= 0)
            {
                throw new Exception("BLLItensCompra - Informe uma quantidade válida.");
            }

            if (modelo.ItcCod <= 0)
            {
                throw new Exception("BLLItensCompra - Informe o código do item.");
            }

            if (modelo.ItcValor <= 0)
            {
                throw new Exception("BLLItensCompra - Informe o valor do item.");
            }

            if (modelo.ProCod <= 0)
            {
                throw new Exception("BLLItensCompra - O código do produto é obrigatório.");
            }

            if (modelo.DepCod.Trim().Length == 0)
            {
                throw new Exception("BLLItensCompra - O depósito de destino é obrigatório.");
            }

            if (modelo.ItcStatus < 0)
            {
                throw new Exception("BLLItensCompra - Status não informado.");
            }

            DALItensCompra DALobj = new DALItensCompra(conexao);
            DALobj.Estorno(modelo);
        }

    }
}
