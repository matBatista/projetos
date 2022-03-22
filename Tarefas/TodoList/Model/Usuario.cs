using System;
using System.ComponentModel.DataAnnotations;

namespace TodoList.Model
{
    public class Usuario
    {
        public Usuario()
        {
            Nullable<DateTime> date = null;
            this.id = 0;
            this.usuario = "";
            this.senha = "";
            this.chaveAcesso = "";
        }

        public static string ID = "id";
        [Display(Name = "id", Description = "", AutoGenerateField = true)]
        public int id { get; set; }

        public static string USUARIO = "usuario";
        [Display(Name = "usuario", Description = "", AutoGenerateField = true)]
        public String usuario { get; set; }

        public static string SENHA = "senha";
        [Display(Name = "senha", Description = "", AutoGenerateField = true)]
        public String senha { get; set; }


        public static string CHAVE = "chave";
        [Display(Name = "chave", Description = "", AutoGenerateField = true)]
        public String chaveAcesso { get; set; }
    }
}
