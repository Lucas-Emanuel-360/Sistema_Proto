namespace Sistema
{
    public class Obra
    {
        [Key]
        public Int64 Isbn { get; set; }
        [StringLength(255)]
        public String Titulo { get; set; }
        public Byte Edicao { get; set; }
        public UInt16 AnoPublicacao { get; set; }
        public UInt16 Paginas { get; set; }
        public Byte Altura { get; set; }
        public Byte Largura { get; set; }
        public Single Peso { get; set; }

    }
}
