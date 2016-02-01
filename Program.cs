using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create the genres: All, Romance, Action, Comedy.They need to share some titles(such as Romantic Comedies) by reference, not by duplicating the title itself.
//Utilize the null operators we covered in class.
//Utilize appropriate access modifiers.
namespace NetflixCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            #region TvShow
            //TvShow Fargo = new TvShow("Fargo", 9);
            //Episode fargoPilot = new Episode("pilot", 7);
            //Episode fargo2 = new Episode("fargo2", 8);
            //Episode fargo3 = new Episode("fargo3", 6);
            //Fargo.EpisodeList.Add(fargoPilot);
            //Fargo.EpisodeList.Add(fargo2);
            //Fargo.EpisodeList.Add(fargo3);
            //Fargo.GetRating();
            //Fargo.ToString();
            //Console.WriteLine(Fargo.ToString());


            #endregion


            Genre Comedy = new Genre("Comedy");
            Genre Romance = new Genre("Romance");
            Genre Action = new Genre("Action");
            Genre Drama = new Genre("Drama");
            //Dictionary<Genre, Title> ComedyDictionary = new Dictionary<Genre, Title>();
            Title OldSchool = new Title("Old School", 8, 1, 45);
            Title DumbAndDumber = new Title("Dumb & Dumber", 9, 1, 44);
            Title CaddyShack = new Title("Caddy Shack", 10, 1, 51);
            Title TheBreakup = new Title("The Breakup", 5, 1, 51);

            Title TheNotebook = new Title("The Notebook", 3, 2, 44);
            Title Titanic = new Title("Titanic", 4, 8, 55);
            Title WhenHarryMetSally = new Title("When Harry Met Sally", 7, 2, 12);
            Romance.TitleList.Add(TheNotebook);
            Romance.TitleList.Add(TheBreakup);
            Romance.TitleList.Add(Titanic);
            Romance.TitleList.Add(WhenHarryMetSally);
            Romance.GetEnumerator();

            
            Comedy.TitleList.Add(OldSchool);
            Comedy.TitleList.Add(DumbAndDumber);
            Comedy.TitleList.Add(CaddyShack);
            Comedy.TitleList.Add(TheBreakup);
            

            Comedy.GetEnumerator();
            Console.ReadLine();




        }
    }
}
