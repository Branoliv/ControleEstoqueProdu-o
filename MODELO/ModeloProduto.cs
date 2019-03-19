using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloProduto
    {
        public ModeloProduto()
        {
            this.ProdCodigo = 0;
            this.ProdCodBarra = "";
            this.ProdNome = "";
            this.ProdDescricao = "";
           // this.ProdFoto = "";
            this.ProdValorpago = 0;
            this.ProdValorvenda = 0;
            this.ProdQtde = 0;
            this.UmedCodigo = 0;
            this.CatCodigo = 0;
            this.ScatCodigo = 0;
            this.ProdMargem = 0;
            this.ProdAtivo = "S";
            this.TppCodigo = 0;
        }

        public ModeloProduto(int prod_cod, String prod_nome, String prod_descricao,
            String prod_foto, Double prod_valorpago, Double prod_valorvenda, Double prod_qtde,
            int umed_cod, int cat_cod, int scat_cod, Double prod_margem, String prod_ativo, String prod_codbarra, int tpp_cod)
        {
            this.ProdCodigo = prod_cod;
            this.ProdNome = prod_nome;
            this.ProdDescricao = prod_descricao;
            this.CarregaIagem(prod_foto);
            this.ProdValorpago = prod_valorpago;
            this.ProdValorvenda = prod_valorvenda;
            this.ProdQtde = prod_qtde;
            this.UmedCodigo = umed_cod;
            this.CatCodigo = cat_cod;
            this.ScatCodigo = scat_cod;
            this.ProdMargem = prod_margem;
            this.ProdAtivo = prod_ativo;
            this.ProdCodBarra = prod_codbarra;
            this.TppCodigo = tpp_cod;
        }

         public ModeloProduto(int prod_cod, String prod_nome, String prod_descricao,
            Byte[] prod_foto, Double prod_valorpago, Double prod_valorvenda, Double prod_qtde,
            int umed_cod, int cat_cod, int scat_cod, Double prod_margem, String prod_ativo, String prod_codbarra)
        {
            this.ProdCodigo = prod_cod;
            this.ProdNome = prod_nome;
            this.ProdDescricao = prod_descricao;
            this.ProdFoto = prod_foto;
            this.ProdValorpago = prod_valorpago;
            this.ProdValorvenda = prod_valorvenda;
            this.ProdQtde = prod_qtde;
            this.UmedCodigo = umed_cod;
            this.CatCodigo = cat_cod;
            this.ScatCodigo = scat_cod;
            this.ProdMargem = prod_margem;
            this.ProdAtivo = prod_ativo;
            this.ProdCodBarra = prod_codbarra;
        }

        private int _prod_cod;
        public int ProdCodigo
        {
            get { return this._prod_cod; }
            set { this._prod_cod = value; }
        }

        private String _prod_nome;
        public String ProdNome
        {
            get { return this._prod_nome; }
            set { this._prod_nome = value; }
        }

        private String _prod_descricao;
        public String ProdDescricao
        {
            get { return this._prod_descricao; }
            set { this._prod_descricao = value; }
        }

        private byte[] _prod_foto;
        public byte[] ProdFoto
        {
            get { return this._prod_foto; }
            set { this._prod_foto = value; }
        }

        private Double _prod_margem;
        public Double ProdMargem
        {
            get { return this._prod_margem; }
            set { this._prod_margem = value; }
        }

        private String _prod_ativo;
        public String ProdAtivo
        {
            get { return this._prod_ativo; }
            set { this._prod_ativo = value; }
        }

        public void CarregaIagem(String imgCaminho)
        {
            try
            {
                if (String.IsNullOrEmpty(imgCaminho))
                    return;
                //fornece propriedade se métodos de instância para criar, copiar,
                //excluir, mover e abrir arquivos, e ajuda na criação de objetos FileStream
                FileInfo arqImagem = new FileInfo(imgCaminho);
                //Expõe um Stream ao redor de um arquivo de suporte
                //síncorno e assíncrono operaçõs de leitura e gravar.
                FileStream fs = new FileStream(imgCaminho, FileMode.Open, FileAccess.Read, FileShare.Read);
                //aloca memória para o vetor
                this.ProdFoto = new byte[Convert.ToInt32(arqImagem.Length)];
                //Lê um bloc de bytes do fluxo e grava os dados em um buffer fornecido.
                int iBytesRead = fs.Read(this.ProdFoto, 0, Convert.ToInt32(arqImagem.Length));
                fs.Close();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        private Double _prod_valorpago;
        public Double ProdValorpago
        {
            get { return this._prod_valorpago; }
            set { this._prod_valorpago = value; }
        }

        private Double _prod_valorvenda;
        public Double ProdValorvenda
        {
            get { return this._prod_valorvenda; }
            set { this._prod_valorvenda = value; }
        }

        private Double _prod_qtde;
        public Double ProdQtde
        {
            get { return this._prod_qtde; }
            set { this._prod_qtde = value; }
        }

        private int _umed_cod;
        public int UmedCodigo
        {
            get { return this._umed_cod; }
            set { this._umed_cod = value; }
        }

        private int _cat_cod;
        public int CatCodigo
        {
            get { return this._cat_cod; }
            set { this._cat_cod = value; }
        }

        private int _scat_cod;
        public int ScatCodigo
        {
            get { return this._scat_cod; }
            set { this._scat_cod = value; }
        }

        private String _prod_codbarra;

        public String ProdCodBarra
        {
            get { return this._prod_codbarra; }
            set { this._prod_codbarra = value; }
        }

        private int _tpp_cod;
        public int TppCodigo
        {
            get { return this._tpp_cod; }
            set { this._tpp_cod = value; }
        }
    }
}
