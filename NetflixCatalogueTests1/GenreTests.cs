using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetflixCatalogue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogue.Tests
{
    [TestClass()]
    public class GenreTests
    {
        Genre testGenre = new Genre();
        Movie testMovie = new Movie("test movie", 6, 2, 40);
        [TestMethod()]
        public void GetEnumeratorTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SeedDictionaryTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddToTitleListTest()
        {
            Title testTitle = new Title("John Cena is God", 100);
            testGenre.AddToTitleList(testTitle);
            Assert.AreEqual(100, testGenre.TitleList[0].Rating);
        }

        [TestMethod()]
        public void GenreTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetGenreNameTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetEnumeratorTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SwapTest()
        {
            Assert.Fail();
        }
    }
}