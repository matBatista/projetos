
namespace TodoList.View
{
    partial class formGerenciarTarefas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formGerenciarTarefas));
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiAdicionarTarefa = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExcluirTarefa = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEditarTarefa = new DevExpress.XtraBars.BarButtonItem();
            this.bbiGerarRelatorio = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gcTarefas = new DevExpress.XtraGrid.GridControl();
            this.gvTarefas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bcWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTarefas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTarefas)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(960, 27);
            this.fluentDesignFormControl1.TabIndex = 5;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.AutoSizeItems = true;
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiAdicionarTarefa,
            this.bbiExcluirTarefa,
            this.bbiEditarTarefa,
            this.bbiGerarRelatorio});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 560);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(960, 95);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiAdicionarTarefa
            // 
            this.bbiAdicionarTarefa.Caption = "Adicionar";
            this.bbiAdicionarTarefa.Id = 1;
            this.bbiAdicionarTarefa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiAdicionarTarefa.ImageOptions.Image")));
            this.bbiAdicionarTarefa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiAdicionarTarefa.ImageOptions.LargeImage")));
            this.bbiAdicionarTarefa.Name = "bbiAdicionarTarefa";
            this.bbiAdicionarTarefa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAdicionarTarefa_ItemClick);
            // 
            // bbiExcluirTarefa
            // 
            this.bbiExcluirTarefa.Caption = "Excluir";
            this.bbiExcluirTarefa.Id = 2;
            this.bbiExcluirTarefa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiExcluirTarefa.ImageOptions.Image")));
            this.bbiExcluirTarefa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiExcluirTarefa.ImageOptions.LargeImage")));
            this.bbiExcluirTarefa.Name = "bbiExcluirTarefa";
            // 
            // bbiEditarTarefa
            // 
            this.bbiEditarTarefa.Caption = "Editar";
            this.bbiEditarTarefa.Id = 3;
            this.bbiEditarTarefa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiEditarTarefa.ImageOptions.Image")));
            this.bbiEditarTarefa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiEditarTarefa.ImageOptions.LargeImage")));
            this.bbiEditarTarefa.Name = "bbiEditarTarefa";
            this.bbiEditarTarefa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEditarTarefa_ItemClick);
            // 
            // bbiGerarRelatorio
            // 
            this.bbiGerarRelatorio.Caption = "Gerar Relatório";
            this.bbiGerarRelatorio.Id = 4;
            this.bbiGerarRelatorio.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiGerarRelatorio.ImageOptions.Image")));
            this.bbiGerarRelatorio.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiGerarRelatorio.ImageOptions.LargeImage")));
            this.bbiGerarRelatorio.Name = "bbiGerarRelatorio";
            this.bbiGerarRelatorio.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGerarRelatorio_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiAdicionarTarefa);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEditarTarefa);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiGerarRelatorio);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // gcTarefas
            // 
            this.gcTarefas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTarefas.Location = new System.Drawing.Point(0, 27);
            this.gcTarefas.MainView = this.gvTarefas;
            this.gcTarefas.MenuManager = this.ribbonControl1;
            this.gcTarefas.Name = "gcTarefas";
            this.gcTarefas.Size = new System.Drawing.Size(960, 533);
            this.gcTarefas.TabIndex = 7;
            this.gcTarefas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTarefas});
            // 
            // gvTarefas
            // 
            this.gvTarefas.GridControl = this.gcTarefas;
            this.gvTarefas.Name = "gvTarefas";
            this.gvTarefas.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvTarefas.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvTarefas.OptionsBehavior.Editable = false;
            this.gvTarefas.OptionsBehavior.ReadOnly = true;
            this.gvTarefas.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Fast;
            this.gvTarefas.OptionsView.ShowAutoFilterRow = true;
            this.gvTarefas.OptionsView.ShowGroupPanel = false;
            this.gvTarefas.DoubleClick += new System.EventHandler(this.gvTarefas_DoubleClick);
            // 
            // bcWorker
            // 
            this.bcWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bcWorker_DoWork);
            this.bcWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bcWorker_RunWorkerCompleted);
            // 
            // formGerenciarTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 655);
            this.Controls.Add(this.gcTarefas);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "formGerenciarTarefas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formGerenciarTarefas";
            this.Load += new System.EventHandler(this.formGerenciarTarefas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTarefas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTarefas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraGrid.GridControl gcTarefas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTarefas;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem bbiAdicionarTarefa;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiExcluirTarefa;
        private DevExpress.XtraBars.BarButtonItem bbiEditarTarefa;
        private DevExpress.XtraBars.BarButtonItem bbiGerarRelatorio;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.ComponentModel.BackgroundWorker bcWorker;
    }
}