using System.Collections.Generic;

namespace Antrl4.Polynomial.Evaluation
{
    public class SubtractNode : INode
    {
        private readonly INode _left;
        private readonly INode _right;
        public SubtractNode(INode left, INode right)
        {
            _left = left;
            _right = right;
        }
        public double Eval(Dictionary<char, double> variablesValue) => _left.Eval(variablesValue) - _right.Eval(variablesValue);
    }
}
