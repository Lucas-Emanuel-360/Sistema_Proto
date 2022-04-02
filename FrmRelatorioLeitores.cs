namespace Sistema
{
    public partial class FrmRelatorioLeitores : Form
    {
        // Singleton
        private static FrmRelatorioLeitores _instance;

        // Singleton
        private FrmRelatorioLeitores()
        {
            InitializeComponent();
        }

        // Singleton
        public static FrmRelatorioLeitores GetInstance()
        {
            if (_instance == null
                // Quando esta janela é fechada, a sua
                // instância persiste em um estado inacessível
                // devendo ser recriada
                || (_instance != null && _instance.IsDisposed))
            {
                _instance = new FrmRelatorioLeitores();
            }

            // Limpa dados anteriores
            _instance.lstLeitores.Items.Clear();

            // Carrega todos os usuários cadastrados (sem ordem alfabética)
            _instance.lstLeitores.Items.AddRange(
                RepositorioUsuario.LocalizarTodos().ToArray());

            //// Carrega todos os usuários cadastrados (ordem alfabética)
            //_instance.lstUsuarios.Items.AddRange(
            //    RepositorioUsuario.LocalizarTodosOrdenados().ToArray());

            return _instance;
        }
    }
}