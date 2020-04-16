using Antrl4.Polynomial.Evaluation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antrl4.Polynomial.Evaluation
{
    public class VariableNode : INode
    {
        private char _var;

        public VariableNode(char variable)
        {
            _var = variable;
        }
        public double Eval(Dictionary<char, double> variablesValue)
        {
            if (variablesValue.TryGetValue(_var, out var value))
                return value;

            throw new InvalidOperationException($"Value for variable {_var} is not present in dictionary {nameof(variablesValue)}");
        }
    }
}
