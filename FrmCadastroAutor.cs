namespace Sistema
{
    public partial class FrmCadastroAutor : Form
    {
        // Singleton
        private static FrmCadastroAutor _instance;

        // Singleton
        private FrmCadastroAutor()
        {
            InitializeComponent();
        }

        // Singleton
        public static FrmCadastroAutor GetInstance()
        {
            if (_instance == null
                // Quando esta filha é fechada, a sua
                // instância persiste em um estado inacessível
                // devendo ser recriada
                || (_instance != null && _instance.IsDisposed))
            {
                _instance = new FrmCadastroAutor();
            }
            return _instance;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            Autor a = new Autor();

            a.Nome = txtNomeAutor.Text;
            a.Nascimento = dtpNascimento.Value;
            a.Falecimento = dtpFalecimento.Value;

            RepositorioAutor.Salvar(a);
        }
    }
}