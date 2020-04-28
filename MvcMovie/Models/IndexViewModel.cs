using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MvcMovie.HelpClass;

namespace MvcMovie.Models
{
    public class IndexViewModel
    {
        public IEnumerable<Movie> Movies { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}
