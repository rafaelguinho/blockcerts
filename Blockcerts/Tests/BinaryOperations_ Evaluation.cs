using BinaryOperations.Handles;
using BinaryOperations.Interfaces;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class BinaryOperations_Calculation
    {
        [Test]
        public void Add_1_And_2_Return_3()
        {
            IExpression exp1 = new Add(new Value(1), new Value(2));

            Assert.AreEqual(3, exp1.Evaluate());
        }

        [Test]
        public void Mul_Add_1_And_2_And_3_Return_6()
        {
            IExpression exp2 = new Mul(new Add(new Value(1), new Value(2)), new Value(2));

            Assert.AreEqual(6, exp2.Evaluate());
        }

        [Test]
        public void Sub_Mul_Add_1_And_2_And_2_And_1_Return_5()
        {
            IExpression exp3 = new Sub(new Mul(new Add(new Value(1), new Value(2)), new Value(2)), new Value(1));

            Assert.AreEqual(5, exp3.Evaluate());
        }
    }
}