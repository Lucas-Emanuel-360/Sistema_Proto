namespace Sistema
{
    public partial class FrmLogin : Form
    {
        // Singleton
        private static FrmLogin _instance;

        // Singleton
        private FrmLogin()
        {
            InitializeComponent();

            // Força a criação do banco de dados,
            // caso ele não exista previamente
            Repositorio repositorio = new Repositorio();
        }

        // Singleton
        public static FrmLogin GetInstance()
        {
            if (_instance == null)
            {
                _instance = new FrmLogin();
            }

            // Pré-seleciona o primeiro campo de entrada
            _instance.ActiveControl = _instance.txtEmail;

            return _instance;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            // Autentica usuário
            Usuario usuario = RepositorioUsuario.Autenticar(
                new Usuario()
                {
                    Email = txtEmail.Text,
                    Senha = mskSenha.Text
                }
            );

            // Se o usuário é válido, ...
            if (usuario != null)
            {
                // ... limpa campos de entrada, ...
                txtEmail.Text = null;
                mskSenha.Text = null;

                // ... "fecha" esta janela ...
                //this.Visible = false;
                this.Hide();

                // ... e abre o programa principal.
                FrmSistema janelaSistema = FrmSistema.GetInstance();
                janelaSistema.UsuarioLogado = usuario;
                //janelaSistema.Visible = true;
                janelaSistema.Show();
            }
            else
            {
                // Se o usuário é inválido, limpa campo de senha, ...
                mskSenha.Text = null;

                // ... e pré-seleciona o primeiro campo de entrada.
                txtEmail.SelectAll();
                this.ActiveControl = txtEmail;

                // Ao invés de uma mensagem, pode ser usado um rótulo na
                // GUI para indicar que a autenticação não foi realizada
                MessageBox.Show("Usuário e/ou senha inválidos!\nTente novamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
