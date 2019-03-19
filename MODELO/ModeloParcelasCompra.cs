using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloParcelasCompra
    {
        public ModeloParcelasCompra()
        {
            this.PcoCod = 0;
            this.PcoValor = 0;
            //this.PcoDtPagto = DateTime.Now;
            this.PcoDtVecto = DateTime.Now;
            this.ComCod = 0;
            this.PcoStatus = 0;
        }

        public ModeloParcelasCompra(int pcocod, double pcoValor, DateTime pcoDtpagto, DateTime pcoDtvecto, int comCod, int pcoStatus)
        {
            this.PcoCod = pcocod;
            this.PcoValor = pcoValor;
           // this.PcoDtPagto = pcoDtpagto;
            this.PcoDtVecto = pcoDtvecto;
            this.ComCod = comCod;
            this.PcoStatus = pcoStatus;
        }


        private int _pco_cod;
        public int PcoCod
        {
            get { return this._pco_cod; }
            set { this._pco_cod = value; }
        }

        private double _pco_valor;
        public double PcoValor
        {
            get { return this._pco_valor; }
            set { this._pco_valor = value; }
        }

        private DateTime _pco_datapagto;
        public DateTime PcoDtPagto
        {
            get { return this._pco_datapagto; }
            set { this._pco_datapagto = value; }
        }

        private DateTime _pco_datavecto;
        public DateTime PcoDtVecto
        {
            get { return this._pco_datavecto; }
            set { this._pco_datavecto = value; }
        }

        private int _com_cod;
        public int ComCod
        {
            get { return this._com_cod; }
            set { this._com_cod = value; }
        }

        private int pco_status;
        public int PcoStatus
        {
            get { return this.pco_status; }
            set { this.pco_status = value; }
        }
    }
}
