﻿using SQLite;
using System.ComponentModel.DataAnnotations;

namespace RestoApi.models
{
    [Table("Etat")]
    public class Etat
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("libelle")]
        public string libelle { get; set; }
    }
}
