using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloPlanoProducao
    {
        public ModeloPlanoProducao()
        {
            this.PlpCod = 0;
            this.Procod = 0;
            this.PlpQtde = 0;
            this.UmdeCod = 0;
        }

        public ModeloPlanoProducao(int plp_cod, int pro_cod, double plp_qtde, int umde_cod )
        {
            this.PlpCod = plp_cod;
            this.Procod = pro_cod;
            this.PlpQtde = plp_qtde;
            this.UmdeCod = umde_cod;
        }

        private int _plp_cod;
        public int PlpCod
        {
            get { return this._plp_cod; }
            set { this._plp_cod = value; }
        }

        private int _pro_cod;
        public int Procod
        {
            get { return this._pro_cod; }
            set { this._pro_cod = value; }
        }

        private double _plp_qtde;
        public double PlpQtde
        {
            get { return this._plp_qtde; }
            set { this._plp_qtde = value; }
        }

        private int _umde_cod;
        public int UmdeCod
        {
            get { return this._umde_cod; }
            set { this._umde_cod = value; }
        }
    }
}
