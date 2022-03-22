using System;
using System.ComponentModel.DataAnnotations;

namespace TodoList.Model
{
    public class Tarefas
    {
        public Tarefas()
        {
            Nullable<DateTime> date = null;
            this.id = 0;
            this.idUsuario = 0;
            this.titulo= "";
            this.descricao = "";
            this.dataCriacao = date;
            this.dataInicio = date;
            this.dataFinal = date;
            this.prazo = date;
            this.nomeUsuario = "";
        }

        public static string ID = "id";
        [Display(Name = "id", Description = "", AutoGenerateField = true)]
        public int id { get; set; }

        public static string IDUSUARIO = "idUsuario";
        [Display(Name = "idUsuario", Description = "", AutoGenerateField = true)]
        public int idUsuario { get; set; }

        public static string NOMEUSUARIO = "nomeUsuario";
        [Display(Name = "nomeUsuario", Description = "", AutoGenerateField = true)]
        public string nomeUsuario { get; set; }

        public static string TITULO = "titulo";
        [Display(Name = "titulo", Description = "", AutoGenerateField = true)]
        public String titulo { get; set; }

        public static string DESCRICAO = "descricao";
        [Display(Name = "descricao", Description = "", AutoGenerateField = true)]
        public String descricao { get; set; }

        public static string DATACRIACAO = "dataCriacao";
        [Display(Name = "dataCriacao", Description = "", AutoGenerateField = true)]
        public DateTime? dataCriacao { get; set; }

        public static string PRAZO = "prazo";
        [Display(Name = "prazo", Description = "", AutoGenerateField = true)]
        public DateTime? prazo { get; set; }

        public static string DATAINICIO = "dataInicio";
        [Display(Name = "dataInicio", Description = "", AutoGenerateField = true)]
        public DateTime? dataInicio { get; set; }

        public static string DATAFINAL = "dataFinal";
        [Display(Name = "dataFinal", Description = "", AutoGenerateField = true)]
        public DateTime? dataFinal { get; set; }

    }
}
