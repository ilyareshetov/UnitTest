using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        StringFormatter _setstring = new StringFormatter();

        [TestMethod]
        public void TestWebStrings()
        {
            string res = _setstring.WebString("google.ru");

            Assert.AreEqual(res, "http://google.ru");
        }

        [TestMethod]
        public void TestSexStrings()
        {
            string res = _setstring.WebString("secure.google.ru");

            Assert.AreEqual(res, "https://secure.google.ru");
        }

        [TestMethod]
        public void TestNullStrings()
        {
            string res = _setstring.WebString("");

            Assert.AreEqual(res, "ErrorNullString");
        }

        [TestMethod]
        public void TestHttpStrings()
        {
            string res = _setstring.WebString("http://google.ru");

            Assert.AreEqual(res, "http://google.ru");
        }

        [TestMethod]
        public void TestHttpsStrings()
        {
            string res = _setstring.WebString("https://secure.google.ru");

            Assert.AreEqual(res, "https://secure.google.ru");
        }
    }
}
