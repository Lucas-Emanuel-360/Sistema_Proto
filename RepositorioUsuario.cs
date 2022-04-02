namespace Sistema
{
    internal class RepositorioUsuario
    {
        public static Usuario Salvar(Usuario usuario)
        {
            using (var contextoBd = new Repositorio())
            {
                if (usuario.Id == 0)
                {
                    // Novo Usuário
                    contextoBd.Usuarios.Add(usuario);
                }
                else
                {
                    // Atualização
                    Usuario usuarioAuxiliar = contextoBd.Usuarios.Find(usuario.Id);
                    contextoBd.Entry(usuarioAuxiliar)
                        .CurrentValues.SetValues(usuario);
                }

                contextoBd.SaveChanges();
            }

            // Usuário com FK
            return usuario;
        }

        public static Usuario LocalizarPorId(Int32 id)
        {
            using (var contextoBd = new Repositorio())
            {
                return contextoBd.Usuarios.Find(id);
            }
        }

        public static List<Usuario> LocalizarPorNome(Usuario usuario)
        {
            using (var contextoBd = new Repositorio())
            {
                // EF 6
                return contextoBd.Usuarios
                    .Where(u => u.Nome.Contains(usuario.Nome))
                    .ToList();

                // LINQ
                //return (List<Usuario>)
                //    from u
                //    in contextoBd.Usuarios
                //    where u.Nome.Contains(usuario.Nome)
                //    select u;
            }
        }

        public static List<Usuario> LocalizarTodos()
        {
            using (var contextoBd = new Repositorio())
            {
                return contextoBd.Usuarios.ToList();
            }
        }

        public static List<Usuario> LocalizarTodosOrdenados()
        {
            using (var contextoBd = new Repositorio())
            {
                return contextoBd.Usuarios.OrderBy(u => u.Nome).ToList();
            }
        }

        public static void Apagar(Usuario usuario)
        {
            using (var contextoBd = new Repositorio())
            {
                // Estratégia 1:

                // SQL para consulta
                usuario = contextoBd.Usuarios.Find(usuario.Id);

                // SQL para exclusão
                contextoBd.Usuarios.Remove(usuario);

                // Estratégia 2:

                // SQL única
                //contextoBd.Entry(new Usuario() { Id = usuario.Id })
                //    .State = System.Data.Entity.EntityState.Deleted;

                contextoBd.SaveChanges();
            }
        }

        public static Usuario Autenticar(Usuario usuario)
        {
            using (var contextoBd = new Repositorio())
            {
                // EF 6
                return contextoBd.Usuarios
                    .Where(u =>
                        u.Email == usuario.Email
                        && u.Senha == usuario.Senha)
                    .SingleOrDefault();
                // LINQ
                //return (Usuario)
                //    from u
                //    in contextoBd.Usuarios
                //    where u.Nome == usuario.Nome
                //        && u.Senha == usuario.Senha
                //    select u;
            }
        }
    }
}