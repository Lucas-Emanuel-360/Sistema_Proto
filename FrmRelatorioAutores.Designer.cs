namespace Sistema
{
    partial class FrmRelatorioAutores
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
            this.lstAutores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstAutores
            // 
            this.lstAutores.FormattingEnabled = true;
            this.lstAutores.Location = new System.Drawing.Point(12, 12);
            this.lstAutores.Name = "lstAutores";
            this.lstAutores.Size = new System.Drawing.Size(448, 277);
            this.lstAutores.TabIndex = 1;
            // 
            // FrmRelatorioAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 302);
            this.Controls.Add(this.lstAutores);
            this.Name = "FrmRelatorioAutores";
            this.Text = "FrmRelatorioAutores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstAutores;
    }
}