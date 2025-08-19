using System;
using System.ComponentModel.DataAnnotations;

namespace gosti2
{
    public class Livro
    {
        [Key]
        public int LivroId { get; set; }

        [Required, MaxLength(200)]
        public string Titulo { get; set; }

        [Required, MaxLength(100)]
        public string Autor { get; set; }

        [Required, MaxLength(50)]
        public string Categoria { get; set; } // Terror, Filosofia, Romance, etc.

        public string Descricao { get; set; }
        public byte[] Capa { get; set; }
        public DateTime DataAdicao { get; set; } = DateTime.Now;

        // Chave estrangeira
        public int UserId { get; set; }
        public virtual User Usuario { get; set; }
    }
}