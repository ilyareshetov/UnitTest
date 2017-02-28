using System;
using NUnit.Framework;
using UnitTest;

namespace NUnitTestProject2
{
    [TestFixture]
    public class NUnitTest1 //тесты для StringFormatter
    {
        StringFormatter _setstring = new StringFormatter();

        [Test]
        public void NunitТestWebStrings()
        {
            string res = _setstring.WebString("google.ru");

            Assert.AreEqual(res, "http://google.ru");
        }
    }

    [TestFixture]
    public class UnitTest2 //тесты для ArrayProcessor
    {
        ArrayProcessor _setarray = new ArrayProcessor();

        [Test]
        public void NunitTestArraysortanddel()
        {
            var res_arr = _setarray.SortAndFilter(new int[] { -4, -4, 0, -3, -5, -3, 2, 1, 4, 7, 5, 6, 8, 9, 9 });
            int[] b;
            b = new int[] { -5, -4, -3, 0, 1, 2, 4, 5, 6, 7, 8, 9, 9 };
            CollectionAssert.AreEqual(res_arr, b);
        }
    }
        [TestFixture]
    public class NUnitTest3 //тесты для LinearEquationsSystem
    {
        LinearEquationsSystem _setcoeffs = new LinearEquationsSystem();

        [Test]
        public void NunitTestSetNullDeterm()
        {
            double[,] coeffs;
            coeffs = new double[,] { { 4, 0 }, { 4, 0 } };
            Assert.Throws<ArgumentException>( () => _setcoeffs.SetCoefficients(coeffs) );   
        }
    }
}