namespace Sistema {
    partial class FrmRelatorioEditoras {
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
            this.lstEditoras = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstEditoras
            // 
            this.lstEditoras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstEditoras.FormattingEnabled = true;
            this.lstEditoras.Location = new System.Drawing.Point(0, 0);
            this.lstEditoras.Margin = new System.Windows.Forms.Padding(2);
            this.lstEditoras.Name = "lstEditoras";
            this.lstEditoras.Size = new System.Drawing.Size(388, 255);
            this.lstEditoras.TabIndex = 2;
            // 
            // FrmRelatorioEditoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 255);
            this.Controls.Add(this.lstEditoras);
            this.Name = "FrmRelatorioEditoras";
            this.Text = "FrmRelatorioEditoras";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstEditoras;
    }
}