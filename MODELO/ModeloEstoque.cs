using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloEstoque
    {
        public ModeloEstoque()
        {
            this.ProdCod = 0;
            this.EstSaldo = 0;
            this.EstTm = 0;
            this.DepAbrev = "";
            this.CstMedio = 0;
            this.VlrEstq = 0;
            this.CstMedioAt = 0;
            this.EstSaldoRevservado = 0;
            this.EstSaldoBloqueado = 0;
        }

        public ModeloEstoque(int estcod, double saldo, int esttm, String Deposito, double vlrmedio, double vlrestq, double vlrmedioat, double saldoResevado, double saldoBloq )
        {
            this.ProdCod = estcod;
            this.EstSaldo = saldo;
            this.EstTm = esttm;
            this.DepAbrev = Deposito;
            this.CstMedio = vlrmedio;
            this.VlrEstq = vlrestq;
            this.CstMedioAt = vlrmedioat;
            this.EstSaldoRevservado = saldoResevado;
            this.EstSaldoBloqueado = saldoBloq;
        }

        private int prod_cod;
        public int ProdCod
        {
            get { return this.prod_cod; }
            set { this.prod_cod = value; }
        }

        private double est_saldo;
        public double EstSaldo
        {
            get { return this.est_saldo; }
            set { this.est_saldo = value; }
        }

        private String dep_abrev;
        public String DepAbrev
        {
            get { return this.dep_abrev; }
            set { this.dep_abrev = value; }
        }

        private int est_tm;
        public int EstTm
        {
            get { return this.est_tm; }
            set { this.est_tm = value; }
        }

        private double est_cstmedio;
        public double CstMedio
        {
            get { return this.est_cstmedio; }
            set { this.est_cstmedio = value; }
        }

        private double est_vlrestq;
        public double VlrEstq
        {
            get { return this.est_vlrestq; }
            set { this.est_vlrestq = value; }
        }

        private double est_cstmedioat;
        public double CstMedioAt
        {
            get { return this.est_cstmedioat; }
            set { this.est_cstmedioat = value; }
        }

        private double est_saldoreservado;
        public double EstSaldoRevservado
        {
            get { return this.est_saldoreservado; }
            set { this.est_saldoreservado = value; }
        }

        private double est_saldobloqueado;
        public double EstSaldoBloqueado
        {
            get { return this.est_saldobloqueado; }
            set { this.est_saldobloqueado = value; }
        }
    }
}
