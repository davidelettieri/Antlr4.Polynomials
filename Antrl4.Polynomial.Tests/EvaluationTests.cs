using Antrl4.Polynomial.Evaluation;
using System.Collections.Generic;
using Xunit;
using static Antrl4.Polynomial.Evaluation.Evaluator;

namespace Antrl4.Polynomial.Tests
{
    public class EvaluationTests
    {
        [Fact(DisplayName = "Test const node, empty dictionary")]
        public void TestConstNode()
        {
            // Arrange
            var node = new ConstNode(5);

            // Act
            var result = node.Eval(new Dictionary<char, double>());

            // Assert
            Assert.Equal(5, result);
        }

        [Fact(DisplayName = "Test const node, not empty dictionary")]
        public void TestConstNode2()
        {
            // Arrange
            var node = new ConstNode(5);
            var dictionary = new Dictionary<char, double>() { { 'x', 5 } };

            // Act
            var result = node.Eval(dictionary);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact(DisplayName = "Test add node")]
        public void TestAddNode()
        {
            // Arrange
            var node1 = new ConstNode(5);
            var node2 = new ConstNode(4);
            var addNode = new AddNode(node1, node2);
            var dictionary = new Dictionary<char, double>() { { 'x', 5 } };

            // Act
            var result = addNode.Eval(dictionary);

            // Assert
            Assert.Equal(9, result);
        }

        [Fact(DisplayName = "Test power node")]
        public void TestPowerNode()
        {
            // Arrange
            var b = new ConstNode(2);
            var exp = new ConstNode(4);
            var powerNode = new PowerNode(b, exp);
            var dictionary = new Dictionary<char, double>() { { 'x', 5 } };

            // Act
            var result = powerNode.Eval(dictionary);

            // Assert
            Assert.Equal(16, result);
        }
    }
}
