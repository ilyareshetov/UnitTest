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
        public void TestArraysortanddel()
        {
            var res_arr = _setarray.SortAndFilter(new int[] { -4, -4, 0, -3, -5, -3, 2, 1, 4, 7, 5, 6, 8, 9, 9 });
            int[] b;
            b = new int[] { -5, -4, -3, 0, 1, 2, 4, 5, 6, 7, 8, 9, 9 };
            CollectionAssert.AreEqual(res_arr, b);
        }

        [TestMethod]
        public void TestArraysort()
        {
            var res_arr = _setarray.SortAndFilter(new int[] {-5, -7, -3, 9, 4, 7, 2, 5, 8});
            int[] b;
            b = new int[] {-7, -5, -3, 2, 4, 5, 7, 8, 9};
            CollectionAssert.AreEqual(res_arr, b);
        }

        [TestMethod]
        public void TestArraydelsamenegative()
        {
            var res_arr = _setarray.SortAndFilter(new int[] { -5, -5, -5, -3, -3, -1, -1, -1, 0, 3, 5 });
            int[] b;
            b = new int[] {-5, -3, -1, 0, 3, 5};
            CollectionAssert.AreEqual(res_arr, b);
        }
    }

    [TestClass]
    public class UnitTest3 //тесты для LinearEquationsSystem
    {
        LinearEquationsSystem _setcoeffs = new LinearEquationsSystem();
        
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestSetWrongCoeffs()
        {
            double[,] coeffs;
            coeffs = new double[,] { { 1, 2, 4, 5 }, { 5, 1, 2, 5 }, { 3, -1, 1, 6 }, { 3, -1, 1, 6 } };
            _setcoeffs.SetCoefficients(coeffs);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSetNullDeterm()
        {
            double[,] coeffs;
            coeffs = new double[,] { { 4, 0 }, { 4, 0 }};
            _setcoeffs.SetCoefficients(coeffs);

        }

        [TestMethod]
        public void TestSetMatrix2х2()
        {
            double[,] coeffs;
            double[] b;

            coeffs = new double[,] { { 2, 3 }, { 4, 2 } };
            double[] sec_free = new double[2] { -5, -7 };

            _setcoeffs.SetCoefficients(coeffs);
            double[] res = _setcoeffs.Solve(sec_free, 2);
            
            b = new double[] { -1.375, -0.75 };

            CollectionAssert.AreEqual(res, b);
        }

        [TestMethod]
        public void TestSetMatrix3х3()
        {
            double[,] coeffs;
            double[] b;

            coeffs = new double[,] { { 4, 8, 6 }, { 2, 6, -5 }, { 3, 5, 9 } };
            double[] third_free = new double[3] { 3, 8, 6 };

            _setcoeffs.SetCoefficients(coeffs);
            double[] res = _setcoeffs.Solve(third_free, 3);

            b = new double[] { -138.75, 59.25, 14 };

            CollectionAssert.AreEqual(res, b);
        }
    }
}