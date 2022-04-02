using System;
using System.ComponentModel.DataAnnotations;

namespace Sistema
{
    internal class Autor
    {
        [Key]
        public Int32 Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public DateTime Falecimento { get; internal set; }
        public Boolean Vivo { get; set; }

        public override string ToString()
        {
            return Id.ToString("00000")
                + "\n" + Nome
                + "\n" + Nascimento.ToString("dd/MM/yyyy")
                + "\n" + Falecimento.ToString("dd/MM/yyyy");
        }
    }
}