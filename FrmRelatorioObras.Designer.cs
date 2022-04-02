namespace Sistema
{
    partial class FrmRelatorioObras
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
            this.lstObras = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstObras
            // 
            this.lstObras.FormattingEnabled = true;
            this.lstObras.Location = new System.Drawing.Point(12, 12);
            this.lstObras.Name = "lstObras";
            this.lstObras.Size = new System.Drawing.Size(448, 277);
            this.lstObras.TabIndex = 1;
            // 
            // FrmRelatorioObras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 300);
            this.Controls.Add(this.lstObras);
            this.Name = "FrmRelatorioObras";
            this.Text = "FrmRelatorioObras";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstObras;
    }
}