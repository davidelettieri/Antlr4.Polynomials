using System.Collections.Generic;

namespace Antrl4.Polynomial.Evaluation
{
    public interface INode
    {
        double Eval(Dictionary<char, double> variablesValue);
    }
}
