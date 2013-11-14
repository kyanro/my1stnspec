using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KickMyAPI;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void checkURI()
        {
            APIKicker kapi = new APIKicker("http://google.co.jp");
            Assert.AreEqual(kapi.GetURI(), "http://google.co.jp");
        }
    }
}
