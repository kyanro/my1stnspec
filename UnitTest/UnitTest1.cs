using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KickMyAPI;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void コンストラクタに渡されたURIのチェック()
        {
            APIKicker kapi = new APIKicker("http://google.co.jp");
            Assert.AreEqual(kapi.GetURI(), "http://google.co.jp");
        }
        [TestMethod]
        public void コンストラクタに渡されたURIがyahooでも問題ないことを確認()
        {
            APIKicker kapi = new APIKicker("http://yahoo.co.jp");
            Assert.AreEqual(kapi.GetURI2(), "http://yahoo.co.jp");
        }
    }

}
