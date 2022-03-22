
namespace TodoList.View
{
    partial class formCadastroUsuario
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.txtSenha = new DevExpress.XtraEditors.TextEdit();
            this.sbtnCadastro = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.sbtnCancelar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(168, 97);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Senha";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(168, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(168, 65);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(221, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(168, 116);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Properties.AutoHeight = false;
            this.txtSenha.Properties.UseSystemPasswordChar = true;
            this.txtSenha.Size = new System.Drawing.Size(221, 20);
            this.txtSenha.TabIndex = 2;
            // 
            // sbtnCadastro
            // 
            this.sbtnCadastro.Location = new System.Drawing.Point(314, 216);
            this.sbtnCadastro.Name = "sbtnCadastro";
            this.sbtnCadastro.Size = new System.Drawing.Size(75, 23);
            this.sbtnCadastro.TabIndex = 4;
            this.sbtnCadastro.Text = "Cadastrar";
            this.sbtnCadastro.Click += new System.EventHandler(this.sbtnCadastro_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(168, 149);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(80, 13);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Confirmar Senha";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(168, 168);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.AutoHeight = false;
            this.textEdit1.Properties.UseSystemPasswordChar = true;
            this.textEdit1.Size = new System.Drawing.Size(221, 20);
            this.textEdit1.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(210, 18);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(136, 18);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Cadastrar Usuario";
            // 
            // sbtnCancelar
            // 
            this.sbtnCancelar.Location = new System.Drawing.Point(168, 216);
            this.sbtnCancelar.Name = "sbtnCancelar";
            this.sbtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.sbtnCancelar.TabIndex = 5;
            this.sbtnCancelar.Text = "Cancelar";
            this.sbtnCancelar.Click += new System.EventHandler(this.sbtnCancelar_Click);
            // 
            // formCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 261);
            this.Controls.Add(this.sbtnCancelar);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.sbtnCadastro);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtSenha);
            this.Name = "formCadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroUsuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CadastroUsuario_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.TextEdit txtSenha;
        private DevExpress.XtraEditors.SimpleButton sbtnCadastro;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton sbtnCancelar;
    }
}