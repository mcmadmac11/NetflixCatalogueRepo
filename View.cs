using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Prints out the various Genres and their Titles
namespace NetflixCatalogue
{
    public class View
    {
        public static void displayData(string Name,int Rating)
        {
            string name = Name;
            int rating = Rating;          
            Console.WriteLine("\n\nComedy Movies: {0} \nRating: {1}", Name,Rating);
        }

        public static void displayGenre(Genre genre)
        {
            Genre Genre = genre;
            
        }





    }
}
