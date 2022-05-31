using SQLite;
using System.ComponentModel.DataAnnotations;

namespace RestoApi.models
{
    [Table("TypeAliment")]
    public class TypeAliment
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("libelle")]
        public string libelle { get; set; }
    }
}
