namespace Sistema
{
    internal class RepositorioLeitor
    {
        public static Leitor Salvar(Leitor leitor)
        {
            using (var contextoBd = new Repositorio())
            {
                if (leitor.Id == 0)
                {
                    // Novo Usuário
                    contextoBd.Leitores.Add(leitor);
                }
                else
                {
                    // Atualização
                    Leitor leitorAuxiliar = contextoBd.Leitores.Find(leitor.Id);
                    contextoBd.Entry(leitorAuxiliar)
                        .CurrentValues.SetValues(leitor);
                }

                contextoBd.SaveChanges();
            }

            // Usuário com FK
            return leitor;
        }

        public static Leitor LocalizarPorId(Int32 id)
        {
            using (var contextoBd = new Repositorio())
            {
                return contextoBd.Leitores.Find(id);
            }
        }

        public static List<Leitor> LocalizarPorNome(Leitor leitor)
        {
            using (var contextoBd = new Repositorio())
            {
                // EF 6
                return contextoBd.Leitores
                    .Where(u => u.Nome.Contains(leitor.Nome))
                    .ToList();

                // LINQ
                //return (List<Leitor>)
                //    from u
                //    in contextoBd.Leitores
                //    where u.Nome.Contains(leitor.Nome)
                //    select u;
            }
        }

        public static List<Leitor> LocalizarTodos()
        {
            using (var contextoBd = new Repositorio())
            {
                return contextoBd.Leitores.ToList();
            }
        }

        public static List<Leitor> LocalizarTodosOrdenados()
        {
            using (var contextoBd = new Repositorio())
            {
                return contextoBd.Leitores.OrderBy(u => u.Nome).ToList();
            }
        }

        public static void Apagar(Leitor leitor)
        {
            using (var contextoBd = new Repositorio())
            {
                // Estratégia 1:

                // SQL para consulta
                leitor = contextoBd.Leitores.Find(leitor.Id);

                // SQL para exclusão
                contextoBd.Leitores.Remove(leitor);

                // Estratégia 2:

                // SQL única
                //contextoBd.Entry(new Leitor() { Id = leitor.Id })
                //    .State = System.Data.Entity.EntityState.Deleted;

                contextoBd.SaveChanges();
            }
        }

        /*public static Leitor Autenticar(Leitor leitor) {
            using (var contextoBd = new Repositorio()) {
                // EF 6
                return contextoBd.Leitores
                    .Where(u =>
                        u.Email == leitor.Email
                        && u.Senha == leitor.Senha)
                    .SingleOrDefault();*/
        // LINQ
        //return (Leitor)
        //    from u
        //    in contextoBd.Leitores
        //    where u.Nome == leitor.Nome
        //        && u.Senha == leitor.Senha
        //    select u;
    }
}