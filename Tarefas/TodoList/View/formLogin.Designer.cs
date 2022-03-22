
namespace TodoList.View
{
    partial class formLogin
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
            this.sbtnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.hyperlinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.txtSenha = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbtnLogin
            // 
            this.sbtnLogin.Location = new System.Drawing.Point(168, 172);
            this.sbtnLogin.Name = "sbtnLogin";
            this.sbtnLogin.Size = new System.Drawing.Size(75, 23);
            this.sbtnLogin.TabIndex = 0;
            this.sbtnLogin.Text = "Entrar";
            this.sbtnLogin.Click += new System.EventHandler(this.sbtnLogin_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(22, 61);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(221, 20);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.EditValueChanged += new System.EventHandler(this.txtUsuario_EditValueChanged);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Usuario";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 102);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Senha";
            // 
            // hyperlinkLabelControl1
            // 
            this.hyperlinkLabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hyperlinkLabelControl1.Appearance.Options.UseFont = true;
            this.hyperlinkLabelControl1.Location = new System.Drawing.Point(22, 182);
            this.hyperlinkLabelControl1.Name = "hyperlinkLabelControl1";
            this.hyperlinkLabelControl1.Size = new System.Drawing.Size(56, 13);
            this.hyperlinkLabelControl1.TabIndex = 6;
            this.hyperlinkLabelControl1.Text = "Cadastrar";
            this.hyperlinkLabelControl1.Click += new System.EventHandler(this.hyperlinkLabelControl1_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(22, 121);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Properties.AutoHeight = false;
            this.txtSenha.Properties.UseSystemPasswordChar = true;
            this.txtSenha.Size = new System.Drawing.Size(221, 20);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 227);
            this.Controls.Add(this.hyperlinkLabelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.sbtnLogin);
            this.Controls.Add(this.txtSenha);
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formLogin";
            this.Load += new System.EventHandler(this.formLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sbtnLogin;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl1;
        private DevExpress.XtraEditors.TextEdit txtSenha;
    }
}