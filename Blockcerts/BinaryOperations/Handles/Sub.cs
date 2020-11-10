using BinaryOperations.Interfaces;

namespace BinaryOperations.Handles
{
    public class Sub : IExpression
    {
        private IExpression left;
        private IExpression right;

        public Sub(IExpression left, IExpression right)
        {
            this.left = left;
            this.right = right;

        }

        public int Evaluate()
        {
            int leftResult = left.Evaluate();
            int rightResult = right.Evaluate();
            return leftResult - rightResult;
        }
    }
}
