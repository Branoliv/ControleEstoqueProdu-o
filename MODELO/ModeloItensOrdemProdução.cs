using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloItensOrdemProdução
    {
        private int _iop_cod;
        public int Iopcod
        {
            get { return this._iop_cod; }
            set { this._iop_cod = value; }
        }

        private int _pro_cod;
        public int Procod
        {
            get { return this._pro_cod; }
            set { this._pro_cod = value; }
        }

        private double _iop_qtdplano;
        public double IopQtdPlano
        {
            get { return this._iop_qtdplano; }
            set { this._iop_qtdplano = value; }
        }

        private double _iop_qtdreal;
        public double IopQtdReal
        {
            get { return this._iop_qtdreal; }
            set { this._iop_qtdreal = value; }
        }

        private int _iop_status;
        public int IopStatus
        {
            get { return this._iop_status; }
            set { this._iop_status = value; }
        }

        private int _odp_cod;
        public int OdpCod
        {
            get { return this._odp_cod; }
            set { this._odp_cod = value; }
        }

    }
}
