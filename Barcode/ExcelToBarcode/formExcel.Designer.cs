
namespace ExcelToBarcode
{
    partial class formExcel
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFileSource = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectOri = new System.Windows.Forms.Button();
            this.txtFileDestiny = new System.Windows.Forms.TextBox();
            this.btnSelectDest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFileSource
            // 
            this.txtFileSource.Location = new System.Drawing.Point(12, 41);
            this.txtFileSource.Name = "txtFileSource";
            this.txtFileSource.Size = new System.Drawing.Size(226, 20);
            this.txtFileSource.TabIndex = 0;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(12, 141);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(315, 23);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "START";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Informar Arquivo";
            // 
            // btnSelectOri
            // 
            this.btnSelectOri.Location = new System.Drawing.Point(254, 41);
            this.btnSelectOri.Name = "btnSelectOri";
            this.btnSelectOri.Size = new System.Drawing.Size(75, 23);
            this.btnSelectOri.TabIndex = 4;
            this.btnSelectOri.Text = "SELECT";
            this.btnSelectOri.UseVisualStyleBackColor = true;
            this.btnSelectOri.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // txtFileDestiny
            // 
            this.txtFileDestiny.Location = new System.Drawing.Point(12, 90);
            this.txtFileDestiny.Name = "txtFileDestiny";
            this.txtFileDestiny.Size = new System.Drawing.Size(226, 20);
            this.txtFileDestiny.TabIndex = 5;
            // 
            // btnSelectDest
            // 
            this.btnSelectDest.Location = new System.Drawing.Point(252, 90);
            this.btnSelectDest.Name = "btnSelectDest";
            this.btnSelectDest.Size = new System.Drawing.Size(75, 23);
            this.btnSelectDest.TabIndex = 6;
            this.btnSelectDest.Text = "SELECT";
            this.btnSelectDest.UseVisualStyleBackColor = true;
            this.btnSelectDest.Click += new System.EventHandler(this.btnSelectDestino_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Indicar local de destino";
            // 
            // formExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 185);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectDest);
            this.Controls.Add(this.txtFileDestiny);
            this.Controls.Add(this.btnSelectOri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtFileSource);
            this.Name = "formExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel to Barcode PDF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFileSource;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectOri;
        private System.Windows.Forms.TextBox txtFileDestiny;
        private System.Windows.Forms.Button btnSelectDest;
        private System.Windows.Forms.Label label2;
    }
}

