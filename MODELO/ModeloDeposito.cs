using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloDeposito
    {
        public ModeloDeposito()
        {
            this.DepCod = 0;
            this.DepAbrev = "";
            this.DepNome = "";
        }

        public ModeloDeposito(int _dep_cod, String _dep_abrev, String _dep_nome)
        {
            this.DepCod = _dep_cod;
            this.DepAbrev = _dep_abrev;
            this.DepNome = _dep_nome;
        }

        private int dep_cod;
        public int DepCod
        {
            get { return this.dep_cod; }
            set { this.dep_cod = value; }
        }

        private String dep_abrev;
        public String DepAbrev
        {
            get { return this.dep_abrev; }
            set { this.dep_abrev = value; }
        }

        private String dep_nome;
        public String DepNome
        {
            get { return this.dep_nome; }
            set { this.dep_nome = value; }
        }
    }
}
