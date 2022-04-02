namespace Sistema
{
    internal class RepositorioAutor
    {
        public static Autor Salvar(Autor autor)
        {
            using (var contextoBd = new Repositorio())
            {
                if (autor.Id == 0)
                {
                    // Novo Autor
                    contextoBd.Autores.Add(autor);
                }
                else
                {
                    // Atualização
                    Autor autorAuxiliar = contextoBd.Autores.Find(autor.Id);
                    contextoBd.Entry(autorAuxiliar)
                        .CurrentValues.SetValues(autor);
                }

                contextoBd.SaveChanges();
            }

            // Autor com FK
            return autor;
        }

        public static Autor LocalizarPorId(Int32 id)
        {
            using (var contextoBd = new Repositorio())
            {
                return contextoBd.Autores.Find(id);
            }
        }

        public static List<Autor> LocalizarPorNome(Autor autor)
        {
            using (var contextoBd = new Repositorio())
            {
                // EF 6
                return contextoBd.Autores
                    .Where(u => u.Nome.Contains(autor.Nome))
                    .ToList();

                // LINQ
                //return (List<Usuario>)
                //    from u
                //    in contextoBd.Usuarios
                //    where u.Nome.Contains(usuario.Nome)
                //    select u;
            }
        }

        public static List<Autor> LocalizarTodos()
        {
            using (var contextoBd = new Repositorio())
            {
                return contextoBd.Autores.ToList();
            }
        }

        public static List<Autor> LocalizarTodosOrdenados()
        {
            using (var contextoBd = new Repositorio())
            {
                return contextoBd.Autores.OrderBy(u => u.Nome).ToList();
            }
        }

        public static void Apagar(Autor autor)
        {
            using (var contextoBd = new Repositorio())
            {
                // Estratégia 1:

                // SQL para consulta
                autor = contextoBd.Autores.Find(autor.Id);

                // SQL para exclusão
                contextoBd.Autores.Remove(autor);

                // Estratégia 2:

                // SQL única
                //contextoBd.Entry(new Usuario() { Id = usuario.Id })
                //    .State = System.Data.Entity.EntityState.Deleted;

                contextoBd.SaveChanges();
            }
        }

        /*public static Usuario Autenticar(Usuario usuario) {
            using (var contextoBd = new Repositorio()) {
                // EF 6
                return contextoBd.Usuarios
                    .Where(u =>
                        u.Email == usuario.Email
                        && u.Senha == usuario.Senha)
                    .SingleOrDefault();*/

        // LINQ
        //return (Usuario)
        //    from u
        //    in contextoBd.Usuarios
        //    where u.Nome == usuario.Nome
        //        && u.Senha == usuario.Senha
        //    select u;
        //}
        //}
    }
}