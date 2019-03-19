using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloCompra
    {
        public ModeloCompra()
        {
            this.ComCod = 0;
            this.ComData = DateTime.Now;
            this.ComNFiscal = 0;
            this.ComTotal = 0;
            this.ComNParcelas = 0;
            this.ComStatus = 0;
            this.ForCod = 0;
            this.TpaCod = 0;
            this.DepProd = 0;
            this.TpMovimento = 0;
        }

        public ModeloCompra(int comCod, DateTime data, int nFiscal, double total,
            int nParcelas, int status, int forCod, int tpaCod, int dep_prod, int tpmov)
        {
            this.ComCod = comCod;
            this.ComData = data;
            this.ComNFiscal = nFiscal;
            this.ComTotal = total;
            this.ComNParcelas = nParcelas;
            this.ComStatus = status;
            this.ForCod = forCod;
            this.TpaCod = tpaCod;
            this.DepProd = dep_prod;
            this.TpMovimento = tpmov;
        }


        private int _com_cod;
        public int ComCod
        {
            get { return this._com_cod; }
            set { this._com_cod = value; }
        }

        private DateTime _com_data;
        public DateTime ComData
        {
            get { return this._com_data; }
            set { this._com_data = value; }
        }

        private int _com_nfiscal;
        public int ComNFiscal
        {
            get { return this._com_nfiscal; }
            set { this._com_nfiscal = value; }
        }

        private double _com_total;
        public double ComTotal
        {
            get {  return this._com_total; }
            set { this._com_total = value; }
        }

        private int _com_nparcalas;
        public int ComNParcelas
        {
            get { return this._com_nparcalas; }
            set { this._com_nparcalas = value; }
        }

        private int _com_status;
        public int ComStatus
        {
            get { return this._com_status; }
            set { this._com_status = value; }
        }

        private int _for_cod;
        public int ForCod
        {
            get { return this._for_cod; }
            set { this._for_cod = value; }
        }

        private int _tpa_cod;
        public int TpaCod
        {
            get { return this._tpa_cod; }
            set { this._tpa_cod = value; }
        }

        private int _dep_prod;
        public int DepProd
        {
            get { return this._dep_prod; }
            set { this._dep_prod = value; }
        }

        private int _tp_Movimento;
        public int TpMovimento
        {
            get { return this._tp_Movimento; }
            set { this._tp_Movimento = value; }
        }
    }
}
