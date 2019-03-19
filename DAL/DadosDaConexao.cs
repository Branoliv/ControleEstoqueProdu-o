using System;

namespace DAL
{
    public class DadosDaConexao
    {
        public static String servidor = "";
        public static String banco = "";
        public static String usuario = "";
        public static String senha = "";

        //public static String servidor = "192.168.1.8";
        //public static String banco = "ControleDeEstoque";
        //public static String usuario = "DBCadEstq";
        //public static String senha = "123";

        public static String StringDeConexao
        {
            get
            {
                return "Data Source=" + servidor + ";Initial Catalog=" + banco  +";User Id=" + usuario + ";Password=" + senha;
            }
        }
    }
}
