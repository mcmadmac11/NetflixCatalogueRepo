using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetflixCatalogue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogue.Tests
{
    [TestClass]
    public class TvShowTests
    {
        Genre testGenre = new Genre();
        TvShow test = new TvShow("NightRider", 10);
        Episode episode1 = new Episode("episode1", 6);
        Episode episode2 = new Episode("episode2", 4);
        [TestMethod]
        public void GetRatingTest()
        {            
            test.EpisodeList.Add(episode1);
            test.EpisodeList.Add(episode2);            
            Assert.AreEqual(5,test.GetRating());
        }

        [TestMethod]
        public void ToStringTest()
        {
            Assert.AreEqual(episode1.Name, "episode1");
        }
    }
}