namespace Sistema
{
    public partial class FrmCadastroLeitor : Form
    {
        // Singleton
        private static FrmCadastroLeitor _instance;

        // Singleton
        private FrmCadastroLeitor()
        {
            InitializeComponent();
        }

        // Singleton
        public static FrmCadastroLeitor GetInstance()
        {
            if (_instance == null
                // Quando esta filha é fechada, a sua
                // instância persiste em um estado inacessível
                // devendo ser recriada
                || (_instance != null && _instance.IsDisposed))
            {
                _instance = new FrmCadastroLeitor();
            }
            return _instance;
        }

        private void btn_button_Click_1(object sender, EventArgs e)
        {
            Leitor l = new Leitor();
            l.Nome = txtNome.Text;
            l.Email = txtEmail.Text;
            l.Senha = txtSenha.Text;

            RepositorioLeitor.Salvar(l);
        }
    }
}
