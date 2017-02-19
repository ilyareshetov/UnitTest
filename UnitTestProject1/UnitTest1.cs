using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestWebStrings()
        {
            StringFormatter _setstring = new StringFormatter();

            string res = _setstring.WebString("google.ru");

            Assert.AreEqual(res, "http://google.ru");
        }
    }
}
