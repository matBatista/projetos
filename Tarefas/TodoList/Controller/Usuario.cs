using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.Controller
{
    public class Usuario
    {
        Dao.Usuario data;

        string usuario = "", senha = "";
        public Model.Usuario user = new Model.Usuario();
        public Usuario(string usuario, string senha)
        {
            this.usuario = usuario.ToUpper();
            this.senha = senha;

            this.data = new Dao.Usuario();
        }
      
        public void getUsuarioByUser(string usuario)
        {
            user = data.getUsuario(usuario);
        }
        public bool validarUsuario()
        {
            getUsuarioByUser(usuario);
            
            if(user.id > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool validaSenha()
        {
            senha = criptografarEmSHA256(senha);

            if (user.senha == senha)
                return true;
            else
                return false;
        }
        public (bool,string) inserir()
        {
            user = new Model.Usuario();

            user.usuario = usuario;
            user.senha = criptografarEmSHA256(senha);


            string resp = "";
            bool ret = true;

            try
            {
                data.insert(user);
                ret = true;
                resp = "Usuario Cadastrado com Sucesso!";
            }
            catch(Exception ex)
            {
                ret = false;
                resp = "Erro no Cadastro do Usuario" + Environment.NewLine + ex.Message.ToString();
            }

            return (ret, resp);
        }

        public static string criptografarEmSHA256(string dados)
        {
            HashAlgorithm _algoritmo = SHA256.Create();
            var encodedValue = Encoding.UTF8.GetBytes(dados);
            var encryptedPassword = _algoritmo.ComputeHash(encodedValue);

            var sb = new StringBuilder();
            foreach (var caracter in encryptedPassword)
            {
                sb.Append(caracter.ToString("X2"));
            }

            return sb.ToString();
        }
    }
}
