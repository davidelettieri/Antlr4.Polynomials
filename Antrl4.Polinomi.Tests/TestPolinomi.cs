using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Antrl4.Polinomi.Tests
{
    [TestClass]
    public class TestPolinomi
    {
        [DataRow("x^10", 0, 0)]
        [DataRow("x^10", 1, 1)]
        [DataRow("5*x^2+x", 1, 6)]
        [DataRow("5x^2+x", 1, 6)]
        [DataRow("x^2-x", 1, 0)]
        [DataRow("x^2+x^1+x^0", 2, 7)]
        [DataRow("x^2+x^1+1", 2, 7)]
        [DataTestMethod]
        public void TestValutazionePolinomio(string poli, double x, double result)
        {
            var valutatore = new Evaluator(poli);

            Assert.AreEqual(valutatore.Eval(x), result);
        }
    }
}
