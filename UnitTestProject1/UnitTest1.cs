using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1 //тесты для StringFormatter
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

        [TestMethod]
        public void TestNoshttpStrings()
        {
            string res = _setstring.WebString("http://secure.google.ru");

            Assert.AreEqual(res, "https://secure.google.ru");
        }
    }

        [TestClass]
        public class UnitTest2 //тесты для ArrayProcessor
        {
        ArrayProcessor _setarray = new ArrayProcessor();

        [TestMethod]
        public void TestArraySetNum()
        { 
            var res_arr = _setarray.SortAndFilter(new int[] {-4, -4, -4, -3, -5, -3, 2, 1, 4, 7, 5, 6, 8, 9});
            int[] b;
            b = new int[] {-5, -4, -3, 1, 2, 4, 5, 6, 7, 8, 9};
            CollectionAssert.AreEqual(res_arr, b);
        }
    }
}
