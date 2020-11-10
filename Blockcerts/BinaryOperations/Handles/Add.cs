using BinaryOperations.Interfaces;

namespace BinaryOperations.Handles
{
    public class Add : IExpression
    {
        private IExpression left;
        private IExpression right;

        public Add(IExpression left, IExpression right)
        {
            this.left = left;
            this.right = right;

        }

        public int Evaluate()
        {
            int leftResult = left.Evaluate();
            int rightResult = right.Evaluate();
            return leftResult + rightResult;
        }
    }
}
