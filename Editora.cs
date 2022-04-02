namespace Sistema
{
    internal class Editora
    {
        public Int32 Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required]
        [StringLength(255)]
        public string Email { get; set; }
        public UInt64 Telefone { get; set; }

        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Email + ", " + Telefone;
        }

    }
}
