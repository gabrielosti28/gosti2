using System;
using System.ComponentModel.DataAnnotations;

namespace gosti2
{
    public class Mensagem
    {
        [Key]
        public int MensagemId { get; set; }

        [Required]
        public string Conteudo { get; set; }

        public DateTime DataEnvio { get; set; } = DateTime.Now;
        public bool Lida { get; set; } = false;

        // Chaves estrangeiras
        public int RemetenteId { get; set; }
        public virtual User Remetente { get; set; }

        public int DestinatarioId { get; set; }
        public virtual User Destinatario { get; set; }
    }
}