namespace Sistema
{
    public partial class FrmRelatorioObras : Form
    {
        private static FrmRelatorioObras _instance;
        private FrmRelatorioObras()
        {
            InitializeComponent();
        }

        public static FrmRelatorioObras GetInstance()
        {
            if (_instance == null
                // Quando esta janela é fechada, a sua
                // instância persiste em um estado inacessível
                // devendo ser recriada
                || (_instance != null && _instance.IsDisposed))
            {
                _instance = new FrmRelatorioObras();
            }

            // Limpa dados anteriores
            _instance.lstObras.Items.Clear();

            // Carrega todos as obras cadastrados (sem ordem alfabética)
            _instance.lstObras.Items.AddRange(
                RepositorioObra.LocalizarTodos().ToArray());

            //// Carrega todos as obras cadastrados (ordem alfabética)
            //_instance.lstObras.Items.AddRange(
            //    RepositorioObras.LocalizarTodosOrdenados().ToArray());

            return _instance;
        }
    }
}
