using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filmierung.Models
{
    public class Movie
    {
        public static void setMoviesInactive(FormCollection collection)
        {
            foreach (Movie movie in collection)
                movie.Aktiv = false;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public bool Aktiv { get; set; }
        public int PriceId { get; set; }
        private int rating;
        public int Rating {
            get { return rating; }
            set
            {
                if (value > 0)
                    rating = value;
            }
        }
        // Change V02
        public bool Ab18 { get; set; }

        public void setBackRating()
        {
            this.Rating = 18;
        }
    }
}