using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibraryMath;

namespace ClassLibraryMathTest
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void Sum_2and3_expected5()
        {
            //arrange
            int a = 2, b = 3;
            int expected = 5;

            //act
            Calc calc = new Calc();
            int actual = calc.Sum(a, b);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Max_2and3_expected3()
        {
            int a = 2, b = 3;
            double expected = 3;

            Calc calc = new Calc();
            double actual = calc.Max(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}
