namespace Sistema
{
    public partial class FrmCadastroUsuario : Form
    {
        // Singleton
        private static FrmCadastroUsuario _instance;

        // Singleton
        private FrmCadastroUsuario()
        {
            InitializeComponent();
        }

        // Singleton
        public static FrmCadastroUsuario GetInstance()
        {
            if (_instance == null
                // Quando esta filha é fechada, a sua
                // instância persiste em um estado inacessível
                // devendo ser recriada
                || (_instance != null && _instance.IsDisposed))
            {
                _instance = new FrmCadastroUsuario();
            }
            return _instance;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuário salvo com sucesso!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
