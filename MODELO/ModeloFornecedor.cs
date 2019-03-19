using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloFornecedor
    {
        public ModeloFornecedor()
        {
            this.ForCod = 0;
            this.ForNome = "";
            this.ForCnpj = "";
            this.ForIe = "";
            this.ForRzSocial = "";           
            this.ForCep = "";
            this.ForEndereco = "";
            this.ForBairro = "";
            this.ForFone = "";
            this.ForCelular = "";
            this.ForEmail = "";
            this.ForEndNumero = "";
            this.ForCidade = "";
            this.ForEstado = "";
            this.ForObservacao = "";
        }

        public ModeloFornecedor(int forcod, String nome, String forcnpj, String forie, String forrzsocial,
            String forcep, String forendereco, String forbairro, String forfone, String forcelular,
            String foremail, String forendnumero, String forcidade, String forestado, String observacao)
        {
            this.ForCod = forcod;
            this.ForNome = nome;
            this.ForCnpj = forcnpj;
            this.ForIe = forie;
            this.ForRzSocial = forrzsocial;
            this.ForCep = forcep;
            this.ForEndereco = forendereco;
            this.ForBairro = forbairro;
            this.ForFone = forfone;
            this.ForCelular = forcelular;
            this.ForEmail = foremail;
            this.ForEndNumero = forendnumero;
            this.ForCidade = forcidade;
            this.ForEstado = forestado;
            this.ForObservacao = observacao;
        }

        private int for_cod;
        public int ForCod
        {
            get { return this.for_cod; }
            set { this.for_cod = value; }
        }

        private String for_nome;
        public String ForNome
        {
            get { return this.for_nome; }
            set { this.for_nome = value; }
        }

        private String for_cnpj;
        public String ForCnpj
        {
            get { return this.for_cnpj; }
            set { this.for_cnpj = value; }
        }

        private String for_ie;
        public String ForIe
        {
            get { return this.for_ie; }
            set { this.for_ie = value; }
        }

        private String for_rzsocial;
        public String ForRzSocial
        {
            get { return this.for_rzsocial; }
            set { this.for_rzsocial = value; }
        }
      
        private String for_cep;
        public String ForCep
        {
            get { return this.for_cep; }
            set { this.for_cep = value; }
        }

        private String for_endereco;
        public String ForEndereco
        {
            get { return this.for_endereco; }
            set { this.for_endereco = value; }
        }

        private String for_bairro;
        public String ForBairro
        {
            get { return this.for_bairro; }
            set { this.for_bairro = value; }
        }

        private String for_fone;
        public String ForFone
        {
            get { return this.for_fone; }
            set { this.for_fone = value; }
        }

        private String for_celular;
        public String ForCelular
        {
            get { return this.for_celular; }
            set { this.for_celular = value; }
        }

        private String for_email;
        public String ForEmail
        {
            get { return this.for_email; }
            set { this.for_email = value; }
        }

        private String for_endnumero;
        public String ForEndNumero
        {
            get { return this.for_endnumero; }
            set { this.for_endnumero = value; }
        }

        private String for_cidade;
        public String ForCidade
        {
            get { return this.for_cidade; }
            set { this.for_cidade = value; }
        }

        private String for_estado;
        public String ForEstado
        {
            get { return this.for_estado; }
            set { this.for_estado = value; }
        }

        private String for_observacao;
        public String ForObservacao
        {
            get { return this.for_observacao; }
            set { this.for_observacao = value; }
        }
    }
}
