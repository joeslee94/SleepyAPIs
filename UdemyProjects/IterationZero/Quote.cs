using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QAPI.Models
{
    public class Quote
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Order { get; set; }
        public string Description { get; set; }

        //build to see if it works
    }
}