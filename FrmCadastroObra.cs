namespace Sistema
{
    public partial class FrmCadastroObra : Form
    {
        private static FrmCadastroObra _instance;

        private FrmCadastroObra()
        {
            InitializeComponent();
        }

        public static FrmCadastroObra GetInstance()
        {
            if (_instance == null
                // Quando esta filha é fechada, a sua
                // instância persiste em um estado inacessível
                // devendo ser recriada
                || (_instance != null && _instance.IsDisposed))
            {
                _instance = new FrmCadastroObra();
            }
            return _instance;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Obra o = new Obra();
            o.Isbn = Convert.ToInt64(txtIsbn.Text);
            o.Titulo = txtTitulo.Text;
            o.Edicao = Convert.ToByte(txtEdicao.Text);
            o.AnoPublicacao = Convert.ToUInt16(txtAnoPublicacao.Text);
            o.Paginas = Convert.ToUInt16(txtPaginas.Text);
            o.Altura = Convert.ToByte(txtAltura.Text);
            o.Largura = Convert.ToByte(txtLargura.Text);
            o.Peso = Convert.ToSingle(txtPeso.Text);

            RepositorioObra.Salvar(o);
        }
    }
}
