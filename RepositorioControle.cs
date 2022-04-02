namespace Sistema
{
    internal class RepositorioControle
    {
        public static Controle Salvar(Controle controle)
        {
            using (var contextoBd = new Repositorio())
            {
                if (controle.Id == 0)
                {
                    // Novo Usuário
                    contextoBd.Controles.Add(controle);
                }
                else
                {
                    // Atualização
                    Controle controleAuxiliar = contextoBd.Controles.Find(controle.Id);
                    contextoBd.Entry(controleAuxiliar)
                        .CurrentValues.SetValues(controle);
                }

                contextoBd.SaveChanges();
            }

            // Usuário com FK
            return controle;
        }

        public static Controle LocalizarPorId(Int32 id)
        {
            using (var contextoBd = new Repositorio())
            {
                return contextoBd.Controles.Find(id);
            }
        }

        /*public static List<Controle> LocalizarPorNome(Controle controle)
        {
            using (var contextoBd = new Repositorio())
            {
                // EF 6
                return contextoBd.Controles
                    .Where(u => u.Nome.Contains(controle.Nome))
                    .ToList();

                // LINQ
                //return (List<Controle>)
                //    from u
                //    in contextoBd.Controles
                //    where u.Nome.Contains(controle.Nome)
                //    select u;
            }
        }*/

        public static List<Controle> LocalizarTodos()
        {
            using (var contextoBd = new Repositorio())
            {
                return contextoBd.Controles.ToList();
            }
        }

        /*public static List<Controle> LocalizarTodosOrdenados()
        {
            using (var contextoBd = new Repositorio())
            {
                return contextoBd.Controles.OrderBy(u => u.Nome).ToList();
            }
        }*/

        /*public static void Apagar(Controle controle)
        {
            using (var contextoBd = new Repositorio())
            {
                // Estratégia 1:

                // SQL para consulta
                controle = contextoBd.Controles.Find(controle.Id);

                // SQL para exclusão
                contextoBd.Controles.Remove(controle);

                // Estratégia 2:

                // SQL única
                //contextoBd.Entry(new Controle() { Id = controle.Id })
                //    .State = System.Data.Entity.EntityState.Deleted;

                contextoBd.SaveChanges();
            }
        }*/

        /*public static Controle Autenticar(Controle controle)
        {
            using (var contextoBd = new Repositorio())
            {
                // EF 6
                return contextoBd.Controles
                    .Where(u =>
                        u.Email == controle.Email
                        && u.Senha == controle.Senha)
                    .SingleOrDefault();*/

        // LINQ
        //return (Controle)
        //    from u
        //    in contextoBd.Controles
        //    where u.Nome == controle.Nome
        //        && u.Senha == controle.Senha
        //    select u;
    }
}
