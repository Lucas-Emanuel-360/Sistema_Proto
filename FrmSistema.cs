namespace Sistema
{
    public partial class FrmSistema : Form
    {
        // Singleton
        private static FrmSistema _instance;

        // Horário de logon
        private DateTime _logon;

        // Dados do usuário acessado
        private Usuario _usuarioLogado;
        public Usuario UsuarioLogado
        {
            get { return _instance._usuarioLogado; }
            set
            {
                _instance._usuarioLogado = value;
                PreencherStatus();
            }
        }

        // Singleton
        private FrmSistema()
        {
            InitializeComponent();
        }

        // Singleton
        public static FrmSistema GetInstance()
        {
            if (_instance == null
                // Quando esta janela é fechada, a sua
                // instância persiste em um estado inacessível
                // devendo ser recriada
                || (_instance != null && _instance.IsDisposed))
            {
                _instance = new FrmSistema();
            }
            return _instance;
        }

        private void PreencherStatus()
        {
            // Registra horário de logon
            _logon = DateTime.Now;

            // Exibe informações iniciais do logon
            tipInformacoes.Text =
                "Usuário: "
                + UsuarioLogado.Nome
                + " -- Logon: "
                + _logon.ToString("dd/MM/yyyy HH:mm:ss");
        }

        #region Eventos nos menus
        private void mnuSair_Click(object sender, EventArgs e)
        {
            //FrmLogin.GetInstance().Visible = true;
            FrmLogin.GetInstance().Show();

            // "Fecha" a janela principal do programa
            //this.Visible = false;
            this.Hide();
        }

        private void mnuUsuario_Click(object sender, EventArgs e)
        {
            FrmCadastroUsuario filha = FrmCadastroUsuario.GetInstance();

            // Define a janela como filha desta MDI
            filha.MdiParent = this;

            // Traz a janela para a frente das demais
            filha.BringToFront();

            // Restaura a janela filha, caso esteja minimizada
            filha.WindowState = FormWindowState.Normal;

            // Torna a janela filha visível
            //filha.Visible = true;
            filha.Show();
        }

        private void mnuRelatorioUsuarios_Click(object sender, EventArgs e)
        {
            FrmRelatorioUsuarios filha = FrmRelatorioUsuarios.GetInstance();

            // Define a janela como filha desta MDI
            filha.MdiParent = this;

            // Traz a janela para a frente das demais
            filha.BringToFront();

            // Restaura a janela filha, caso esteja minimizada
            filha.WindowState = FormWindowState.Normal;

            // Torna a janela filha visível
            //filha.Visible = true;
            filha.Show();
        }
        #endregion

        #region Fechamento da janela
        private void FrmSistema_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Exibe a janela de login
            //FrmLogin.GetInstance().Visible = true;
            FrmLogin.GetInstance().Show();

            // "Fecha" esta janela (principal)
            //this.Visible = false;
            this.Hide();
        }
        #endregion

        #region Temporizador
        private void tmrAtualizaEstado_Tick(object sender, EventArgs e)
        {
            int minutos = (DateTime.Now - _logon).Minutes;

            // Exibe informações do logon
            tipInformacoes.Text =
                "Usuário: "
                + UsuarioLogado.Nome
                + " -- Logon: "
                + _logon.ToString("dd/MM/yyyy HH:mm:ss")
                + (minutos > 0
                    ? " -- Logado há " + minutos + " minuto(s)"
                    : "");
        }
        #endregion

        private void obraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroObra filha = FrmCadastroObra.GetInstance();

            // Define a janela como filha desta MDI
            filha.MdiParent = this;

            // Traz a janela para a frente das demais
            filha.BringToFront();

            // Restaura a janela filha, caso esteja minimizada
            filha.WindowState = FormWindowState.Normal;

            // Torna a janela filha visível
            //filha.Visible = true;
            filha.Show();
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroAutor filha = FrmCadastroAutor.GetInstance();

            // Define a janela como filha desta MDI
            filha.MdiParent = this;

            // Traz a janela para a frente das demais
            filha.BringToFront();

            // Restaura a janela filha, caso esteja minimizada
            filha.WindowState = FormWindowState.Normal;

            // Torna a janela filha visível
            //filha.Visible = true;
            filha.Show();
        }

        private void obrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelatorioObras filha = FrmRelatorioObras.GetInstance();

            // Define a janela como filha desta MDI
            filha.MdiParent = this;

            // Traz a janela para a frente das demais
            filha.BringToFront();

            // Restaura a janela filha, caso esteja minimizada
            filha.WindowState = FormWindowState.Normal;

            // Torna a janela filha visível
            //filha.Visible = true;
            filha.Show();
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelatorioAutores filha = FrmRelatorioAutores.GetInstance();

            // Define a janela como filha desta MDI
            filha.MdiParent = this;

            // Traz a janela para a frente das demais
            filha.BringToFront();

            // Restaura a janela filha, caso esteja minimizada
            filha.WindowState = FormWindowState.Normal;

            // Torna a janela filha visível
            //filha.Visible = true;
            filha.Show();
        }

        private void controleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroControle filha = FrmCadastroControle.GetInstance();

            // Define a janela como filha desta MDI
            filha.MdiParent = this;

            // Traz a janela para a frente das demais
            filha.BringToFront();

            // Restaura a janela filha, caso esteja minimizada
            filha.WindowState = FormWindowState.Normal;

            // Torna a janela filha visível
            //filha.Visible = true;
            filha.Show();
        }

        private void controlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelatorioControles filha = FrmRelatorioControles.GetInstance();

            // Define a janela como filha desta MDI
            filha.MdiParent = this;

            // Traz a janela para a frente das demais
            filha.BringToFront();

            // Restaura a janela filha, caso esteja minimizada
            filha.WindowState = FormWindowState.Normal;

            // Torna a janela filha visível
            //filha.Visible = true;
            filha.Show();
        }

        private void leitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroLeitor filha = FrmCadastroLeitor.GetInstance();

            // Define a janela como filha desta MDI
            filha.MdiParent = this;

            // Traz a janela para a frente das demais
            filha.BringToFront();

            // Restaura a janela filha, caso esteja minimizada
            filha.WindowState = FormWindowState.Normal;

            // Torna a janela filha visível
            //filha.Visible = true;
            filha.Show();
        }

        private void leitoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelatorioLeitores filha = FrmRelatorioLeitores.GetInstance();

            // Define a janela como filha desta MDI
            filha.MdiParent = this;

            // Traz a janela para a frente das demais
            filha.BringToFront();

            // Restaura a janela filha, caso esteja minimizada
            filha.WindowState = FormWindowState.Normal;

            // Torna a janela filha visível
            //filha.Visible = true;
            filha.Show();
        }

        private void editoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroEditora filha = FrmCadastroEditora.GetInstance();

            // Define a janela como filha desta MDI
            filha.MdiParent = this;

            // Traz a janela para a frente das demais
            filha.BringToFront();

            // Restaura a janela filha, caso esteja minimizada
            filha.WindowState = FormWindowState.Normal;

            // Torna a janela filha visível
            //filha.Visible = true;
            filha.Show();
        }

        private void editorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelatorioEditoras filha = FrmRelatorioEditoras.GetInstance();

            // Define a janela como filha desta MDI
            filha.MdiParent = this;

            // Traz a janela para a frente das demais
            filha.BringToFront();

            // Restaura a janela filha, caso esteja minimizada
            filha.WindowState = FormWindowState.Normal;

            // Torna a janela filha visível
            //filha.Visible = true;
            filha.Show();
        }
    }
}
