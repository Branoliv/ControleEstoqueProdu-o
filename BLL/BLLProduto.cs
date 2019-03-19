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
    public class BLLProduto
    {
        private DALConexao conexao;
        public BLLProduto(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloProduto obj)
        {
            if (obj.ProdCodBarra.Length > 14)
            {
                throw new Exception("Estouro de campo.");
            }

            if (obj.ProdNome.Trim().Length == 0)
            {
                throw new Exception("O nome do Produto é obrigatório.");
            }
            obj.ProdNome = obj.ProdNome.ToUpper();

            if (obj.ProdDescricao.Trim().Length == 0)
            {
                throw new Exception("O descrição do Produto é obrigatório.");
            }
            obj.ProdNome = obj.ProdNome.ToUpper();

            if (obj.ProdValorvenda  <= 0)
            {
                throw new Exception("O valor de venda do produto é obrigatório.");
            }

            if (obj.ProdQtde < 0)
            {
                throw new Exception("O quantidade do produto deve ser maior ou igual a zero.");
            }

            if (obj.CatCodigo < 0)
            {
                throw new Exception("O grupo do produto é obrigatório.");
            }

            if (obj.ScatCodigo < 0)
            {
                throw new Exception("O sub grupo do produto é obrigatório.");
            }

            if(obj.UmedCodigo <= 0)
            {
                throw new Exception("Unidade de medida é obrigatória.");
            }

            if(obj.TppCodigo <= 0)
            {
                throw new Exception("Tipo de produto é obrigatório.");
            }

            DALProduto DALobj = new DALProduto(conexao);
            DALobj.Incluir(obj);
        }

        public void Alterar(ModeloProduto obj)
        {
            if (obj.ProdCodigo <= 0)
            {
                throw new Exception("O código do produto é obrigatório.");
            }

            if (obj.ProdCodBarra.Length > 14)
            {
                throw new Exception("Estouro de campo.");
            }

            if (obj.ProdNome.Trim().Length == 0)
            {
                throw new Exception("O nome do Produto é obrigatório.");
            }
            obj.ProdNome = obj.ProdNome.ToUpper();

            if (obj.ProdDescricao.Trim().Length == 0)
            {
                throw new Exception("O descrição do Produto é obrigatório.");
            }
            obj.ProdNome = obj.ProdNome.ToUpper();

            if (obj.ProdValorvenda <= 0)
            {
                throw new Exception("O valor de venda do produto é obrigatório.");
            }

            if (obj.ProdQtde < 0)
            {
                throw new Exception("O quantidade do produto deve ser maior ou igual a zero.");
            }

            if (obj.CatCodigo < 0)
            {
                throw new Exception("O grupo do produto é obrigatório.");
            }

            if (obj.ScatCodigo < 0)
            {
                throw new Exception("O sub grupo do produto é obrigatório.");
            }

            if (obj.TppCodigo <= 0)
            {
                throw new Exception("Tipo de produto é obrigatório.");
            }

            DALProduto DALobj = new DALProduto(conexao);
            DALobj.Alterar(obj);
        }

        public void Excluir(int Codigo)
        {
            DALProduto DALobj = new DALProduto(conexao);
            DALobj.Excluir(Codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALProduto DALobj = new DALProduto(conexao);
            return DALobj.Localizar(valor);
        }

        public DataTable LocalizarPesqSimples(String valor)
        {
            DALProduto DALobj = new DALProduto(conexao);
            return DALobj.LocalizarPesqSimples(valor);
        }

        public DataTable LocalizarCodigoBarras(String valor)
        {
            DALProduto DALobj = new DALProduto(conexao);
            return DALobj.LocalizarCodigoBarras(valor);
        }

        public ModeloProduto CarregaModeloProduto(int codigo)
        {
            DALProduto DALobj = new DALProduto(conexao);
            return DALobj.CarregaModeloProduto(codigo);
        }

        public ModeloProduto CarregaModeloProdutoCodBarras(String codbarras)
        {
            DALProduto DALobj = new DALProduto(conexao);
            return DALobj.CarregaModeloProdutoCodBarras(codbarras);
        }

        public void AtualizaCusto(ModeloProduto modelo)
        {
            if (modelo.ProdValorpago < 0)
            {
                throw new Exception("O custo do produto é obrigatorio.");
            }

            DALProduto DALobj = new DALProduto(conexao);
            DALobj.Alterar(modelo);
        }
    }
}

