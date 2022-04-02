namespace Sistema
{
    public partial class FrmRelatorioAutores : Form
    {
        // Singleton
        private static FrmRelatorioAutores _instance;

        // Singleton
        private FrmRelatorioAutores()
        {
            InitializeComponent();
        }

        // Singleton
        public static FrmRelatorioAutores GetInstance()
        {
            if (_instance == null
                // Quando esta janela é fechada, a sua
                // instância persiste em um estado inacessível
                // devendo ser recriada
                || (_instance != null && _instance.IsDisposed))
            {
                _instance = new FrmRelatorioAutores();
            }

            // Limpa dados anteriores
            _instance.lstAutores.Items.Clear();

            // Carrega todos os usuários cadastrados (sem ordem alfabética)
            _instance.lstAutores.Items.AddRange(
                RepositorioAutor.LocalizarTodos().ToArray());

            //// Carrega todos os usuários cadastrados (ordem alfabética)
            //_instance.lstUsuarios.Items.AddRange(
            //    RepositorioUsuario.LocalizarTodosOrdenados().ToArray());

            return _instance;
        }
    }
}
