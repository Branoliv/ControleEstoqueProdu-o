using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloVenda
    {
        public ModeloVenda()
        {
            this.VenCod = 0;
            this.VenData = DateTime.Now;
            this.VenNFiscal = 0;
            this.VenTotal = 0;
            this.VenNParcelas = 0;
            this.Status = 0;
            this.CliCod = 0;
            this.TpaCod = 0;
            this.TpMovimento = 0;
        }

        public ModeloVenda(int ven_cod, DateTime ven_data, int ven_nfiscal, Double ven_total, 
            int ven_nparcelas, int status, int cli_cod, int tpa_cod, int tp_Movimento )
        {
            this.VenCod = ven_cod;
            this.VenData = ven_data;
            this.VenNFiscal = ven_nfiscal;
            this.VenTotal = ven_total;
            this.VenNParcelas = ven_nparcelas;
            this.Status = status;
            this.CliCod = cli_cod;
            this.TpaCod = tpa_cod;
            this.TpMovimento = tp_Movimento;
        }

        private int _ven_cod;
        public int VenCod
        {
            get {return this._ven_cod; }
            set { this._ven_cod = value; }
        }

        private DateTime _ven_data;
        public DateTime VenData
        {
            get { return this._ven_data; }
            set { this._ven_data = value; }
        }

        private int _ven_nfiscal;
        public int VenNFiscal
        {
            get { return this._ven_nfiscal; }
            set { this._ven_nfiscal = value; }
        }

        private Double _ven_total;
        public Double VenTotal
        {
            get { return this._ven_total; }
            set { this._ven_total = value; }
        }

        private int _ven_nparcelas;
        public int VenNParcelas
        {
            get { return this._ven_nparcelas; }
            set { this._ven_nparcelas = value; }
        }

        private int _status;
        public int Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        private int _cli_cod;
        public int CliCod
        {
            get { return this._cli_cod; }
            set { this._cli_cod = value; }
        }

        private int _tpa_cod;
        public int TpaCod
        {
            get { return this._tpa_cod; }
            set { this._tpa_cod = value; }
        }

        private int _tp_Movimento;
        public int TpMovimento
        {
            get { return this._tp_Movimento; }
            set { this._tp_Movimento = value; }
        }
    }
}
