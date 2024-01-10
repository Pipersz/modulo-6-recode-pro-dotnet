using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MercuryViagens.Models
{
    [Table("pacoteviagem")]
    public class PacoteViagem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [DataType(DataType.Date)]
        [Column("data_ida")]
        public DateTime DataIda { get; set; }

        [DataType(DataType.Date)]
        [Column("data_volta")]
        public DateTime DataVolta { get; set; }

        [Column("preco")]
        public double Preco { get; set; }

        [Column("num_max_prestacoes")]
        public int NumMaxPrestacoes { get; set; }

        [Column("fk_destino_id")]
        public int DestinoId { get; set; }

        public Destino Destino { get; set; }
    }
}
