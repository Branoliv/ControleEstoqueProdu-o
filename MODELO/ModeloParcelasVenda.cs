using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloParcelasVenda
    {
        public ModeloParcelasVenda()
        {
            this.PveCod = 0;
            this.PveValor = 0;
           // this.PveDtPagto = DateTime.Now;
            this.PveDtVecto = DateTime.Now;
            this.VenCod = 0;
        }

        public ModeloParcelasVenda(int pvecod, double pveValor, DateTime pveDtpagto, DateTime pveDtvecto, int vencod)
        {
            this.PveCod = pvecod;
            this.PveValor = pveValor;
           // this.PveDtPagto = pveDtpagto;
            this.PveDtVecto = pveDtvecto;
            this.VenCod = vencod;
        }


        private int _pve_cod;
        public int PveCod
        {
            get { return this._pve_cod; }
            set { this._pve_cod = value; }
        }

        private double _pve_valor;
        public double PveValor
        {
            get { return this._pve_valor; }
            set { this._pve_valor = value; }
        }

        private DateTime _pve_datapagto;
        public DateTime PveDtPagto
        {
            get { return this._pve_datapagto; }
            set { this._pve_datapagto = value; }
        }

        private DateTime _pve_datavecto;
        public DateTime PveDtVecto
        {
            get { return this._pve_datavecto; }
            set { this._pve_datavecto = value; }
        }

        private int _ven_cod;
        public int VenCod
        {
            get { return this._ven_cod; }
            set { this._ven_cod = value; }
        }
    }
}
