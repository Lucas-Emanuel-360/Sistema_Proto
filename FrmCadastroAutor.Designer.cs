namespace Sistema
{
    partial class FrmCadastroAutor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.dtpFalecimento = new System.Windows.Forms.DateTimePicker();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblFalecimento = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSalvar);
            this.panel1.Controls.Add(this.txtNomeAutor);
            this.panel1.Controls.Add(this.dtpFalecimento);
            this.panel1.Controls.Add(this.dtpNascimento);
            this.panel1.Controls.Add(this.lblFalecimento);
            this.panel1.Controls.Add(this.lblNascimento);
            this.panel1.Controls.Add(this.lblAutor);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 216);
            this.panel1.TabIndex = 2;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(275, 169);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 9;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Location = new System.Drawing.Point(85, 28);
            this.txtNomeAutor.MaxLength = 50;
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(265, 20);
            this.txtNomeAutor.TabIndex = 6;
            // 
            // dtpFalecimento
            // 
            this.dtpFalecimento.Location = new System.Drawing.Point(135, 123);
            this.dtpFalecimento.Name = "dtpFalecimento";
            this.dtpFalecimento.Size = new System.Drawing.Size(215, 20);
            this.dtpFalecimento.TabIndex = 5;
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Location = new System.Drawing.Point(135, 77);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(215, 20);
            this.dtpNascimento.TabIndex = 4;
            // 
            // lblFalecimento
            // 
            this.lblFalecimento.AutoSize = true;
            this.lblFalecimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFalecimento.Location = new System.Drawing.Point(29, 123);
            this.lblFalecimento.Name = "lblFalecimento";
            this.lblFalecimento.Size = new System.Drawing.Size(100, 20);
            this.lblFalecimento.TabIndex = 2;
            this.lblFalecimento.Text = "Falecimento:";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNascimento.Location = new System.Drawing.Point(29, 77);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(97, 20);
            this.lblNascimento.TabIndex = 1;
            this.lblNascimento.Text = "Nascimento:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAutor.Location = new System.Drawing.Point(27, 28);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(52, 20);
            this.lblAutor.TabIndex = 0;
            this.lblAutor.Text = "Autor:";
            // 
            // FrmCadastroAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 240);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCadastroAutor";
            this.Text = "FrmCadastroAutor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.DateTimePicker dtpFalecimento;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label lblFalecimento;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblAutor;
    }
}