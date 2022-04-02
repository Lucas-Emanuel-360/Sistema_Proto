namespace Sistema
{
    public partial class FrmCadastroControle : Form
    {
        // Singleton
        private static FrmCadastroControle _instance;

        // Singleton
        private FrmCadastroControle()
        {
            InitializeComponent();
        }

        // Singleton
        public static FrmCadastroControle GetInstance()
        {
            if (_instance == null
                // Quando esta filha é fechada, a sua
                // instância persiste em um estado inacessível
                // devendo ser recriada
                || (_instance != null && _instance.IsDisposed))
            {
                _instance = new FrmCadastroControle();
            }
            return _instance;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Controle c = new Controle();



            c.Emprestimo = dtpEmprestimo.Value;
            c.Devolucao = dtpDevolucao.Value;
            c.Observacoes = txtObservacoes.Text;

            Console.WriteLine(c);

            //RepositorioControle.salvar(c);

            txtObservacoes.Text = null;
            RepositorioControle.Salvar(c);
        }
    }
}