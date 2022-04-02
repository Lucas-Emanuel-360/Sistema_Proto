namespace Sistema
{
    internal class Controle
    {
        public Int32 Id { get; set; }
        public DateTime Emprestimo { get; set; }
        public DateTime Devolucao { get; set; }

        [Required]
        [MaxLength(500)]
        public String Observacoes { get; set; }

        public Boolean emAtraso()
        {
            if (DateTime.Now < Devolucao)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return Id + ", " + Emprestimo + ", " + Devolucao + ", " + Observacoes + ". Em atraso é:" + emAtraso();
        }
    }
}