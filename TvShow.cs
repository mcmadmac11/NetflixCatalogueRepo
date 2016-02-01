using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogue
{
    public class TvShow : Title
    {
        public string Name;
        public int Rating;
        public List<Episode> EpisodeList = new List<Episode>();

        public TvShow()
        {

        }
        public TvShow(string name, int rating) : base(name,rating)
        {
            Name = name;
            this.Rating = rating;            
        }

        public override int GetRating()
        {
            int averageEpisodeRating = 0;
            List<int> episodeRatingsList = new List<int>();
            foreach (Episode e in EpisodeList)
            {
                episodeRatingsList.Add(e.Rating);
            }
            averageEpisodeRating = episodeRatingsList.Sum() / episodeRatingsList.Count();
            return averageEpisodeRating;
        }
        public override string ToString()
        {
            return "Show: " + GetTitleName(Name) + "\nNumber of Episodes: " + EpisodeList.Count.ToString();

        }

    }
}
