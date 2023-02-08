using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase
{
    public class Movies
    {
        public string movieTitle;
        public string movieCategory;

        public Movies(string title, string category) {
            movieTitle = title;
            movieCategory = category;
        }
    }
}
