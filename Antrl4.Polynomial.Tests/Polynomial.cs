using System;
using System.Collections.Generic;
using Xunit;

namespace Antrl4.Polynomial.Tests
{
    public class Polynomial
    {
        [Theory(DisplayName = "Test evaluation of polynomial with only one variable")]
        [InlineData("x^2+5x+1", 1, 7)]
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
        public void TestEvaluationOnlyX(string poli, double x, double result)
        {
            var evaluator = new Evaluator(poli);
            var d = new Dictionary<char, double>() { { 'x', x } };
            Assert.Equal(result, evaluator.Eval(d));
        }

        [Theory(DisplayName = "Test evaluation of polynomial with two variables")]
        [InlineData("xy", 2, 1, 2)]
        [InlineData("xy+x^2y^2", 2, 2, 20)]
        [InlineData("xy+x^2y^2-10", 2, 2, 10)]
        [InlineData("xy+x^2y^2-x-2y-1", 2, 2, 13)]
        [InlineData("-xy+x^2y^2-x-2y-1", 2, 2, 5)]
        public void TestEvaluationXY(string poli, double x, double y, double result)
        {
            var evaluator = new Evaluator(poli);
            var d = new Dictionary<char, double>() { { 'x', x }, { 'y', y } };
            Assert.Equal(result, evaluator.Eval(d), 15);
        }

        [Theory(DisplayName = "Test evaluation of polynomial with polynomial exponent")]
        [InlineData("x^y", 2, 3, 8)]
        [InlineData("x^(x+y)", 2, 2, 16)]
        public void TestPolynomialWithPolynomialExp(string poli, double x, double y, double result)
        {
            var evaluator = new Evaluator(poli);
            var d = new Dictionary<char, double>() { { 'x', x }, { 'y', y } };
            Assert.Equal(result, evaluator.Eval(d), 15);
        }

        [Theory(DisplayName = "Other tests")]
        [InlineData("(x+2)^2", 2, 16)]
        [InlineData("(x-1)^10", 1, 0)]
        [InlineData("(x-0.1)^2", 0, 0.01)]
        public void OtherTest(string poli, double x, double result)
        {
            var evaluator = new Evaluator(poli);
            var d = new Dictionary<char, double>() { { 'x', x } };
            Assert.Equal(result, evaluator.Eval(d),15);
        }
    }
}
