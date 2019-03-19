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
    public class BLLPedidoVenda
    {
        private DALConexao conexao;

        public BLLPedidoVenda(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloPedidoVenda modelo)
        {
            if (modelo.CliCod < 0)
            {
                throw new Exception("O código do cliente é obrigatório");
            }

            if(modelo.PedData == null)
            {
                throw new Exception("A data do pedido é obrigatória.");
            }

            if (modelo.PedDtEntrega == null)
            {
                throw new Exception("A data de entrega é obrigatória.");
            }

            DALPedidoVenda DALobj = new DALPedidoVenda(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloPedidoVenda modelo)
        {
            if (modelo.PedCod <= 0)
            {
                throw new Exception("O código do pedido é obrigatório.");
            }
            if (modelo.CliCod < 0)
            {
                throw new Exception("O código do cliente é obrigatório");
            }

            if (modelo.PedData == null)
            {
                throw new Exception("A data do pedido é obrigatória.");
            }

            if (modelo.PedDtEntrega == null)
            {
                throw new Exception("A data de entrega é obrigatória.");
            }

            DALPedidoVenda DALobj = new DALPedidoVenda(conexao);
            DALobj.Alterar(modelo);
        }

        public DataTable Localizar(int codigo)
        {
            DALPedidoVenda DALobj = new DALPedidoVenda(conexao);
            return DALobj.Localizar(codigo);
        }

        public DataTable Localizar(DateTime dtincial, DateTime dtfinal)
        {
            DALPedidoVenda DALobj = new DALPedidoVenda(conexao);
            return DALobj.Localizar(dtincial, dtfinal);
        }

        public DataTable Localizar()
        {
            DALPedidoVenda DALobj = new DALPedidoVenda(conexao);
            return DALobj.Localizar();
        }

        public ModeloPedidoVenda CarregaModeloPedidoVenda(int codigo)
        {
            DALPedidoVenda DALobj = new DALPedidoVenda(conexao);
            return DALobj.CarregaModeloPedidoVenda(codigo);
        }

        public void AtualizaStatus(ModeloPedidoVenda modelo)
        {
            DALPedidoVenda Dalobj = new DALPedidoVenda(conexao);
            Dalobj.AtualizaStatus(modelo);
        }
    }
}
