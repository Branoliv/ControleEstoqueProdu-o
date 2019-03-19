using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloItensPlanoProducao
    {
        public ModeloItensPlanoProducao()
        {
            this.IppCod = 0;
            this.ProCod = 0;
            this.IppQtde = 0;
            this.PlpCod = 0;
            this.IppDeposito = "";
        }


        public ModeloItensPlanoProducao(int ipp_cod , int pro_cod  , double ipp_qtde, int umed_cod, int plp_cod, string ipp_deposito)
        {
            this.IppCod = _ipp_cod;
            this.ProCod = _pro_cod;
            this.IppQtde = _ipp_qtde;
            this.PlpCod = _plp_cod;
            this.IppDeposito = ipp_deposito;
        }


        private int _ipp_cod;
        public int IppCod
        {
            get { return this._ipp_cod; }
            set { this._ipp_cod = value; }
        }

        private int _pro_cod;
        public int ProCod
        {
            get { return this._pro_cod; }
            set { this._pro_cod = value; }
        }

        private double _ipp_qtde;
        public double IppQtde
        {
            get { return this._ipp_qtde; }
            set { this._ipp_qtde = value; }
        }

        private int _plp_cod;
        public int PlpCod
        {
            get { return this._plp_cod; }
            set { this._plp_cod = value; }
        }

        private string _ipp_deposito;
        public string IppDeposito
        {
            get { return this._ipp_deposito; }
            set { this._ipp_deposito = value; }
        }

    }
}
