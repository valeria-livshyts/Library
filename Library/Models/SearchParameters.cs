using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class SearchParameters
    {
        public string Title { get; set; }
        public string Authors { get; set; }
        public string PublishingHouse { get; set; }
        public int? YearOfPublication { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
    }
}
