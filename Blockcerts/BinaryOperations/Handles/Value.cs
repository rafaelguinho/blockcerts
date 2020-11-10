using BinaryOperations.Interfaces;

namespace BinaryOperations.Handles
{
    public class Value : IExpression
    {
        private int value;

        public Value(int value)
        {
            this.value = value;
        }

        public int Evaluate()
        {
            return value;
        }
    }
}
