using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloPedidoVenda
    {
        public ModeloPedidoVenda()
        {
            this.PedCod =0 ;
            this.CliCod = 0;
            this.PedData = DateTime.Now;
            this.PedTotal = 0;
            this.PedStatus = 0;
            this.PedDtEntrega = DateTime.Now;
        }


        public ModeloPedidoVenda(int pedCod, int cliCod, DateTime pedData, double pedTotal, int pedStatus, DateTime dtEntrega)
        {
            this.PedCod = pedCod;
            this.CliCod = cliCod;
            this.PedData = pedData;
            this.PedTotal = pedTotal;
            this.PedStatus = pedStatus;
            this.PedDtEntrega = dtEntrega;
        }

        private int _ped_cod;
        public int PedCod
        {
            get { return this._ped_cod; }
            set { this._ped_cod = value; }
        }

        private int _cli_cod;
        public int CliCod
        {
            get { return this._cli_cod; }
            set { this._cli_cod = value; }
        }

        private DateTime _ped_data;
        public DateTime PedData
        {
            get { return this._ped_data; }
            set { this._ped_data = value; }
        }

        private double _ped_total;
        public double PedTotal
        {
            get { return this._ped_total; }
            set { this._ped_total = value; }
        }

        private int _ped_status;
        public int PedStatus
        {
            get { return this._ped_status; }
            set { this._ped_status = value; }
        }

        private DateTime _ped_dtentrega;
        public DateTime PedDtEntrega
        {
            get { return this._ped_dtentrega; }
            set { this._ped_dtentrega = value; }
        }

    }
}
