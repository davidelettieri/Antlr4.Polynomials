using System;
using System.Collections.Generic;
using Xunit;

namespace Antrl4.Polynomial.Tests
{
    public class Polynomial
    {
        [Theory]
        [InlineData("1", 2, 1)]
        [InlineData("1", 3, 1)]
        [InlineData("x^3", 3, 27)]
        [InlineData("x^10", 0, 0)]
        [InlineData("x^10", 1, 1)]
        [InlineData("x+10", 1, 11)]
        [InlineData("x-1", 1, 0)]
        [InlineData("5*x", 2, 10)]
        [InlineData("5*x^2", 2, 20)]
        [InlineData("5*x^2+x", 1, 6)]
        [InlineData("5x^2+x", 1, 6)]
        [InlineData("x^2-x", 1, 0)]
        [InlineData("x^2+x^1+x^0", 2, 7)]
        [InlineData("x^2+x^1+1", 2, 7)]
        [InlineData("-x^2+x^1+1", 2, -1)]
        [InlineData("x+x^2+1", 2, 7)]
        [InlineData("-1+x^2+x^1+1", 2, 6)]
        [InlineData("x^2+x^1-6", 2, 0)]
        [InlineData("x^5+x^1+1", 2, 35)]
        [InlineData("-x^2-x^1-1", 2, -7)]
        [InlineData("-x^2-x^1+1", 2, -5)]
        [InlineData("x^2-x^1+1", 2, 3)]
        public void TestValutazionePolinomioUnicaVariabile(string poli, double x, double result)
        {
            var evaluator = new Evaluator(poli);
            var d = new Dictionary<char, double>() { { 'x', x } };
            Assert.Equal(result, evaluator.Eval(d));
        }

        [Theory]
        [InlineData("xy", 2, 1, 2)]
        [InlineData("xy+x^2y^2", 2, 2, 20)]
        [InlineData("xy+x^2y^2-10", 2, 2, 10)]
        [InlineData("xy+x^2y^2-x-2y-1", 2, 2, 13)]
        public void TestValutazionePolinomioDueVariabili(string poli, double x, double y, double result)
        {
            var evaluator = new Evaluator(poli);
            var d = new Dictionary<char, double>() { { 'x', x }, { 'y', y } };
            Assert.Equal(result, evaluator.Eval(d));
        }
    }
}
