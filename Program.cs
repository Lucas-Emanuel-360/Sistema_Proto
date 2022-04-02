namespace Sistema
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmLogin());
            Application.Run(FrmLogin.GetInstance());


            return;


            //
            // Teste de Entidades
            //

            Usuario usuario = new Usuario
            {
                Id = 123,
                Nome = "Luis Guisso",
                Email = "mail@mail.com",
                Senha = "asdf",
                Nascimento = new DateTime(1980, 1, 1)
            };

            Console.WriteLine(usuario);

            //
            // Teste com operações CRUD no banco de dados
            // 

            //
            // (C) Inserção de dados
            //

            Console.WriteLine(">> RepositorioUsuario.Salvar(u1)");

            Usuario u1 = new Usuario();
            // u.Id = 0;
            u1.Nome = "Luis Guisso";
            u1.Email = "bguisso@mail.com";
            u1.Senha = "asdf";
            u1.Nascimento = new DateTime(1980, 1, 1);
            Console.WriteLine(u1);

            RepositorioUsuario.Salvar(u1);

            //
            // (R) Recuperação de dados
            //

            // -- Por id
            Console.WriteLine(">> RepositorioUsuario.LocalizarPorId(2)");

            Usuario u2 = RepositorioUsuario.LocalizarPorId(2);
            Console.WriteLine(u2);

            // -- Por nome
            Console.WriteLine(">> RepositorioUsuario.LocalizarPorNome(u1)");

            List<Usuario> us1 = RepositorioUsuario.LocalizarPorNome(u1);

            foreach (Usuario u in us1)
            {
                Console.WriteLine(u);
            }

            // -- Todos
            Console.WriteLine(">> RepositorioUsuario.LocalizarTodos()");

            List<Usuario> us2 = RepositorioUsuario.LocalizarTodos();

            foreach (Usuario u in us2)
            {
                Console.WriteLine(u);
            }

            //
            // (U) Atualização de dados
            //

            Console.WriteLine(">> RepositorioUsuario.Salvar(u1)");

            u1.Senha = "123456";

            Usuario u3 = RepositorioUsuario.Salvar(u1);

            Console.WriteLine(u3);

            //
            // (D) Exclusão de dados
            //

            Console.WriteLine(">> RepositorioUsuario.Apagar(u3)");

            RepositorioUsuario.Apagar(u3);

            List<Usuario> us3 = RepositorioUsuario.LocalizarTodos();

            foreach (Usuario u in us3)
            {
                Console.WriteLine(u);
            }

            //
            // Autenticação de usuário
            //

            Console.WriteLine(">> RepositorioUsuario.Autenticar(u4)");

            Usuario u4 = new Usuario();
            u4.Email = "admin@mail.com";
            u4.Senha = "asdf";

            u4 = RepositorioUsuario.Autenticar(u4);

            if (u4 == null)
            {
                Console.WriteLine("NÃO autenticado...");
            }
            else
            {
                Console.WriteLine("Autenticado!");
            }
        }
    }
}
