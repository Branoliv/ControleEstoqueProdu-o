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
    public class BLLItensPedidoVenda
    {
        private DALConexao conexao;

        public BLLItensPedidoVenda(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloItensPedidoVenda modelo)
        {
            if(modelo.IpvCod <= 0){
                throw new Exception("Nenhum item informado no pedido.");
            }
            if (modelo.ProCod <= 0)
            {
                throw new Exception("O código do produto é obrigatório");
            }

            if(modelo.PedCod  <= 0)
            {
                throw new Exception("O código do pedido é obrigatório");
            }

            if(modelo.IpvQtde <= 0)
            {
                throw new Exception("A quantidade não pode ser menor ou igual a zero.");
            }

            if(modelo.IpvValor <= 0)
            {
                throw new Exception("Necessário o valor diferente de zero.");
            }

            if (modelo.IpvDep.Equals(string.Empty))
            {
                throw new Exception("Necessário informa um depósito.");
            }

            DALItensPedidoVenda DALobj = new DALItensPedidoVenda(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloItensPedidoVenda modelo)
        {
            if (modelo.IpvCod <= 0)
            {
                throw new Exception("Nenhum item informado no pedido.");
            }
            if (modelo.ProCod <= 0)
            {
                throw new Exception("O código do produto é obrigatório");
            }

            if (modelo.PedCod <= 0)
            {
                throw new Exception("O código do pedido é obrigatório");
            }

            if (modelo.IpvQtde <= 0)
            {
                throw new Exception("A quantidade não pode ser menor ou igual a zero.");
            }

            if (modelo.IpvValor <= 0)
            {
                throw new Exception("Necessário o valor diferente de zero.");
            }

            if (modelo.IpvDep.Equals(string.Empty))
            {
                throw new Exception("Necessário informa um depósito.");
            }


            DALItensPedidoVenda DALobj = new DALItensPedidoVenda(conexao);
            DALobj.Alterar(modelo);
        }

        public DataTable Localizar(int codigo)
        {
            DALItensPedidoVenda DALobj = new DALItensPedidoVenda(conexao);
            return DALobj.Localizar(codigo);
        }

        public DataTable Localizar()
        {
            DALItensPedidoVenda DALobj = new DALItensPedidoVenda(conexao);
            return DALobj.Localizar();
        }

        public ModeloItensPedidoVenda CarregaModeloItensPedidoVenda(int codigo)
        {
            DALItensPedidoVenda DALobj = new DALItensPedidoVenda(conexao);
            return DALobj.CarregaModeloItensPedidoVenda(codigo);
        }

        public void CancelarPedido(ModeloItensPedidoVenda modelo)
        {
            DALItensPedidoVenda Dalobj = new DALItensPedidoVenda(conexao);
            Dalobj.CancelarPedido(modelo);
        }

        public DataTable LocalizarItem(int codigo, int item)
        {
            if (codigo <= 0)
            {
                throw new Exception("BLL Itens Pedido Venda, Localizar Item - O código do Pedido é obrigatório");
            }

            if (item <= 0)
            {
                throw new Exception("BLL Itens Pedido Venda, Localizar Item - O item do Pedido é obrigatório");
            }

            DALItensPedidoVenda DALobj = new DALItensPedidoVenda(conexao);
            return DALobj.LocalizarItem(codigo, item);
        }

        public void ExcluirItem(ModeloItensPedidoVenda modelo)
        {
            DALItensPedidoVenda DALobj = new DALItensPedidoVenda(conexao);
            DALobj.ExcluirItem(modelo);
        }

        public ModeloItensPedidoVenda ItemPedidoOrdemProducao(int codigo, int item)
        {
            DALItensPedidoVenda DALobj = new DALItensPedidoVenda(conexao);
            return DALobj.ItemPedidoOrdemProducao(codigo,item);
        }

        public void AtualizaStatus(ModeloItensPedidoVenda modelo)
        {
            DALItensPedidoVenda DALobj = new DALItensPedidoVenda(conexao);
            DALobj.AtualizaStatus(modelo);
        }

    }
}
