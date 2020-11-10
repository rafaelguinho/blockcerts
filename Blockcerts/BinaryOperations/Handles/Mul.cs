using BinaryOperations.Interfaces;

namespace BinaryOperations.Handles
{
    public class Mul : IExpression
    {
        private IExpression left;
        private IExpression right;

        public Mul(IExpression left, IExpression right)
        {
            this.left = left;
            this.right = right;

        }

        public int Evaluate()
        {
            int leftResult = left.Evaluate();
            int rightResult = right.Evaluate();
            return leftResult * rightResult;
        }
    }
}
