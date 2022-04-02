namespace Sistema
{
    internal class RepositorioObra
    {
        public static Obra Salvar(Obra obra)
        {
            using (var contextoBd = new Repositorio())
            {
                if (obra.Isbn == 0)
                {
                    // Novo Usuário
                    contextoBd.Obras.Add(obra);
                }
                else
                {
                    // Atualização
                    //Obra obraAuxiliar = contextoBd.Obras.Find(obra.Isbn);
                    //contextoBd.Entry(obraAuxiliar)
                    //.CurrentValues.SetValues(obra);
                }

                contextoBd.SaveChanges();
            }

            // Usuário com FK
            return obra;
        }

        public static Obra LocalizarPorIsbn(Int64 Isbn)
        {
            using (var contextoBd = new Repositorio())
            {
                return contextoBd.Obras.Find(Isbn);
            }
        }

        public static List<Obra> LocalizarPorNome(Obra Obra)
        {
            using (var contextoBd = new Repositorio())
            {
                // EF 6
                return contextoBd.Obras
                    .Where(u => u.Titulo.Contains(Obra.Titulo))
                    .ToList();

                // LINQ
                //return (List<Obra>)
                //    from u
                //    in contextoBd.Obras
                //    where u.Nome.Contains(Obra.Nome)
                //    select u;
            }
        }

        public static List<Obra> LocalizarTodos()
        {
            using (var contextoBd = new Repositorio())
            {
                return contextoBd.Obras.ToList();
            }
        }

        public static List<Obra> LocalizarTodosOrdenados()
        {
            using (var contextoBd = new Repositorio())
            {
                return contextoBd.Obras.OrderBy(u => u.Titulo).ToList();
            }
        }

        public static void Apagar(Obra Obra)
        {
            using (var contextoBd = new Repositorio())
            {
                // Estratégia 1:

                // SQL para consulta
                Obra = contextoBd.Obras.Find(Obra.Isbn);

                // SQL para exclusão
                contextoBd.Obras.Remove(Obra);

                // Estratégia 2:

                // SQL única
                //contextoBd.Entry(new Obra() { Isbn = Obra.Isbn })
                //    .State = System.Data.Entity.EntityState.Deleted;

                contextoBd.SaveChanges();
            }
        }
    }
}
