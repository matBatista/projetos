using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoList.Controller;

namespace TodoList.View
{
    public partial class formGerenciarTarefas : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        BindingList<Model.Tarefas> listaTarefas;
        RefreshHelper helper;
        Controller.Tarefas controller = new Controller.Tarefas();
        public formGerenciarTarefas()
        {
            InitializeComponent();
        }
        void AtualizarLista()
        {
            this.BloquearComponentes(true);

            if (!bcWorker.IsBusy) bcWorker.RunWorkerAsync();
        }
        void BloquearComponentes(bool value)
        {
            this.gcTarefas.Enabled = value ? false : true;
        }
        private void CarregaDados()
        {
            if (helper != null)
            {
                helper = new RefreshHelper(gvTarefas, Model.Tarefas.ID);
                helper.SaveViewInfo();
            }

            listaTarefas = controller.getListaTarefas();
            
        }
        private void InserirDadosGrid()
        {
            this.gcTarefas.DataSource = listaTarefas;

            if (helper == null)
            {
                this.gvTarefas.BestFitColumns();
            }

            if (helper != null) helper.LoadViewInfo();

            helper = new RefreshHelper(gvTarefas, Model.Tarefas.ID);
            helper.SaveViewInfo();

            InicializaMascaraCampos();

            this.BloquearComponentes(false);
        }
        private void InicializaMascaraCampos()
        {
            gvTarefas.Columns[Model.Tarefas.ID].Visible = false;
            gvTarefas.Columns[Model.Tarefas.IDUSUARIO].Visible = false;
            gvTarefas.Columns[Model.Tarefas.NOMEUSUARIO].Visible = false;
            gvTarefas.Columns[Model.Tarefas.DATACRIACAO].Visible = false;

            int index = 0;

            if(Controller.Configuracoes.config.idUsuarioLogado == 1)
                gvTarefas.Columns[Model.Tarefas.NOMEUSUARIO].VisibleIndex = index++;

            gvTarefas.Columns[Model.Tarefas.TITULO].VisibleIndex = index++;
            gvTarefas.Columns[Model.Tarefas.DESCRICAO].VisibleIndex = index++;
            gvTarefas.Columns[Model.Tarefas.PRAZO].VisibleIndex = index++;
            gvTarefas.Columns[Model.Tarefas.DATAINICIO].VisibleIndex = index++;
            gvTarefas.Columns[Model.Tarefas.DATAFINAL].VisibleIndex = index++;

            gvTarefas.Columns[Model.Tarefas.TITULO].Width = 200;
            gvTarefas.Columns[Model.Tarefas.DESCRICAO].Width = 300;

            gvTarefas.Columns[Model.Tarefas.NOMEUSUARIO].Caption = "Usuario";
            gvTarefas.Columns[Model.Tarefas.DESCRICAO].Caption = "Descrição Tarefa";
            gvTarefas.Columns[Model.Tarefas.TITULO].Caption = "Título";
            gvTarefas.Columns[Model.Tarefas.PRAZO].Caption = "Prazo";
            gvTarefas.Columns[Model.Tarefas.DATAINICIO].Caption = "Inicio";
            gvTarefas.Columns[Model.Tarefas.DATAFINAL].Caption = "Fim";

        }
        private void editarTarefa()
        {
            if (gvTarefas.SelectedRowsCount <= 0)
                return;

            Int32 id = 0;
            int[] aRowHandle = gvTarefas.GetSelectedRows();

            foreach (int aRow in aRowHandle)
            {

                id = Convert.ToInt32(gvTarefas.GetRowCellValue(aRow, gvTarefas.Columns[Model.Tarefas.ID]).ToString());
                View.formTarefa formTarefa = new formTarefa(id);
                formTarefa.ShowDialog();

            }
            AtualizarLista();

        }
        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void bbiAdicionarTarefa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            View.formTarefa formTarefa = new formTarefa();
            formTarefa.ShowDialog();
            AtualizarLista();
        }

        private void bbiEditarTarefa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            editarTarefa();
        }
        private void bcWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            CarregaDados();
        }
       
        private void bcWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            InserirDadosGrid();
        }

        private void formGerenciarTarefas_Load(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void gvTarefas_DoubleClick(object sender, EventArgs e)
        {
            editarTarefa();
        }
        private void bbiGerarRelatorio_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportarModeloArquivo();
        }


        private OleDbConnection _olecon;
        private OleDbCommand _oleCmd;
        private static String _Arquivo = "";
        private String _StringConexao = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0 Xml;HDR=YES;ReadOnly=False';", "");
        private String _Consulta;


        private void ExportarModeloArquivo()
        {
            //_olecon.Close();
            String mensagem_erro = "";

            _Arquivo = "E:\\Matheus\\Dev\\Tarefas\\TodoList\\Tarefas.xlsx";

            _StringConexao = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0 Xml;HDR=YES;ReadOnly=False';", _Arquivo);
            
            try
            {
                _olecon = new OleDbConnection(_StringConexao);
                _olecon.Open();

                _oleCmd = new OleDbCommand();
                _oleCmd.Connection = _olecon;
                _oleCmd.CommandType = CommandType.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            for (int i = 0; i < gvTarefas.DataRowCount; i++)
            {
                _oleCmd.Parameters.Clear();

                //_oleCmd.CommandText = "INSERT INTO CODIGO,CODIGO_NOVO,TRATAMENTO,GRUPO,UNIDADE,CHAVE,DESCRICAO,LINHA,SETOR_ESTOQUE,ESTOQUE,PESO,REFERENCIAS,NCM,CST,CEST,ESTOQUE_MINIMO,EXPECTATIVA,FORNECEDOR,TIPO_PRODUTO,CUSTO,IPI,ST,DIFAL,ST_ORIGEM,EAN13,TABELA_0,TABELA_1,TABELA_2,TABELA_3,TABELA_4,TABELA_5,TABELA_6,TABELA_7,TABELA_8,TABELA_9,TABELA_10,ORIGEM,CODIGO_ORIGINAL FROM [PRODUTOS$]";

                _oleCmd.CommandText = "INSERT INTO [TAREFAS$] ([ID],[USUARIO],[TITULO],[DESCRICAO],[CRIACAO],[PRAZO],[INICIO],[FINAL]) VALUES (@ID,@USUARIO,@TITULO,@DESCRICAO,@CRIACAO,@PRAZO,@INICIO,@FINAL)";

                _oleCmd.Parameters.Add("@ID", OleDbType.VarChar, 255);
                _oleCmd.Parameters.Add("@USUARIO", OleDbType.VarChar, 255);
                _oleCmd.Parameters.Add("@TITULO", OleDbType.VarChar, 255);
                _oleCmd.Parameters.Add("@DESCRICAO", OleDbType.VarChar, 255);
                _oleCmd.Parameters.Add("@CRIACAO", OleDbType.VarChar, 255);
                _oleCmd.Parameters.Add("@PRAZO", OleDbType.VarChar, 255);
                _oleCmd.Parameters.Add("@INICIO", OleDbType.VarChar, 255);
                _oleCmd.Parameters.Add("@FINAL", OleDbType.VarChar, 255);

                Nullable<DateTime> dt = null;

                _oleCmd.Parameters["@ID"].Value = gvTarefas.GetRowCellValue(i, gvTarefas.Columns[Model.Tarefas.ID]).ToString();
                _oleCmd.Parameters["@USUARIO"].Value = gvTarefas.GetRowCellValue(i, gvTarefas.Columns[Model.Tarefas.NOMEUSUARIO]).ToString();
                _oleCmd.Parameters["@TITULO"].Value = gvTarefas.GetRowCellValue(i, gvTarefas.Columns[Model.Tarefas.TITULO]).ToString();
                _oleCmd.Parameters["@DESCRICAO"].Value = gvTarefas.GetRowCellValue(i, gvTarefas.Columns[Model.Tarefas.DESCRICAO]).ToString();
                _oleCmd.Parameters["@CRIACAO"].Value = Convert.ToDateTime(gvTarefas.GetRowCellValue(i, gvTarefas.Columns[Model.Tarefas.DATACRIACAO])).ToShortDateString();
                _oleCmd.Parameters["@PRAZO"].Value = Convert.ToDateTime(gvTarefas.GetRowCellValue(i, gvTarefas.Columns[Model.Tarefas.PRAZO])).ToShortDateString();
                _oleCmd.Parameters["@INICIO"].Value = gvTarefas.GetRowCellValue(i, gvTarefas.Columns[Model.Tarefas.DATAINICIO]) == null ? "" : Convert.ToDateTime(gvTarefas.GetRowCellValue(i, gvTarefas.Columns[Model.Tarefas.DATAINICIO])).ToShortDateString();
                _oleCmd.Parameters["@FINAL"].Value = gvTarefas.GetRowCellValue(i, gvTarefas.Columns[Model.Tarefas.DATAFINAL]) == null ? "" : Convert.ToDateTime(gvTarefas.GetRowCellValue(i, gvTarefas.Columns[Model.Tarefas.DATAFINAL])).ToShortDateString();

                _oleCmd.ExecuteNonQuery();
                _oleCmd.Parameters.Clear();

            }

            _olecon.Close();
        }
    }
}