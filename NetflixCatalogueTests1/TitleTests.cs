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
    public class TitleTests
    {
        [TestMethod()]
        public void GetNewTitleTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Title title = new Title();
            title.Hours = 4;
            title.Minutes = 18;
            title.Hours = title.Minutes;
            Assert.Fail();
        }
    }
}