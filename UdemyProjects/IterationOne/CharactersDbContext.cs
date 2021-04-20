using CharactersApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CharactersApi.Data
{
    public class CharactersDbContext : DbContext
    {
        public DbSet<Characters> Characters { get; set; }
    }
}