using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Exersise_2;

namespace FractionTest
{
    [TestClass]
    public class FractionTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "denome must mot contaic zero value")]
        public void TestZeroDenominator()
        {

            new Fraction(2, 0);
        }

        [TestMethod]
        public void TestToStringWithIntPart()
        {

            Fraction fraction1 = new Fraction(1, 2);
            Assert.AreEqual("(0+1/2)", fraction1.ToStringWithIntPart());

            Fraction fraction2 = new Fraction(3, 2);
            Assert.AreEqual("(1+1/2)", fraction2.ToStringWithIntPart());

            Fraction fraction3 = new Fraction(-5, 3);
            Assert.AreEqual("-(1+2/3)", fraction3.ToStringWithIntPart());

            Fraction fraction4 = new Fraction(0, 7);
            Assert.AreEqual("(0+0/7)", fraction4.ToStringWithIntPart());
        }

        [TestMethod]
        public void TestToDouble()
        {

            Fraction fraction1 = new Fraction(3, 4);
            Assert.AreEqual(0.75, fraction1.ToDouble());

            Fraction fraction2 = new Fraction(-2, 5);
            Assert.AreEqual(-0.4, fraction2.ToDouble());

            Fraction fraction3 = new Fraction(0, 9);
            Assert.AreEqual(0, fraction3.ToDouble());

            Fraction fraction4 = new Fraction(-5, -2);
            Assert.AreEqual(2.5, fraction4.ToDouble());
        }
        [TestMethod]

        public void TestAddition()
        {
            Fraction fraction1 = new Fraction(1, 2);
            Fraction fraction2 = new Fraction(3, 2);

            Fraction result = fraction1 + fraction2;

            Assert.AreEqual(result.Numerator, 2);
            Assert.AreEqual(result.Denominator, 1);

            Fraction fraction3 = new Fraction(-1, 2);
            Fraction fraction4 = new Fraction(8, -2);

            Fraction result2 = fraction3 + fraction4;

            Assert.AreEqual(result2.Numerator, -9);
            Assert.AreEqual(result2.Denominator, 2);

        }
        [TestMethod]
        public void TestSubtractionOperator()
        {
            Fraction fraction1 = new Fraction(3, 4);
            Fraction fraction2 = new Fraction(1, 4);

            Fraction result = fraction1 - fraction2;

            Assert.AreEqual(result.Numerator, 1);
            Assert.AreEqual(result.Denominator, 2);

            Fraction fraction3 = new Fraction(-1, 2);
            Fraction fraction4 = new Fraction(8, -2);

            Fraction result2 = fraction3 - fraction4;

            Assert.AreEqual(result2.Numerator, 7);
            Assert.AreEqual(result2.Denominator, 2);
        }

        [TestMethod]
        public void TestDivisionOperator() 
        {
            Fraction fraction1 = new Fraction(3, 4);
            Fraction fraction2 = new Fraction(1, 4);

            Fraction result = fraction1 / fraction2;

            Assert.AreEqual(result.Numerator, 3);
            Assert.AreEqual(result.Denominator, 1);

            Fraction fraction3 = new Fraction(-1, 2);
            Fraction fraction4 = new Fraction(8, -2);

            Fraction result2 = fraction3 / fraction4;

            Assert.AreEqual(result2.Numerator, 1);
            Assert.AreEqual(result2.Denominator, 8);
        }

        [TestMethod]

        public void TestMultiplyOperator()
        {
            Fraction fraction1 = new Fraction(3, 4);
            Fraction fraction2 = new Fraction(1, 4);

            Fraction result = fraction1 * fraction2;

            Assert.AreEqual(result.Numerator, 3);
            Assert.AreEqual(result.Denominator, 16);

            Fraction fraction3 = new Fraction(-1, 2);
            Fraction fraction4 = new Fraction(8, -2);

            Fraction result2 = fraction3 * fraction4;

            Assert.AreEqual(result2.Numerator, 2);
            Assert.AreEqual(result2.Denominator, 1);
        }


    }
}
