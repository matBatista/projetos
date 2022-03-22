using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoList.View
{
    public partial class formLogin : DevExpress.XtraEditors.XtraForm
    {
        Model.Usuario user = new Model.Usuario();
        Controller.Usuario controllerUsuario;
        public formLogin()
        {
            InitializeComponent();
        }

        private void sbtnLogin_Click(object sender, EventArgs e)
        {
            EfetuaLogin();
        }
        private void formLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(13))
            {
                EfetuaLogin();
            }
            if(e.KeyChar == (char)(27))
            {
                this.Close();
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(13))
            {
                EfetuaLogin();
            }
            if (e.KeyChar == (char)(27))
            {
                this.Close();
            }
        }

        private void EfetuaLogin()
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (usuario == "")
            {
                XtraMessageBox.Show("Digitar Usuario.");
            }

            controllerUsuario = new Controller.Usuario(usuario, senha);

            if (controllerUsuario.validarUsuario())
            {
                if (controllerUsuario.validaSenha())
                {
                    user = controllerUsuario.user;

                    Controller.Configuracoes.config.idUsuarioLogado = user.id;
                    View.formGerenciarTarefas form = new formGerenciarTarefas();
                    form.ShowDialog();
                }
                else
                {
                    XtraMessageBox.Show("Combinação de Usuario e Senha Incorreta!");
                }
            }
            else
            {
                XtraMessageBox.Show("Usuario Inexistente.");
                
            }
        }

        private void txtUsuario_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            View.formCadastroUsuario formCadastro = new formCadastroUsuario();
            formCadastro.ShowDialog();
        }
    }
}