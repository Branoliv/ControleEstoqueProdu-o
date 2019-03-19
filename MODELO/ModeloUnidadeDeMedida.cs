using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloUnidadeDeMedida
    {
        public ModeloUnidadeDeMedida()
        {
            this.UmedCod = 0;
            this.UmedNome = "";
            this.UmedSimbolo = "";
        }

        public ModeloUnidadeDeMedida(int cod, String nome, String simbolo)
        {
            this.UmedCod = cod;
            this.UmedNome = nome;
            this.UmedSimbolo = simbolo;
        }


        private int umed_cod;
        public int UmedCod
        {
            get { return this.umed_cod; }
            set { this.umed_cod = value; }
        }

        private String umed_nome;
        public String UmedNome
        {
            get { return this.umed_nome; }
            set { this.umed_nome = value; }
        }

        private String umed_simbolo;
        public String UmedSimbolo
        {
            get { return this.umed_simbolo; }
            set { this.umed_simbolo = value; }
        }
    }
}

