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
    public class BLLEstoque
    {
        private DALConexao conexao;

        public BLLEstoque(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloEstoque modelo)
        {            
            DALEstoque DALobj = new DALEstoque(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloEstoque modelo)
        {            
            DALEstoque DALobj = new DALEstoque(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int Codigo)
        {
            DALEstoque DALobj = new DALEstoque(conexao);
            DALobj.Excluir(Codigo);
        }

        public DataTable Localizar(int codigo)
        {
            DALEstoque DALobj = new DALEstoque(conexao);
            return DALobj.Localizar(codigo);
        }

        public ModeloEstoque CarregaModeloEstoque(int codigo)
        {
            DALEstoque DALobj = new DALEstoque(conexao);
            return DALobj.CarregaModeloEstoque(codigo);
        }

        public void AtualizaEstoque(ModeloEstoque modelo)
        {
            if(modelo.EstTm <= 0)
            {
                throw new Exception("O tipo de movimento (TM) é obrigatório");
            }

            DALEstoque DALobj = new DALEstoque(conexao);
            DALobj.AtualizaEstoque(modelo);
        }

        public void VerificaSaldoNegativo(ModeloEstoque modelo)
        {           
            DALEstoque DALobj = new DALEstoque(conexao);
            DALobj.VerificaSaldoNegativo(modelo);
        }

        public void incluirReservaEstq(ModeloEstoque modelo)
        {
            DALEstoque DALobj = new DALEstoque(conexao);
            DALobj.incluirReservaEstq(modelo);
        }

        public void Reserva(ModeloEstoque modelo)
        {
            DALEstoque DALobj = new DALEstoque(conexao);
            DALobj.Reserva(modelo);
        }
    }
}
