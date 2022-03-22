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
    public partial class formTarefa : DevExpress.XtraEditors.XtraForm
    {

        Controller.Tarefas controller = new Controller.Tarefas();
        Model.Tarefas tarefa = new Model.Tarefas();
        public formTarefa(int id = 0)
        {
            InitializeComponent();

            CarregaTarefa(id);

            validaCampos();

        }
        private void CarregaTarefa(int id)
        {
            tarefa = controller.getTarefaById(id);

            this.Text = "Tarefa [ " + tarefa.id + " ]";
            txtTitulo.Text = tarefa.titulo;
            txtDescricao.Text = tarefa.descricao;
            dtePrazo.EditValue = tarefa.prazo;
        }
        private void Salvar(bool msg = false)
        {
            string resp = "";
            bool ret = false;

            if (tarefa.id > 0)
            {
                (ret, resp) = controller.update(tarefa);
            }
            else
            {
                (ret, resp, tarefa) = controller.insert(tarefa);
            }

            if (!ret)
                XtraMessageBox.Show(resp);
            else
            {
                this.Text = "Tarefa [ " + tarefa.id + " ]";

                if(msg)
                    XtraMessageBox.Show(resp);
            }

            validaCampos();
        }
        private void validaCampos()
        {
            if (tarefa.id > 0)
            {
                sbtnFinalizar.Visible = true;
                sbtnIniciar.Visible = true;
                dtePrazo.Enabled = false;

                if (tarefa.dataInicio != null)
                    sbtnIniciar.Enabled = false;

                if (tarefa.dataFinal != null)
                    sbtnFinalizar.Enabled = false;
            }
            else
            {
                sbtnFinalizar.Visible = false;
                sbtnIniciar.Visible = false;
                dtePrazo.Enabled = true;
            }
        }
        private void CadastroUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(tarefa.id > 0)
                Salvar();
        }

        private void sbtnSalvar_Click(object sender, EventArgs e)
        {
            tarefa.idUsuario = Controller.Configuracoes.config.idUsuarioLogado;
            tarefa.dataCriacao = DateTime.Now;
            tarefa.titulo = txtTitulo.Text;
            tarefa.descricao = txtDescricao.Text;
            tarefa.prazo = Convert.ToDateTime(dtePrazo.EditValue);

            if (dtePrazo.EditValue == null)
            {
                XtraMessageBox.Show("Informar um Prazo!");
                return;
            }


            Salvar(true);
        }

        private void sbtnIniciar_Click(object sender, EventArgs e)
        {
            tarefa.dataInicio = DateTime.Now;
            Salvar();
        }

        private void sbtnFinalizar_Click(object sender, EventArgs e)
        {
            tarefa.dataFinal = DateTime.Now;
            Salvar();
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void formTarefa_Load(object sender, EventArgs e)
        {

        }
    }
}