using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Filmierung.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public bool Aktiv { get; set; }
        public int PriceId { get; set; }
        public int Rating { get; set; }
        // Change V02
        public bool Ab18 { get; set; }

    }
}