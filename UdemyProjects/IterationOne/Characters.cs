using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharactersApi.Models
{
    public class Characters
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public char Gender { get; set; }
    }
}