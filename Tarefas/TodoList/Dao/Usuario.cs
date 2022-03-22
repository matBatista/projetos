using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.Dao
{
    public class Usuario
    {
        MySqlConnection conexao = new MySqlConnection(Controller.Configuracoes.config.linhaConexao);
        public Usuario() 
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
        public void insert(Model.Usuario dados)
        {
            AbrirFecharConexao(true);

            MySqlCommand comando = new MySqlCommand();

            comando.Connection = conexao;
            comando.CommandType = CommandType.Text;

            comando.Parameters.Add("@usuario", MySqlDbType.VarChar);
            comando.Parameters.Add("@senha", MySqlDbType.VarChar);
            comando.Parameters.Add("@chaveAcesso", MySqlDbType.VarChar);

            comando.Parameters["@usuario"].Value = dados.usuario;
            comando.Parameters["@senha"].Value = dados.senha;

            comando.CommandText = "insert into tb_usuario(usuario,senha) Values (@usuario,@senha)";
            comando.ExecuteNonQuery();
        }
        public void update(Model.Usuario dados)
        {
            AbrirFecharConexao(true);

            MySqlCommand comando = new MySqlCommand();

            comando.Connection = conexao;
            comando.CommandType = CommandType.Text;

            comando.Parameters.Add("@id", MySqlDbType.Int32);
            comando.Parameters.Add("@usuario", MySqlDbType.VarChar);
            comando.Parameters.Add("@senha", MySqlDbType.VarChar);

            comando.Parameters["@id"].Value = dados.id;
            comando.Parameters["@usuario"].Value = dados.usuario;
            comando.Parameters["@senha"].Value = dados.senha;
            
            comando.CommandText = "UPDATE tb_usuario SET usuario=@usuario, senha = @senha WHERE id = @id";
            comando.ExecuteNonQuery();
        }
        public Model.Usuario getUsuario(string usuario)
        {
            AbrirFecharConexao(true);

            String sqlString = "SELECT id,usuario, senha FROM tb_usuario where usuario=@usuario";

            MySqlCommand comando = new MySqlCommand(sqlString, conexao);

            comando.CommandTimeout = 500;
            comando.Parameters.Add("@usuario", MySqlDbType.VarChar);
            comando.Parameters["@usuario"].Value = usuario;
            
            Model.Usuario user = new Model.Usuario();

            using (var mySqlDataReader = (MySqlDataReader)comando.ExecuteReader())
            {
                while (mySqlDataReader.Read())
                {
                    int i = -1;
                    if (!mySqlDataReader.IsDBNull(++i)) user.id = mySqlDataReader.GetFieldValue<int>(i);
                    if (!mySqlDataReader.IsDBNull(++i)) user.usuario = mySqlDataReader.GetFieldValue<string>(i).ToUpper();
                    if (!mySqlDataReader.IsDBNull(++i)) user.senha = mySqlDataReader.GetFieldValue<string>(i);
                }
            }
            return user;
        }



    }
}
