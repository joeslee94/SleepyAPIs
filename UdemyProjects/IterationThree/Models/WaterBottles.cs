using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WaterBottlesApi.Models
{
    public class WaterBottles
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Size { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        [StringLength(30)]
        public string Brand { get; set; }
        public string CurrentDrink { get; set; }
        public string Color { get; set; }
    }
}