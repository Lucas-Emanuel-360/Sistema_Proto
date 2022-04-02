namespace Sistema
{
    public partial class FrmRelatorioEditoras : Form
    {
        // Singleton
        private static FrmRelatorioEditoras _instance;

        // Singleton
        private FrmRelatorioEditoras()
        {
            InitializeComponent();
        }

        // Singleton
        public static FrmRelatorioEditoras GetInstance()
        {
            if (_instance == null
                // Quando esta janela é fechada, a sua
                // instância persiste em um estado inacessível
                // devendo ser recriada
                || (_instance != null && _instance.IsDisposed))
            {
                _instance = new FrmRelatorioEditoras();
            }

            // Limpa dados anteriores
            _instance.lstEditoras.Items.Clear();

            // Carrega todos os usuários cadastrados (sem ordem alfabética)
            _instance.lstEditoras.Items.AddRange(
                RepositorioUsuario.LocalizarTodos().ToArray());

            //// Carrega todos os usuários cadastrados (ordem alfabética)
            //_instance.lstEditoras.Items.AddRange(
            //    RepositorioUsuario.LocalizarTodosOrdenados().ToArray());

            return _instance;
        }
    }
}
