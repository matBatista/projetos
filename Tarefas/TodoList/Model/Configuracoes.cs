using MySql.Data.MySqlClient;
using System;
using System.ComponentModel.DataAnnotations;

namespace TodoList.Model
{
    public class Configuracoes
    {
        public Configuracoes()
        {
            Nullable<DateTime> date = null;
            this.versaoSistema = "";
            this.linhaConexao = "Database=sistemas;Data Source=localhost; User Id=admin;Password=adm2556;SslMode=Required";
            this.idUsuarioLogado = 0;
        }

        public static string LINHACONEXAO = "linhaConexao";
        [Display(Name = "linhaConexao", Description = "", AutoGenerateField = true)]
        public string linhaConexao { get; set; }

        public static string VERSAOSISTEMA = "versaoSistema";
        [Display(Name = "versaoSistema", Description = "", AutoGenerateField = true)]
        public String versaoSistema { get; set; }


        public static string IDUSUARIOLOGADO = "idUsuarioLogado";
        [Display(Name = "idUsuarioLogado", Description = "", AutoGenerateField = true)]
        public int idUsuarioLogado { get; set; }

    }
}