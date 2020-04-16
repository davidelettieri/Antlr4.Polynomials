using System;
using System.Collections.Generic;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime;
using Antrl4.Polynomial.Evaluation;
using static Antrl4.Polynomial.Evaluation.Evaluator;

namespace Antrl4.Polynomial
{
    public class Evaluator
    {
        private INode _expr;

        public Evaluator(string polynomial)
        {
            var inputStream = new AntlrInputStream(polynomial);
            var lexer = new PolynomialLexer(inputStream);
            var commonTokenStream = new CommonTokenStream(lexer);
            var parser = new PolynomialParser(commonTokenStream);
            var context = parser.expr();

            var visitor = new VisitorImpl();

            _expr = visitor.Visit(context);
        }

        public double Eval(Dictionary<char,double> values)
        {
            return _expr.Eval(values);
        }

        class VisitorImpl : PolynomialBaseVisitor<INode>
        {
            public override INode VisitAdd([NotNull] PolynomialParser.AddContext context)
            {
                var left = context.expr()[0];
                var right = context.expr()[1];

                return new AddNode(Visit(left), Visit(right));
            }

            public override INode VisitConst([NotNull] PolynomialParser.ConstContext context)
            {
                var c = context.GetText();

                return new ConstNode(Convert.ToDouble(c));
            }

            public override INode VisitPower([NotNull] PolynomialParser.PowerContext context)
            {
                var b = context.expr()[0];
                var exp = context.expr()[1];

                return new PowerNode(Visit(b), Visit(exp));
            }

            public override INode VisitProd([NotNull] PolynomialParser.ProdContext context)
            {
                var left = context.expr()[0];
                var right = context.expr()[1];

                return new ProductNode(Visit(left), Visit(right));
            }

            public override INode VisitSubtract([NotNull] PolynomialParser.SubtractContext context)
            {
                var left = context.expr()[0];
                var right = context.expr()[1];

                return new SubtractNode(Visit(left), Visit(right));
            }

            public override INode VisitVar([NotNull] PolynomialParser.VarContext context)
            {
                var c = context.GetText()[0];
                return new VariableNode(c);
            }
        }

    }

}
