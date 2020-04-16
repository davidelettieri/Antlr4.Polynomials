using System.Collections.Generic;

namespace Antrl4.Polynomial.Evaluation
{
    public class ConstNode : INode
    {
        private readonly double _value;
        public ConstNode(double value)
        {
            _value = value;
        }
        public double Eval(Dictionary<char, double> _) => _value;


        public override string ToString()
        {
            return $"{_value}";
        }
    }
}
