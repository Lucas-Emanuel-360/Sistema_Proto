namespace Sistema {
    partial class FrmRelatorioLeitores {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lstLeitores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstLeitores
            // 
            this.lstLeitores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLeitores.FormattingEnabled = true;
            this.lstLeitores.Location = new System.Drawing.Point(0, 0);
            this.lstLeitores.Margin = new System.Windows.Forms.Padding(2);
            this.lstLeitores.Name = "lstLeitores";
            this.lstLeitores.Size = new System.Drawing.Size(332, 257);
            this.lstLeitores.TabIndex = 3;
            // 
            // FrmRelatorioLeitores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 257);
            this.Controls.Add(this.lstLeitores);
            this.Name = "FrmRelatorioLeitores";
            this.Text = "FrmRelatorioLeitores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstLeitores;
    }
}