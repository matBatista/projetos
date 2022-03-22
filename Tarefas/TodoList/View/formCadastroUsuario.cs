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
    public partial class formCadastroUsuario : DevExpress.XtraEditors.XtraForm
    {
        public formCadastroUsuario()
        {
            InitializeComponent();
        }

        private void sbtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void sbtnCadastro_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }

        public void Cadastrar()
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;
            string senhaAuth = textEdit1.Text;

            if (usuario == "")
            {
                XtraMessageBox.Show("DIGITAR O USUARIO");
                return;
            }

            if (senha != senhaAuth)
            {
                XtraMessageBox.Show("SENHAS DIGITADAS NAO CONFEREM");
                return;
            }

            Controller.Usuario controller = new Controller.Usuario(usuario, senha);

            if (controller.validarUsuario())
            {
                XtraMessageBox.Show("USUARIO JA CADASTRADO");
                return;
            }

            string resp = "";
            bool ret = false;

            (ret, resp) = controller.inserir();

            XtraMessageBox.Show(resp);

            if (ret)
            {
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void CadastroUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.No)
            {
                if (XtraMessageBox.Show("Deseja Cancelar o Cadastro?", "Cadastro",MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}