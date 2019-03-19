using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloItensOrdemProducao
    {

        public ModeloItensOrdemProducao()
        {
            this.Iopcod = 0;
            this.ProCod = 0;
            this.IopQtdPlano = 0;
            this.IopQtdReal = 0;
            this.IopStatus = 0;
            this.OdpCod = 0;
            this.IopDeposito = "";
        }

        public ModeloItensOrdemProducao(int iop_cod, int pro_cod, double iop_qtdplano, double iop_qtdreal, int iop_status, int odp_cod, string iop_deposito)
        {
            this.Iopcod = iop_cod;
            this.ProCod = pro_cod;
            this.IopQtdPlano = iop_qtdplano;
            this.IopQtdReal = iop_qtdreal;
            this.IopStatus = iop_status;
            this.OdpCod = odp_cod;
            this.IopDeposito = iop_deposito;
        }

        private int _iop_cod;
        public int Iopcod
        {
            get { return this._iop_cod; }
            set { this._iop_cod = value; }
        }

        private int _pro_cod;
        public int ProCod
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

        private string _iop_deposito;
        public string IopDeposito
        {
            get { return this._iop_deposito; }
            set { this._iop_deposito = value; }
        }

    }
}
