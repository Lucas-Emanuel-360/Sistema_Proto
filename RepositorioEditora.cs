namespace Sistema
{
    internal class RepositorioEditora
    {
        public static Editora Salvar(Editora editora)
        {
            using (var contextoBd = new Repositorio())
            {
                if (editora.Id == 0)
                {
                    // Novo Usuário
                    contextoBd.Editoras.Add(editora);
                }
                else
                {
                    // Atualização
                    Editora editoraAuxiliar = contextoBd.Editoras.Find(editora.Id);
                    contextoBd.Entry(editoraAuxiliar)
                        .CurrentValues.SetValues(editora);
                }

                contextoBd.SaveChanges();
            }

            // Usuário com FK
            return editora;
        }

        public static Editora LocalizarPorId(Int32 id)
        {
            using (var contextoBd = new Repositorio())
            {
                return contextoBd.Editoras.Find(id);
            }
        }

        public static List<Editora> LocalizarPorNome(Editora editora)
        {
            using (var contextoBd = new Repositorio())
            {
                // EF 6
                return contextoBd.Editoras
                    .Where(u => u.Nome.Contains(editora.Nome))
                    .ToList();

                // LINQ
                //return (List<Editora>)
                //    from u
                //    in contextoBd.Editoras
                //    where u.Nome.Contains(editora.Nome)
                //    select u;
            }
        }

        public static List<Editora> LocalizarTodos()
        {
            using (var contextoBd = new Repositorio())
            {
                return contextoBd.Editoras.ToList();
            }
        }

        public static List<Editora> LocalizarTodosOrdenados()
        {
            using (var contextoBd = new Repositorio())
            {
                return contextoBd.Editoras.OrderBy(u => u.Nome).ToList();
            }
        }

        public static void Apagar(Editora editora)
        {
            using (var contextoBd = new Repositorio())
            {
                // Estratégia 1:

                // SQL para consulta
                editora = contextoBd.Editoras.Find(editora.Id);

                // SQL para exclusão
                contextoBd.Editoras.Remove(editora);

                // Estratégia 2:

                // SQL única
                //contextoBd.Entry(new Editora() { Id = editora.Id })
                //    .State = System.Data.Entity.EntityState.Deleted;

                contextoBd.SaveChanges();
            }
        }

        /*public static Editora Autenticar(Editora editora) {
            using (var contextoBd = new Repositorio()) {
                // EF 6
                return contextoBd.Editoras
                    .Where(u =>
                        u.Email == editora.Email
                        && u.Senha == editora.Senha)
                    .SingleOrDefault();*/
        // LINQ
        //return (Editora)
        //    from u
        //    in contextoBd.Editoras
        //    where u.Nome == editora.Nome
        //        && u.Senha == editora.Senha
        //    select u;
        //}
    }
}