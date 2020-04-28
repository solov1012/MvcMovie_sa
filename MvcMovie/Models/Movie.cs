using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Movie
    {
        public long Id { get; set; }
        public long id_movie { get; set; }
        public string Name { get; set; }
        public string Rating { get; set; }
        public string ActorsString { get; set; }
        public string DirectorsString { get; set; }
        public string TagsString { get; set; }
        public string Top10String { get; set; }
    }
}
