using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaAppProject
{
    class Movie
    {
        public static string MovieName;
        public static string MovieHall;
        public static string MovieTime;
        public static int MoviePrice;

        public Movie(string moviename, string moviehall, string movietime, int movieprice )
        {
            MovieName = moviename;
            MovieHall = moviehall;
            MovieTime = movietime;
            MoviePrice = movieprice;
        }
    }
}
