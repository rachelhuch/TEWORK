using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldDB.Models
{
    public class Country
   
      
        {
            public string code { get; set; }
            public string Name { get; set; }
            public string Continent { get; set; }

            public string Region { get; set; }

            public double SurfaceArea { get; set; }

            public int? IndependenceYear { get; set; }

            public int Population { get; set; }

            public double? LifeExpectancy { get; set; }

            public decimal? gnp { get; set; }

            public string LocalName { get; set; }

            public string GovernmentForm { get; set; }

            public string HeadOfState { get; set; }
            public int? CapitalId
            {
                get; set;


       public string Code2 { get; set; }

            public override string ToString()
            {
            }
}
