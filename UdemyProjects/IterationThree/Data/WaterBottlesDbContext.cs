using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WaterBottlesApi.Models;

namespace WaterBottlesApi.Data
{
    public class WaterBottlesDbContext : DbContext
    {
        public DbSet<WaterBottles> waterBottles { get; set; }

        //DbSet<WaterBottles> waterBottles = new DbSet<WaterBottles>();
    }
}