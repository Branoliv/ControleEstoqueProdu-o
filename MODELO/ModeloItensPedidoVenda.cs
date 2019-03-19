using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloItensPedidoVenda
    {

        public ModeloItensPedidoVenda()
        {
            this.IpvCod = 0;
            this.PedCod = 0;
            this.ProCod = 0;
            this.IpvQtde = 0;
            this.IpvValor = 0;
            this.IpvStatus = 0;
            this.IpvDep = string.Empty;
        }

        public ModeloItensPedidoVenda(int ipvCod, int pedCod, int proCod, double ipvQtde, double ipvValor, int ipvStatus, string ipv_dep)
        {
            this.IpvCod = ipvCod;
            this.PedCod = pedCod;
            this.ProCod = proCod;
            this.IpvQtde = ipvQtde;
            this.IpvValor = ipvValor;
            this.IpvStatus = ipvStatus;
            this.IpvDep = ipv_dep;
        }

        private int _ipv_cod;
        public int IpvCod
        {
            get { return this._ipv_cod; }
            set { this._ipv_cod = value; }
        }

        private int _ped_cod;
        public int PedCod
        {
            get { return this._ped_cod; }
            set { this._ped_cod = value; }
        }

        private int _pro_cod;
        public int ProCod
        {
            get { return this._pro_cod; }
            set { this._pro_cod = value; }
        }

        private double _ipv_qtde;
        public double IpvQtde
        {
            get { return this._ipv_qtde; }
            set { this._ipv_qtde = value; }
        }

        private double _ipv_valor;
        public  double IpvValor
        {
            get { return this._ipv_valor; }
            set { this._ipv_valor = value;  }
        }

        private int _ipv_status;
        public int IpvStatus
        {
            get { return this._ipv_status; }
            set { this._ipv_status = value; }
        }

        private string _ipv_dep;
        public string IpvDep
        {
            get { return this._ipv_dep; }
            set { this._ipv_dep = value; }
        }
    }
}
