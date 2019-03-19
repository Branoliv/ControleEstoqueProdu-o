using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloTipoProduto
    {
        public  ModeloTipoProduto()
        {
            this.TppCod = 0;
            this.TppDescricao = "";
            this.TppAbrev = "";
        }

        public ModeloTipoProduto(int tppCod, string tppDesc, string tppAbrev)
        {
            this.TppCod = tppCod;
            this.TppDescricao = tppDesc;
            this.TppAbrev = tppAbrev;
        }

        private int _tpp_cod;
        public int TppCod
        {
            get { return this._tpp_cod; }
            set { this._tpp_cod = value; }
        }

        private string _tpp_descricao;
        public string TppDescricao
        {
            get { return this._tpp_descricao; }
            set { this._tpp_descricao = value; }
        }

        private string _tpp_Abrev;
        public string TppAbrev
        {
            get { return this._tpp_Abrev; }
            set { this._tpp_Abrev = value; }
        }
    }
}
