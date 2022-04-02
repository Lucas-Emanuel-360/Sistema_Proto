namespace Sistema
{
    partial class FrmRelatorioControles
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
            this.lstControles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstControles
            // 
            this.lstControles.FormattingEnabled = true;
            this.lstControles.Location = new System.Drawing.Point(12, 12);
            this.lstControles.Name = "lstControles";
            this.lstControles.Size = new System.Drawing.Size(472, 342);
            this.lstControles.TabIndex = 1;
            // 
            // FrmRelatorioControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 368);
            this.Controls.Add(this.lstControles);
            this.Name = "FrmRelatorioControle";
            this.Text = "FrmRelatorioControle";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstControles;
    }
}