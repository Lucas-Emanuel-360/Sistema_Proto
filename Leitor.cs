namespace Sistema
{
    internal class Leitor
    {
        public Int32 Id { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public String Senha { get; set; }
        public Boolean Ativo { get; set; }

        public override String ToString()
        {
            return Id + ", " + Nome + ", " + Email + ", " + Senha + ", " + Ativo;
        }
    }
}
