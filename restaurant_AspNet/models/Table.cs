using SQLite;
using System.ComponentModel.DataAnnotations;

namespace RestoApi.models
{
    [Table("Table")]
    public class Table
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("numTable")]
        public string NumTable { get; set; }

    }
}
