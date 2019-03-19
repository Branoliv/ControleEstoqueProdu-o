using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloCliente //clitipo 0->fisica 1->juridica
    {
        public ModeloCliente()
        {
            this.CliCod = 0;
            this.CliNome = "";
            this.CliCpfCnpj ="";
            this.CliRgIe = "";
            this.CliRzSocial ="";
            this.CliTipo = 0;
            this.CliCep = "";
            this.CliEndereco = "";
            this.CliBairro = "";
            this.CliFone = "";
            this.CliCelular = "";
            this.CliEmail = "";
            this.CliEndNumero = "";
            this.CliCidade = "";
            this.CliEstado = "";
            this.CliObservacao = "";
        }

        public ModeloCliente(int clicod, String nome, String clicpfcnpj, String clirgie, String clirzsocial, 
            int clitipo, String clicep, String cliendereco, String clibairro, String clifone, String clicelular,
            String cliemail,String cliendnumero, String clicidade, String cliestado, String cliobservacao )
        {
            this.CliCod = clicod;
            this.CliNome = nome;
            this.CliCpfCnpj = clicpfcnpj;
            this.CliRgIe = clirgie;
            this.CliRzSocial = clirzsocial;
            this.CliTipo = clitipo;
            this.CliCep = clicep;
            this.CliEndereco = cliendereco;
            this.CliBairro = clibairro;
            this.CliFone = clifone;
            this.CliCelular = clicelular;
            this.CliEmail = cliemail;
            this.CliEndNumero = cliendnumero;
            this.CliCidade = clicidade;
            this.CliEstado = cliestado;
            this.CliObservacao = cli_observacao;
        }

        private int cli_cod;
        public int CliCod
        {
            get { return this.cli_cod; }
            set { this.cli_cod = value; }
        }

        private String cli_nome;
        public String CliNome
        {
            get { return this.cli_nome; }
            set { this.cli_nome = value; }
        }

        private String cli_cpfcnpj;
        public String CliCpfCnpj
        {
            get { return this.cli_cpfcnpj; }
            set { this.cli_cpfcnpj = value; }
        }

        private String cli_rgie;
        public String CliRgIe
        {
            get { return this.cli_rgie; }
            set { this.cli_rgie = value; }
        }

        private String cli_rzsocial;
        public String CliRzSocial
        {
            get { return this.cli_rzsocial; }
            set { this.cli_rzsocial = value; }
        }

        private int cli_tipo;
        public int CliTipo
        {
            get { return this.cli_tipo; }
            set { this.cli_tipo = value; }
        }

        private String cli_cep;
        public String CliCep
        {
            get { return this.cli_cep; }
            set { this.cli_cep = value; }
        }

        private String cli_endereco;
        public String CliEndereco
        {
            get { return this.cli_endereco; }
            set { this.cli_endereco = value; }
        }

        private String cli_bairro;
        public String CliBairro
        {
            get { return this.cli_bairro; }
            set { this.cli_bairro = value; }
        }

        private String cli_fone;
        public String CliFone
        {
            get { return this.cli_fone; }
            set { this.cli_fone = value; }
        }

        private String cli_celular;
        public String CliCelular
        {
            get { return this.cli_celular; }
            set { this.cli_celular = value; }
        }

        private String cli_email;
        public String CliEmail
        {
            get { return this.cli_email; }
            set { this.cli_email = value; }
        }

        private String cli_endnumero;
        public String CliEndNumero
        {
            get { return this.cli_endnumero; }
            set { this.cli_endnumero = value; }
        }

        private String cli_cidade;
        public String CliCidade
        {
            get { return this.cli_cidade; }
            set { this.cli_cidade = value; }
        }

        private String cli_estado;
        public String CliEstado
        {
            get { return this.cli_estado; }
            set { this.cli_estado = value; }
        }

        private String cli_observacao;
        public String CliObservacao
        {
            get { return this.cli_observacao; }
            set { this.cli_observacao = value; }
        }
    }
}
