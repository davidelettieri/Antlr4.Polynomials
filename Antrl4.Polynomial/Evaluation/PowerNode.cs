using System;
using System.Collections.Generic;

namespace Antrl4.Polynomial.Evaluation
{
    public class PowerNode : INode
    {
        public readonly INode _base;
        public readonly INode _power;
        public PowerNode(INode @base, INode power)
        {
            _base = @base;
            _power = power;
        }

        public double Eval(Dictionary<char, double> variablesValue)
        {
            return Math.Pow(_base.Eval(variablesValue), _power.Eval(variablesValue));
        }
    }
}
