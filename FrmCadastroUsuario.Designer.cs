namespace Sistema
{
    partial class FrmCadastroUsuario
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
            this.pnlCadastroUsuario = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnlCadastroUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCadastroUsuario
            // 
            this.pnlCadastroUsuario.Controls.Add(this.btnSalvar);
            this.pnlCadastroUsuario.Location = new System.Drawing.Point(12, 12);
            this.pnlCadastroUsuario.Name = "pnlCadastroUsuario";
            this.pnlCadastroUsuario.Size = new System.Drawing.Size(418, 277);
            this.pnlCadastroUsuario.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(340, 251);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 301);
            this.Controls.Add(this.pnlCadastroUsuario);
            this.Name = "frmCadastroUsuario";
            this.Text = "Cadastro de Usuário";
            this.pnlCadastroUsuario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCadastroUsuario;
        private System.Windows.Forms.Button btnSalvar;
    }
}