using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.Dao
{
    class Tarefas
    {
        MySqlConnection conexao = new MySqlConnection(Controller.Configuracoes.config.linhaConexao);
        public Tarefas()
        {
            AbrirFecharConexao(false);
        }

        public void AbrirFecharConexao(bool state)
        {
            if (state)
            {
                if (conexao != null && conexao.State != System.Data.ConnectionState.Open)
                    conexao.Open();
            }
            else
            {
                if (conexao != null)
                    conexao.Close();
            }
        }
        public void insert(Model.Tarefas dados)
        {
            AbrirFecharConexao(true);

            MySqlCommand comando = new MySqlCommand();

            comando.Connection = conexao;
            comando.CommandType = CommandType.Text;

            comando.Parameters.Add("@idUsuario", MySqlDbType.Int32);
            comando.Parameters.Add("@titulo", MySqlDbType.VarChar);
            comando.Parameters.Add("@descricao", MySqlDbType.VarChar);
            comando.Parameters.Add("@dataCriacao", MySqlDbType.DateTime);
            comando.Parameters.Add("@prazo", MySqlDbType.DateTime);
            comando.Parameters.Add("@dataInicio", MySqlDbType.DateTime);
            comando.Parameters.Add("@dataFinal", MySqlDbType.DateTime);

            comando.Parameters["@idUsuario"].Value = dados.idUsuario;
            comando.Parameters["@titulo"].Value = dados.titulo;
            comando.Parameters["@descricao"].Value = dados.descricao;
            comando.Parameters["@dataCriacao"].Value = dados.dataCriacao;
            comando.Parameters["@prazo"].Value = dados.prazo;
            comando.Parameters["@dataInicio"].Value = dados.dataInicio;
            comando.Parameters["@dataFinal"].Value = dados.dataFinal;

            comando.CommandText = "insert into tb_tarefas(idUsuario,titulo,descricao,dataCriacao,prazo,dataInicio,dataFinal) Values (@idUsuario,@titulo,@descricao,@dataCriacao,@prazo,@dataInicio,@dataFinal)";
            comando.ExecuteNonQuery();
        }
        public void update(Model.Tarefas dados)
        {
            AbrirFecharConexao(true);

            MySqlCommand comando = new MySqlCommand();

            comando.Connection = conexao;
            comando.CommandType = CommandType.Text;

            comando.Parameters.Add("@id", MySqlDbType.Int32);
            comando.Parameters.Add("@idUsuario", MySqlDbType.Int32);
            comando.Parameters.Add("@titulo", MySqlDbType.VarChar);
            comando.Parameters.Add("@descricao", MySqlDbType.VarChar);
            comando.Parameters.Add("@dataCriacao", MySqlDbType.DateTime);
            comando.Parameters.Add("@prazo", MySqlDbType.DateTime);
            comando.Parameters.Add("@dataInicio", MySqlDbType.DateTime);
            comando.Parameters.Add("@dataFinal", MySqlDbType.DateTime);

            comando.Parameters["@id"].Value = dados.id;
            comando.Parameters["@idUsuario"].Value = dados.idUsuario;
            comando.Parameters["@titulo"].Value = dados.titulo;
            comando.Parameters["@descricao"].Value = dados.descricao;
            comando.Parameters["@dataCriacao"].Value = dados.dataCriacao;
            comando.Parameters["@prazo"].Value = dados.prazo;
            comando.Parameters["@dataInicio"].Value = dados.dataInicio;
            comando.Parameters["@dataFinal"].Value = dados.dataFinal;

            comando.CommandText = "UPDATE tb_tarefas SET idUsuario=@idUsuario,titulo=@titulo,descricao=@descricao,dataCriacao=@dataCriacao,prazo=@prazo,dataInicio=@dataInicio,dataFinal=@dataFinal WHERE id = @id";
            comando.ExecuteNonQuery();
        }
        public Model.Tarefas getTarefa(int idTarefa)
        {
            AbrirFecharConexao(true);

            String sqlString = "SELECT id,idUsuario,titulo,descricao,dataCriacao,prazo,dataInicio,dataFinal FROM tb_tarefas where id = @id";

            MySqlCommand comando = new MySqlCommand(sqlString, conexao);

            comando.CommandTimeout = 500;
            comando.Parameters.Add("@id", MySqlDbType.Int32);
            comando.Parameters["@id"].Value = idTarefa;

            Model.Tarefas tarefa = new Model.Tarefas();

            using (var mySqlDataReader = (MySqlDataReader)comando.ExecuteReader())
            {
                while (mySqlDataReader.Read())
                {
                    int i = -1;
                    if (!mySqlDataReader.IsDBNull(++i)) tarefa.id = mySqlDataReader.GetFieldValue<int>(i);
                    if (!mySqlDataReader.IsDBNull(++i)) tarefa.idUsuario = mySqlDataReader.GetFieldValue<int>(i);
                    if (!mySqlDataReader.IsDBNull(++i)) tarefa.titulo = mySqlDataReader.GetFieldValue<string>(i).ToUpper();
                    if (!mySqlDataReader.IsDBNull(++i)) tarefa.descricao = mySqlDataReader.GetFieldValue<string>(i);
                    if (!mySqlDataReader.IsDBNull(++i)) tarefa.dataCriacao = mySqlDataReader.GetFieldValue<DateTime>(i);
                    if (!mySqlDataReader.IsDBNull(++i)) tarefa.prazo = mySqlDataReader.GetFieldValue<DateTime>(i);
                    if (!mySqlDataReader.IsDBNull(++i)) tarefa.dataInicio = mySqlDataReader.GetFieldValue<DateTime>(i);
                    if (!mySqlDataReader.IsDBNull(++i)) tarefa.dataFinal = mySqlDataReader.GetFieldValue<DateTime>(i);
                }
            }
            return tarefa;
        }
        public int selecionarUltimaTarefa()
        {
            AbrirFecharConexao(true);

            String sqlString = "CALL selecionarUltimaTarefa();";

            MySqlCommand comando = new MySqlCommand(sqlString, conexao);

            comando.CommandTimeout = 500;

            int id = 0;

            using (var mySqlDataReader = (MySqlDataReader)comando.ExecuteReader())
            {
                while (mySqlDataReader.Read())
                {
                    int i = -1;

                    if (!mySqlDataReader.IsDBNull(++i)) id = mySqlDataReader.GetFieldValue<int>(i);
                }
            }
            return id;
        }


        public BindingList<Model.Tarefas> getListaTarefas()
        {
            string sqlQuery = "";

            if(Controller.Configuracoes.config.idUsuarioLogado > 1)
                sqlQuery = "WHERE idUsuario = " + Controller.Configuracoes.config.idUsuarioLogado;

            AbrirFecharConexao(true);

            String sqlString = "SELECT id,idUsuario,(select usuario from tb_usuario where tb_usuario.id = idUsuario) as usuario,titulo,descricao,dataCriacao,prazo,dataInicio,dataFinal FROM tb_tarefas " + sqlQuery;

            MySqlCommand comando = new MySqlCommand(sqlString, conexao);
            comando.CommandTimeout = 500;

            BindingList<Model.Tarefas> listaTarefas = new BindingList<Model.Tarefas>();

            using (var mySqlDataReader = (MySqlDataReader)comando.ExecuteReader())
            {
                while (mySqlDataReader.Read())
                {
                    int i = -1;

                    Model.Tarefas tarefa = new Model.Tarefas();
                    
                    if (!mySqlDataReader.IsDBNull(++i)) tarefa.id = mySqlDataReader.GetFieldValue<int>(i);
                    if (!mySqlDataReader.IsDBNull(++i)) tarefa.idUsuario = mySqlDataReader.GetFieldValue<int>(i);
                    if (!mySqlDataReader.IsDBNull(++i)) tarefa.nomeUsuario = mySqlDataReader.GetFieldValue<string>(i);
                    if (!mySqlDataReader.IsDBNull(++i)) tarefa.titulo = mySqlDataReader.GetFieldValue<string>(i).ToUpper();
                    if (!mySqlDataReader.IsDBNull(++i)) tarefa.descricao = mySqlDataReader.GetFieldValue<string>(i);
                    if (!mySqlDataReader.IsDBNull(++i)) tarefa.dataCriacao = mySqlDataReader.GetFieldValue<DateTime>(i);
                    if (!mySqlDataReader.IsDBNull(++i)) tarefa.prazo = mySqlDataReader.GetFieldValue<DateTime>(i);
                    if (!mySqlDataReader.IsDBNull(++i)) tarefa.dataInicio = mySqlDataReader.GetFieldValue<DateTime>(i);
                    if (!mySqlDataReader.IsDBNull(++i)) tarefa.dataFinal = mySqlDataReader.GetFieldValue<DateTime>(i);

                    listaTarefas.Add(tarefa);
                }
            }
            
            return listaTarefas;
        }

    }
}
