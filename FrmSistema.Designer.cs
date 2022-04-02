namespace Sistema
{
    partial class FrmSistema
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
            this.components = new System.ComponentModel.Container();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.obraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRelatorioUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.obrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leitoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.staInformacoes = new System.Windows.Forms.StatusStrip();
            this.tipInformacoes = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrAtualizaEstado = new System.Windows.Forms.Timer(this.components);
            this.editoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.staInformacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.mnuArquivo,
            this.mnuCadastro,
            this.relatóriosToolStripMenuItem,
            this.mnuAjuda});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuPrincipal.Size = new System.Drawing.Size(600, 24);
            this.mnuPrincipal.TabIndex = 1;
            this.mnuPrincipal.Text = "mnuSistema";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // mnuArquivo
            // 
            this.mnuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSair});
            this.mnuArquivo.Name = "mnuArquivo";
            this.mnuArquivo.Size = new System.Drawing.Size(61, 20);
            this.mnuArquivo.Text = "&Arquivo";
            // 
            // mnuSair
            // 
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.Size = new System.Drawing.Size(180, 22);
            this.mnuSair.Text = "Sai&r";
            this.mnuSair.Click += new System.EventHandler(this.mnuSair_Click);
            // 
            // mnuCadastro
            // 
            this.mnuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUsuario,
            this.obraToolStripMenuItem,
            this.autorToolStripMenuItem,
            this.controleToolStripMenuItem,
            this.leitorToolStripMenuItem,
            this.editoraToolStripMenuItem});
            this.mnuCadastro.Name = "mnuCadastro";
            this.mnuCadastro.Size = new System.Drawing.Size(66, 20);
            this.mnuCadastro.Text = "&Cadastro";
            // 
            // mnuUsuario
            // 
            this.mnuUsuario.Name = "mnuUsuario";
            this.mnuUsuario.Size = new System.Drawing.Size(180, 22);
            this.mnuUsuario.Text = "Us&uário";
            this.mnuUsuario.Click += new System.EventHandler(this.mnuUsuario_Click);
            // 
            // obraToolStripMenuItem
            // 
            this.obraToolStripMenuItem.Name = "obraToolStripMenuItem";
            this.obraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.obraToolStripMenuItem.Text = "Obra";
            this.obraToolStripMenuItem.Click += new System.EventHandler(this.obraToolStripMenuItem_Click);
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.autorToolStripMenuItem.Text = "Autor";
            this.autorToolStripMenuItem.Click += new System.EventHandler(this.autorToolStripMenuItem_Click);
            // 
            // controleToolStripMenuItem
            // 
            this.controleToolStripMenuItem.Name = "controleToolStripMenuItem";
            this.controleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.controleToolStripMenuItem.Text = "Controle";
            this.controleToolStripMenuItem.Click += new System.EventHandler(this.controleToolStripMenuItem_Click);
            // 
            // leitorToolStripMenuItem
            // 
            this.leitorToolStripMenuItem.Name = "leitorToolStripMenuItem";
            this.leitorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.leitorToolStripMenuItem.Text = "Leitor";
            this.leitorToolStripMenuItem.Click += new System.EventHandler(this.leitorToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRelatorioUsuarios,
            this.obrasToolStripMenuItem,
            this.autoresToolStripMenuItem,
            this.controlesToolStripMenuItem,
            this.leitoresToolStripMenuItem,
            this.editorasToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "&Relatórios";
            // 
            // mnuRelatorioUsuarios
            // 
            this.mnuRelatorioUsuarios.Name = "mnuRelatorioUsuarios";
            this.mnuRelatorioUsuarios.Size = new System.Drawing.Size(125, 22);
            this.mnuRelatorioUsuarios.Text = "&Usuários";
            this.mnuRelatorioUsuarios.Click += new System.EventHandler(this.mnuRelatorioUsuarios_Click);
            // 
            // obrasToolStripMenuItem
            // 
            this.obrasToolStripMenuItem.Name = "obrasToolStripMenuItem";
            this.obrasToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.obrasToolStripMenuItem.Text = "Obras";
            this.obrasToolStripMenuItem.Click += new System.EventHandler(this.obrasToolStripMenuItem_Click);
            // 
            // autoresToolStripMenuItem
            // 
            this.autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            this.autoresToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.autoresToolStripMenuItem.Text = "Autores";
            this.autoresToolStripMenuItem.Click += new System.EventHandler(this.autoresToolStripMenuItem_Click);
            // 
            // controlesToolStripMenuItem
            // 
            this.controlesToolStripMenuItem.Name = "controlesToolStripMenuItem";
            this.controlesToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.controlesToolStripMenuItem.Text = "Controles";
            this.controlesToolStripMenuItem.Click += new System.EventHandler(this.controlesToolStripMenuItem_Click);
            // 
            // leitoresToolStripMenuItem
            // 
            this.leitoresToolStripMenuItem.Name = "leitoresToolStripMenuItem";
            this.leitoresToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.leitoresToolStripMenuItem.Text = "Leitores";
            this.leitoresToolStripMenuItem.Click += new System.EventHandler(this.leitoresToolStripMenuItem_Click);
            // 
            // mnuAjuda
            // 
            this.mnuAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSobre});
            this.mnuAjuda.Name = "mnuAjuda";
            this.mnuAjuda.Size = new System.Drawing.Size(50, 20);
            this.mnuAjuda.Text = "A&juda";
            // 
            // mnuSobre
            // 
            this.mnuSobre.Name = "mnuSobre";
            this.mnuSobre.Size = new System.Drawing.Size(104, 22);
            this.mnuSobre.Text = "&Sobre";
            // 
            // staInformacoes
            // 
            this.staInformacoes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.staInformacoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipInformacoes});
            this.staInformacoes.Location = new System.Drawing.Point(0, 344);
            this.staInformacoes.Name = "staInformacoes";
            this.staInformacoes.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.staInformacoes.Size = new System.Drawing.Size(600, 22);
            this.staInformacoes.TabIndex = 3;
            // 
            // tipInformacoes
            // 
            this.tipInformacoes.Name = "tipInformacoes";
            this.tipInformacoes.Size = new System.Drawing.Size(155, 17);
            this.tipInformacoes.Text = "Usuário: ... -- Logon: .../.../...";
            // 
            // tmrAtualizaEstado
            // 
            this.tmrAtualizaEstado.Enabled = true;
            this.tmrAtualizaEstado.Interval = 60000;
            this.tmrAtualizaEstado.Tick += new System.EventHandler(this.tmrAtualizaEstado_Tick);
            // 
            // editoraToolStripMenuItem
            // 
            this.editoraToolStripMenuItem.Name = "editoraToolStripMenuItem";
            this.editoraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editoraToolStripMenuItem.Text = "Editora";
            this.editoraToolStripMenuItem.Click += new System.EventHandler(this.editoraToolStripMenuItem_Click);
            // 
            // editorasToolStripMenuItem
            // 
            this.editorasToolStripMenuItem.Name = "editorasToolStripMenuItem";
            this.editorasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editorasToolStripMenuItem.Text = "Editoras";
            this.editorasToolStripMenuItem.Click += new System.EventHandler(this.editorasToolStripMenuItem_Click);
            // 
            // FrmSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.staInformacoes);
            this.Controls.Add(this.mnuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmSistema";
            this.Text = "Sistema";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSistema_FormClosed);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.staInformacoes.ResumeLayout(false);
            this.staInformacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuArquivo;
        private System.Windows.Forms.ToolStripMenuItem mnuSair;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastro;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuario;
        private System.Windows.Forms.ToolStripMenuItem mnuAjuda;
        private System.Windows.Forms.ToolStripMenuItem mnuSobre;
        private System.Windows.Forms.StatusStrip staInformacoes;
        private System.Windows.Forms.ToolStripStatusLabel tipInformacoes;
        private System.Windows.Forms.Timer tmrAtualizaEstado;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuRelatorioUsuarios;
        private System.Windows.Forms.ToolStripMenuItem obraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leitoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorasToolStripMenuItem;
    }
}