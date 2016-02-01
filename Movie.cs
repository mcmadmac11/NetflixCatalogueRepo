using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
//Movie(Inherits from Title)
//   Duration field
//   Overrides ToString() method to return a string of the name and duration of the movie
namespace NetflixCatalogue
{
    public class Movie : Title
    {
        int[] duration;
        public int[] GetDuration()
        {
            Title title = new Title();
            return this.duration = new int[2] { title.Hours, title.Minutes };
            
            
        }
        public Movie() { }
        public Movie(string name, int rating, int hours, int minutes)
        {
            Title movieTitle = new Title();
        }
        public Movie(string Name, int? Rating) { }
        public Movie(string name,int rating, int[] duration)
        {
            this.duration = GetDuration();
  
        }
        public override string ToString()
        {            
            string Time =  string.Format("Runtime: {0} hours, {1} minutes", duration[0],duration[1]);
            return Time;
            //return "Duration of Movie:" + Convert.ToString(RunTime);
            
        }
    }
}
