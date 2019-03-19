using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloItensDeposito
    {
        public ModeloItensDeposito()
        {
            this.DepCodProd = 0;
            this.DepProdAbrev = "";            
        }

        public ModeloItensDeposito(int dep_codprod, String _dep_prodabrev)
        {
            this.DepCodProd = dep_codprod;
            this.DepProdAbrev = _dep_prodabrev;            
        }

        private int dep_codprod;
        public int DepCodProd
        {
            get { return this.dep_codprod; }
            set { this.dep_codprod = value; }
        }

        private String dep_prodabrev;
        public String DepProdAbrev
        {
            get { return this.dep_prodabrev; }
            set { this.dep_prodabrev = value; }
        }
    }
}
