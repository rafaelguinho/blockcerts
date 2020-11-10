using BinaryOperations.Handles;
using BinaryOperations.Interfaces;
using System;

namespace BinaryOperations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IExpression exp1 = new Add(new Value(1), new Value(2));

            IExpression exp2 = new Mul(new Add(new Value(1), new Value(2)), new Value(2));

            IExpression exp3 = new Sub(new Mul(new Add(new Value(1), new Value(2)), new Value(2)), new Value(1));

            Console.WriteLine(exp1.Evaluate());
            Console.WriteLine(exp2.Evaluate());
            Console.WriteLine(exp3.Evaluate());
        }
    }
}
