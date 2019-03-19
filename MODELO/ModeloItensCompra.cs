using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloItensCompra
    {
        public ModeloItensCompra()
        {
            this.ItcCod = 0;
            this.ItcQtde = 0;
            this.ItcValor = 0;
            this.ComCod = 0;
            this.ProCod = 0;
            this.DepCod = "";
            this.ItcStatus = 0;
        }

        public ModeloItensCompra(int _ItcCod, double _ItcQtde,double _ItcValor, int _ComCod, int _ProCod, string _dep_cod, int _itc_status)
        {
            this.ItcCod = _ItcCod;
            this.ItcQtde = _ItcQtde;
            this.ItcValor = _ItcValor;
            this.ComCod = _ComCod;
            this.ProCod = _ProCod;
            this.DepCod = _dep_cod;
            this.ItcStatus = _itc_status;
        }

        private int itc_cod;

        public int ItcCod
        {
            get { return this.itc_cod; }
            set { this.itc_cod = value; }
        }

        private double itc_qtde;

        public double ItcQtde
        {
            get { return this.itc_qtde; }
            set { this.itc_qtde = value; }
        }

        private double itc_valor;

        public double ItcValor
        {
            get { return this.itc_valor; }
            set { this.itc_valor = value; }
        }

        private int com_cod;

        public int ComCod
        {
            get { return this.com_cod; }
            set { this.com_cod = value; }
        }

        private int pro_cod;

        public int ProCod
        {
            get { return this.pro_cod; }
            set { this.pro_cod = value; }
        }

        private string dep_cod;

        public string DepCod
        {
            get { return this.dep_cod; }
            set { this.dep_cod = value; }
        }

        private int itc_status;
        public int ItcStatus
        {
            get { return this.itc_status; }
            set { this.itc_status = value; }
        }
    }
}
