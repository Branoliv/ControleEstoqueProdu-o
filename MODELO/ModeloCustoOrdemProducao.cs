using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloCustoOrdemProducao
    {
        public ModeloCustoOrdemProducao()
        {
            this._cat_cod = 0;
            this._scat_cod = 0;
            this._cop_cstoteorico = 0;
            this._cop_cstreal = 0;
            this._odp_cod = 0;
            this._ico_cod = 0;
        }

        public ModeloCustoOrdemProducao(int cat_cod, int scat_cod, double cop_cstoteorico, double cop_cstreal, int odp_cod,int ico_cod)
        {
            this._cat_cod = cat_cod;
            this._scat_cod = scat_cod;
            this._cop_cstoteorico = cop_cstoteorico;
            this._cop_cstreal = cop_cstreal;
            this._odp_cod = odp_cod;
            this._ico_cod = ico_cod;
        }

        private int _cat_cod;
        public int CatCod
        {
            get { return this._cat_cod; }
            set { this._cat_cod = value; }
        }

        private int _scat_cod;
        public int Scatcod
        {
            get { return this._scat_cod; }
            set { this._scat_cod = value; }
        }

        private double _cop_cstoteorico;
        public double CopCstTeorico
        {
            get { return this._cop_cstoteorico; }
            set { this._cop_cstoteorico = value; }
        }

        private double _cop_cstreal;
        public double CopCstReal
        {
            get { return this._cop_cstreal; }
            set { this._cop_cstreal = value; }
        }

        private int _odp_cod;
        public int OdpCod
        {
            get { return this._odp_cod; }
            set { this._odp_cod = value; }
        }

        private int _ico_cod;
        public int IcoCod
        {
            get { return this._ico_cod; }
            set { this._ico_cod = value; }
        }
    }
}
