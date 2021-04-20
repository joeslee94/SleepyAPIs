using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CharactersApiTwo.Models
{
    public class Characters
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string FavFood { get; set; }
        [Required]
        [StringLength(1)]
        public string PlotImportance { get; set; }
        public int TotalInteractions { get; set; }
    }
}