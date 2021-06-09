using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmazonPrimeAPI.Models
{
    public class Movie
    {
        public Guid id { get; internal set; }
        public String name { get; set; }
        public int duration { get; set; }
    }
}