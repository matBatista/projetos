
namespace TodoList.View
{
    partial class formTarefa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTarefa));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTitulo = new DevExpress.XtraEditors.TextEdit();
            this.sbtnFinalizar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.sbtnIniciar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.sbtnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtePrazo = new DevExpress.XtraEditors.DateEdit();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitulo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtePrazo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtePrazo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(22, 78);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Titulo";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitulo.Location = new System.Drawing.Point(22, 97);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(476, 20);
            this.txtTitulo.TabIndex = 1;
            // 
            // sbtnFinalizar
            // 
            this.sbtnFinalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtnFinalizar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.sbtnFinalizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnFinalizar.ImageOptions.Image")));
            this.sbtnFinalizar.Location = new System.Drawing.Point(403, 420);
            this.sbtnFinalizar.Name = "sbtnFinalizar";
            this.sbtnFinalizar.Size = new System.Drawing.Size(95, 44);
            this.sbtnFinalizar.TabIndex = 4;
            this.sbtnFinalizar.Text = "Finalizar";
            this.sbtnFinalizar.Click += new System.EventHandler(this.sbtnFinalizar_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(230, 31);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 18);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Tarefa";
            // 
            // sbtnIniciar
            // 
            this.sbtnIniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtnIniciar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.sbtnIniciar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnIniciar.ImageOptions.Image")));
            this.sbtnIniciar.Location = new System.Drawing.Point(415, 20);
            this.sbtnIniciar.Name = "sbtnIniciar";
            this.sbtnIniciar.Size = new System.Drawing.Size(83, 44);
            this.sbtnIniciar.TabIndex = 5;
            this.sbtnIniciar.Text = "Iniciar";
            this.sbtnIniciar.Click += new System.EventHandler(this.sbtnIniciar_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(22, 124);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "Descrição";
            // 
            // sbtnSalvar
            // 
            this.sbtnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbtnSalvar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.sbtnSalvar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnSalvar.ImageOptions.Image")));
            this.sbtnSalvar.Location = new System.Drawing.Point(22, 420);
            this.sbtnSalvar.Name = "sbtnSalvar";
            this.sbtnSalvar.Size = new System.Drawing.Size(83, 44);
            this.sbtnSalvar.TabIndex = 16;
            this.sbtnSalvar.Text = "Salvar";
            this.sbtnSalvar.Click += new System.EventHandler(this.sbtnSalvar_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl3.Location = new System.Drawing.Point(22, 367);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(27, 13);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "Prazo";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // dtePrazo
            // 
            this.dtePrazo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtePrazo.EditValue = null;
            this.dtePrazo.Location = new System.Drawing.Point(22, 387);
            this.dtePrazo.Name = "dtePrazo";
            this.dtePrazo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtePrazo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtePrazo.Size = new System.Drawing.Size(123, 20);
            this.dtePrazo.TabIndex = 18;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.Location = new System.Drawing.Point(22, 144);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(476, 217);
            this.txtDescricao.TabIndex = 19;
            // 
            // formTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 476);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.dtePrazo);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.sbtnSalvar);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.sbtnIniciar);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.sbtnFinalizar);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtTitulo);
            this.Name = "formTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarefa [ ]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CadastroUsuario_FormClosing);
            this.Load += new System.EventHandler(this.formTarefa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTitulo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtePrazo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtePrazo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTitulo;
        private DevExpress.XtraEditors.SimpleButton sbtnFinalizar;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton sbtnIniciar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton sbtnSalvar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dtePrazo;
        private System.Windows.Forms.TextBox txtDescricao;
    }
}