using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogue
{
    public class Episode
    {


        TvShow tvShow;
        public string Name;
        public int Rating;
        public Episode(string name, int rating)
        {
            
            this.Name = name;
            this.Rating = rating;
        }

        
        //public void AddEpisodesToList()
        //{
        //    tvShow.EpisodeList.ForEach((Episode) => Console.WriteLine("episode: {0}", Episode.Rating));
        //    tvShow.EpisodeList.Add(new Episode(Name,Rating));
        //}
    }
}
