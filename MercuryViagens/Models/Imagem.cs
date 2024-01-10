using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MercuryViagens.Models
{
    [Table("imagem")]
    public class Imagem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("conteudo")]
        public byte[] Conteudo { get; set; }

        [Column("fk_destino_id")]
        public int DestinoId { get; set; }
    }
}
