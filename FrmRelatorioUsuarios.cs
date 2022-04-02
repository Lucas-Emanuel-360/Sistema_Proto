namespace Sistema
{
    public partial class FrmRelatorioUsuarios : Form
    {
        // Singleton
        private static FrmRelatorioUsuarios _instance;

        // Singleton
        private FrmRelatorioUsuarios()
        {
            InitializeComponent();
        }

        // Singleton
        public static FrmRelatorioUsuarios GetInstance()
        {
            if (_instance == null
                // Quando esta janela é fechada, a sua
                // instância persiste em um estado inacessível
                // devendo ser recriada
                || (_instance != null && _instance.IsDisposed))
            {
                _instance = new FrmRelatorioUsuarios();
            }

            // Limpa dados anteriores
            _instance.lstUsuarios.Items.Clear();

            // Carrega todos os usuários cadastrados (sem ordem alfabética)
            _instance.lstUsuarios.Items.AddRange(
                RepositorioUsuario.LocalizarTodos().ToArray());

            //// Carrega todos os usuários cadastrados (ordem alfabética)
            //_instance.lstUsuarios.Items.AddRange(
            //    RepositorioUsuario.LocalizarTodosOrdenados().ToArray());

            return _instance;
        }
    }
}
