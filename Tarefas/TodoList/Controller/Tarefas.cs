using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.Controller
{
    public class Tarefas
    {
        Dao.Tarefas data;

        public Tarefas()
        {
            this.data = new Dao.Tarefas();
        }
      
        public Model.Tarefas getTarefaById(Int32 idTarefa)
        {
            return data.getTarefa(idTarefa);
        }
        public BindingList<Model.Tarefas> getListaTarefas()
        {
            return data.getListaTarefas();
        }
        public (bool,string, Model.Tarefas) insert( Model.Tarefas dados)
        {
            string resp = "";
            bool ret = true;

            Model.Tarefas tarefa = new Model.Tarefas();

            try
            {
                data.insert(dados);
                ret = true;
                resp = "Tarefa Criada com Sucesso!";

                int id = data.selecionarUltimaTarefa();
                tarefa = data.getTarefa(id);

            }
            catch(Exception ex)
            {
                ret = false;
                resp = "Erro ao Inserir Tarefa ao Usuario" + Environment.NewLine + ex.Message.ToString();
            }

            return (ret, resp, tarefa);
        }
        public (bool, string) update(Model.Tarefas dados)
        {
            string resp = "";
            bool ret = true;

            try
            {
                data.update(dados);
                ret = true;
                resp = "Tarefa Atualizada com Sucesso.";
            }
            catch (Exception ex)
            {
                ret = false;
                resp = "Erro ao Atualizar Tarefa." + Environment.NewLine + ex.Message.ToString();
            }

            return (ret, resp);
        }

    }
}
