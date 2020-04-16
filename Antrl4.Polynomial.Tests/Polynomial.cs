using System;
using Xunit;

namespace Antrl4.Polynomial.Tests
{
    public class Polynomial
    {
        [Theory]
        [InlineData("x^10", 0, 0)]
        [InlineData("x^10", 1, 1)]
        [InlineData("5*x^2+x", 1, 6)]
        [InlineData("5x^2+x", 1, 6)]
        [InlineData("x^2-x", 1, 0)]
        [InlineData("x^2+x^1+x^0", 2, 7)]
        [InlineData("x^2+x^1+1", 2, 7)]
        [InlineData("-x^2+x^1+1", 2, -1)]
        [InlineData("-x^2-x^1+1", 2, -5)]
        [InlineData("-x^2-x^1-1", 2, -7)]
        [InlineData("x+x^2+1", 2, 7)]
        [InlineData("-1+x^2+x^1+1", 2, 6)]
        [InlineData("x^2+x^1-6", 2, 0)]
        [InlineData("x^5+x^1+1", 2, 35)]
        [InlineData("1", 2, 1)]
        [InlineData("1", 3, 1)]
        [InlineData("x^3", 3, 27)]
        public void TestValutazionePolinomio(string poli, double x, double result)
        {
            //var valutatore = new Evaluator(poli);

            //Assert.Equal(valutatore.Eval(x), result);
        }
    }
}
