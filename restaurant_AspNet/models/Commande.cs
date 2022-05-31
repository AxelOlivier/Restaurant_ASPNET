using SQLite;
using System.ComponentModel.DataAnnotations;

namespace RestoApi.models
{
    [Table("Commande")]
    public class Commande
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("Table")]
        public int Table { get; set; }

        [Column("Alimentaire")]
        public int Alimentaire { get; set; }

        [Column("Etat")]
        public int Etat { get; set; }
    }
}
