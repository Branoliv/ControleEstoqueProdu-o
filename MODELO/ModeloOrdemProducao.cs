using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloOrdemProducao
    {
        public ModeloOrdemProducao()
        {
            this.OdpCod = 0;
            this.PedCod = 0;
            this.ProdCod = 0;
            this.OdpQtde = 0;
            this.OdpStatus = 1;
            this.IpvCod = 0;
        }

        public ModeloOrdemProducao(int odp_cod, int ped_cod, int prod_cod, int odp_qtde, int odp_status, int ipv_cod)
        {
            this.OdpCod = odp_cod;
            this.PedCod = ped_cod;
            this.ProdCod = prod_cod;
            this.OdpQtde = odp_qtde;
            this.OdpStatus = odp_status;
            this.IpvCod = ipv_cod;
        }

        private int _odp_cod;
        public int OdpCod
        {
            get { return this._odp_cod; }
            set { this._odp_cod = value; }
        }

        private int _ped_cod;
        public int PedCod
        {
            get { return this._ped_cod; }
            set { this._ped_cod = value; }
        }

        private int _prod_cod;
        public int ProdCod
        {
            get { return this._prod_cod; }
            set { this._prod_cod = value; }
        }

        private double _odp_qtde;
        public double OdpQtde
        {
            get { return this._odp_qtde; }
            set { this._odp_qtde = value; }
        }

        private int _odp_status;
        public int OdpStatus
        {
            get { return this._odp_status; }
            set { this._odp_status = value; }
        }

        private DateTime _odp_dtfinal;
        public DateTime OdpDtFinal
        {
            get { return this._odp_dtfinal; }
            set { this._odp_dtfinal = value; }
        }

        private int _ipv_cod;
        public int IpvCod
        {
            get { return this._ipv_cod; }
            set { this._ipv_cod = value; }
        }
    }
}
