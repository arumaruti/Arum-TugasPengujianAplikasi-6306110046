using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculatorv1;

namespace CalcUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodAdd()
        {
            MainWindow main = new MainWindow();
            double result = main.add(4, 2);
            double expect = 6;
            Assert.AreEqual(expect, result, "Maaf, Jawaban Anda Salah");
        }

        [TestMethod]
        public void TestMethodSubstraction()
        {
            MainWindow main = new MainWindow();
            double result = main.substraction(8, 3);
            double expect = 5;
            Assert.AreEqual(expect, result, "Maaf, Jawaban Anda Salah");
        }

        [TestMethod]
        public void TestMethodMultiplication()
        {
            MainWindow main = new MainWindow();
            double result = main.multiplication(9, 8);
            double expect = 72;
            Assert.AreEqual(expect, result, "Maaf, Jawaban Anda Salah");
        }

        [TestMethod]
        public void TestMethodDivision()
        {
            MainWindow main = new MainWindow();
            double result = main.division(100, 5);
            double expect = 20;
            Assert.AreEqual(expect, result, "Maaf, Jawaban Anda Salah");
        }
    }
}
