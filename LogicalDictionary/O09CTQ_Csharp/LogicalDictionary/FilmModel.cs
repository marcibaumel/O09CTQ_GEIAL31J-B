using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalDictionary
{
    public class FilmModel
    {
        public String Title { get; set; }
        public String Year { get; set; }
        public String Plot { get; set; }
        public String Director { get; set; }
        public String ImdbRating { get; set; }
        public String Runtime { get; set; }
        public String Actors { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }

        public FilmModel(string title, string year, string plot, string director, string imdbRating, string runtime, string actors)
        {
            Title = title;
            Year = year;
            Plot = plot;
            Director = director;
            ImdbRating = imdbRating;
            Runtime = runtime;
            Actors = actors;
        }

        public FilmModel(){}
    }
}
