using SQLite;
using System.ComponentModel.DataAnnotations;

namespace RestoApi.models
{
    [Table("Alimentaire")]
    public class Alimentaire
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nom")]
        public string Nom { get; set; }

        [Column("TypeAliment")]
        public int TypeAliment { get; set; }
        
    }
}
