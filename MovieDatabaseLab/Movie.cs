using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabaseLab
{
    public class Movie
    {
        public Movie(string argTitle, string argCategory, int argReleased)
        {
            Title = argTitle;
            Category = argCategory;
            Released = argReleased;
        }
        public string Title { get; set; }
        public string Category { get; set; }
        public int Released { get; set; }

        public void printMovieTitle()
        {
            Console.WriteLine(String.Format("{0, -15}{1, -15}", "Title: ", Title));
        }
        public void printMovieYear()
        {
            Console.WriteLine(String.Format("{0, -15}{1, -15}", "Released: ", Released));
        }
    }
}
