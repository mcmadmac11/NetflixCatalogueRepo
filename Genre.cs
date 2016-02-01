using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Contains list of Titles
// Implement custom iterator to iterate over those Titles
// Overload plus(+) operator to take in two Genres and return the aggregated Genre
// Overload plus (+) operator to take in a Genre and a Title to return the aggregated Genre
namespace NetflixCatalogue
{
    public class Genre : IEnumerable
    {
        public string Name;
        public KeyValuePair<Genre, Title> KeyValPair = new KeyValuePair<Genre, Title>();
        public List<Title> TitleList = new List<Title>();
        public Title title;
        public Genre genreRef;
        public Genre()
        {
            this.KeyValPair = new KeyValuePair<Genre, Title>();
            this.TitleList = new List<Title>();

        }
        public void SeedDictionary(Dictionary<Genre, Title> genreDictionary, Genre genre, Title title)
        {
            genreDictionary.Add(key: genre, value: title);
        }
        public List<Title> AddToTitleList(Title _title)
        {
            _title = title;
            TitleList.Add(_title);
            return TitleList;
        }
        public Genre(string genrename)
        {
            this.Name = genrename;
            this.TitleList = new List<Title>();
        }
        public string GetGenreName(string genreName)
        {
            return Name;
        }
        public static Genre operator +(Genre genre1, Genre genre2)
        {
            Genre _genre = new Genre();
            _genre.Name = string.Format("{0}{1}", genre1.Name, genre2.Name);
            return new Genre(_genre.GetGenreName(_genre.Name));
        }

        public enum Genres
        { All, Romance, Action, Comedy, Drama }

        public IEnumerator GetEnumerator()
        {
            return this.TitleList.GetEnumerator();
        }
        //public IEnumerator GetEnumerator()
        //{
        //    for (int i = 0; i < TitleList.Count; i++)
        //    {
        //        yield return TitleList[i].Name;
        //        Console.WriteLine(TitleList[i].Name.ToString());
        //    }

        //}

        public void Swap<T>(ref T firstValue, ref T secondValue)
        {
            T movie;
            movie = firstValue;
            firstValue = secondValue;
            secondValue = movie;
        }

        //public IEnumerable<Title> GetEnumerator()
        //{
        //    for (int i = 0; i <TitleList.Count; i++)
        //    {
        //        yield return (Title)GetEnumerator(); ;
        //    }


    } 
}
