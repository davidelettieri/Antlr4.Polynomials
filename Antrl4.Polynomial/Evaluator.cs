//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Antlr4.Runtime.Misc;
//using Antlr4.Runtime.Tree;
//using Antlr4.Runtime;
//using Antrl4.Polynomial.Evaluation;

//namespace Antrl4.Polynomial
//{
//    public partial class Evaluator
//    {
//        private Func<Dictionary<char, double>, double> PolynomialFunc;

//        public Evaluator(string polynomial)
//        {
//            var inputStream = new AntlrInputStream(polynomial);
//            var lexer = new PolynomialLexer(inputStream);
//            var commonTokenStream = new CommonTokenStream(lexer);
//            var parser = new PolynomialParser(commonTokenStream);
//            var context = parser.polynomial();

//            var visitor = new VisitorImpl();

//            PolynomialFunc = visitor.Visit(context);

//            if (PolynomialFunc == null)
//            {
//                PolynomialFunc = visitor.Visit(parser.monomial());
//            }
//        }

//        public double Eval(double x)
//        {
//            return PolynomialFunc(x);
//        }

//        class VisitorImpl : PolynomialBaseVisitor<INode>
//        {
//            private INode _node;

//            public override Func<INode> VisitMonom([NotNull] PolynomialParser.MonomContext context)
//            {
//                var powers = context.VAR().Length;

//                for (int i = 0; i < powers; i++)
//                {

//                }


//            }

//            public override Func<Dictionary<char, double>, double> VisitConst(PolynomialParser.ConstContext context)
//            {
//                var val = double.Parse(context.NUM().GetText());

//                return p => val;
//            }

//            public override Func<Dictionary<char, double>, double> VisitRealMonomial(PolynomialParser.RealMonomialContext context)
//            {
//                var coeff = context.NUM().Length == 2 ? Convert.ToDouble(context.NUM().GetValue(0).ToString()) : 1;

//                var exp = context.NUM().Length > 0 ? Convert.ToDouble(context.NUM().GetValue(context.NUM().Length - 1).ToString()) : 1;

//                return p => coeff * Math.Pow(p, exp);
//            }

//            public override Func<Dictionary<char, double>, double> VisitMonomialSum(PolynomialParser.MonomialSumContext context)
//            {
//                var monomials = context.monomial();
//                var operations = context.SIGN();
//                var ifStartWithAnOp = monomials.Length == operations.Length;
//                var finalValue = ifStartWithAnOp ? GetOp(operations[0])(p => 0, Visit(monomials[0])) : Visit(monomials[0]);
//                var monomioIndex = 1;
//                var segniIndex = ifStartWithAnOp ? 1 : 0;

//                while (monomioIndex < monomials.Length)
//                {
//                    var op = GetOp(operations[segniIndex]);

//                    var value = Visit(monomials[monomioIndex]);

//                    finalValue = op(finalValue, value);

//                    monomioIndex++;
//                    segniIndex++;
//                }

//                return finalValue;
//            }

//            private Func<Func<double, double>, Func<double, double>, Func<double, double>> GetOp(ITerminalNode node)
//            {
//                if (node?.GetText() == "-")
//                {
//                    return (i, j) => k => subtract(i(k), j(k));
//                }

//                return (i, j) => k => add(i(k), j(k));
//            }
//        }

//    }

//}
