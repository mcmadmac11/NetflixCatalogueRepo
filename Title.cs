using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogue
{
    public class Title 
    {
        public string Name;
        public int Rating;
        public int? _Rating;
        public int Hours;
        public int Minutes;

        public override string ToString()
        {
            return "Run Time: Hours:" + Hours + "  Minutes:" + Minutes;
        }
        public Title(string name,int rating)
        {
            this.Name = name;
            this.Rating = rating;
        }
        public Title(string name, int rating, int hours, int minutes)
        {
            this.Name = name;
            this.Rating = rating;
            this.Hours = hours;
            this.Minutes = minutes;
        }
        public Title(string name, int? rating)
        {
            this.Name = null;
            this.Name = null;
            this._Rating = null;
            
        }
        public Title GetNewTitle(string name, int rating, int hours, int minutes)
        {
            Name = name;
            Rating = rating;
            Hours = hours;
            Minutes = minutes;
            return new Title(Name, Rating, Hours, Minutes);
        }
        public string GetTitleName(string Name)
        {
            return Name;
        }

        public virtual int GetRating()
        {
            return Rating;
        }

        public int GetHours()
        {
            return Hours;
        }

        public int GetMinutes()
        {
            return Minutes;
        }
        public Title()
        {
        }
    }
}
