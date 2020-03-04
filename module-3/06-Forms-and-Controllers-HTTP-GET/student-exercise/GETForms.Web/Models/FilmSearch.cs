using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GETForms.Web.Models
{
    public class FilmSearch
    {
        public int MinLength { get; set; } = 0;
        public int MaxLength { get; set; } = 1000;
        public string Genre { get; set; }

        public IList<Film> Films{get; set;}
        
        public IList<string>GenreList { get; set; }

        //ref to both in searchresult
    }
}
