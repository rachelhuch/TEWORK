﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Forms.Web.Models
{
 /*** TODO 04: Add model validations
 * Name: Required, string length max 64
 * CountryCode: Display Name = Country Code, Required, String Length = 3
 * District: Required
 * Population: Required, Range 1-99,999,999
 ***/

    public class City
    {
        public int CityId { get; set; }

        [Required]
        [StringLength(64)]
        public string Name { get; set; }
        
        [Required]
        [StringLength(3, MinimumLength=3)]

        public string CountryCode { get; set; }
        
        [Required]
        public string CountryName { get; set; }

        public string District { get; set; }

        [Range(1, 99999999)]
        public int Population { get; set; }

        public City() { }

        public City(int cityId, String name, string countryCode, string countryName, string district, int population)
        {
            CityId = cityId;
            Name = name;
            CountryCode = countryCode;
            CountryName = countryName;
            District = district;
            Population = population;
        }
    }
}
