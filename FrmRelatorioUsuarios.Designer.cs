namespace Sistema
{
    partial class FrmRelatorioUsuarios
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
            this.pnlRelatorioUsuarios = new System.Windows.Forms.Panel();
            this.lstUsuarios = new System.Windows.Forms.ListBox();
            this.pnlRelatorioUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRelatorioUsuarios
            // 
            this.pnlRelatorioUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRelatorioUsuarios.Controls.Add(this.lstUsuarios);
            this.pnlRelatorioUsuarios.Location = new System.Drawing.Point(12, 12);
            this.pnlRelatorioUsuarios.Name = "pnlRelatorioUsuarios";
            this.pnlRelatorioUsuarios.Size = new System.Drawing.Size(776, 426);
            this.pnlRelatorioUsuarios.TabIndex = 0;
            // 
            // lstUsuarios
            // 
            this.lstUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstUsuarios.FormattingEnabled = true;
            this.lstUsuarios.ItemHeight = 16;
            this.lstUsuarios.Location = new System.Drawing.Point(0, 0);
            this.lstUsuarios.Name = "lstUsuarios";
            this.lstUsuarios.Size = new System.Drawing.Size(776, 426);
            this.lstUsuarios.TabIndex = 0;
            // 
            // FrmRelatorioUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlRelatorioUsuarios);
            this.Name = "FrmRelatorioUsuarios";
            this.Text = "Usuários Cadastrados";
            this.pnlRelatorioUsuarios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRelatorioUsuarios;
        private System.Windows.Forms.ListBox lstUsuarios;
    }
}