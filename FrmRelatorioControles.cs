namespace Sistema
{
    public partial class FrmRelatorioControles : Form
    {
        // Singleton
        private static FrmRelatorioControles _instance;

        // Singleton
        private FrmRelatorioControles()
        {
            InitializeComponent();
        }

        // Singleton
        public static FrmRelatorioControles GetInstance()
        {
            if (_instance == null
                // Quando esta janela é fechada, a sua
                // instância persiste em um estado inacessível
                // devendo ser recriada
                || (_instance != null && _instance.IsDisposed))
            {
                _instance = new FrmRelatorioControles();
            }

            // Limpa dados anteriores
            _instance.lstControles.Items.Clear();

            // Carrega todos os usuários cadastrados (sem ordem alfabética)
            _instance.lstControles.Items.AddRange(
                RepositorioControle.LocalizarTodos().ToArray());

            //// Carrega todos os usuários cadastrados (ordem alfabética)
            //_instance.lstUsuarios.Items.AddRange(
            //    RepositorioUsuario.LocalizarTodosOrdenados().ToArray());

            return _instance;
        }
    }
}
