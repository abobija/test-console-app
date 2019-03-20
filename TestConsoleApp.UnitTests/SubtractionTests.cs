using NUnit.Framework;
using TestConsoleApp.Calculator;

namespace TestConsoleApp.UnitTests
{
    [TestFixture]
    public class SubtractionTests
    {
        [Test]
        public void SubtractionReturnsCorrectResultWithTwoOperand()
        {
            var sub = new Subtraction();
            sub.AddOperands(4, 2);

            Assert.AreEqual(sub.Calculate(), 2d);
        }

        [Test]
        public void SubtractionReturnsCorrectResultWithMultipleOperands()
        {
            var sub = new Subtraction();
            sub.AddOperands(15, 3, 6, 2);

            Assert.AreEqual(sub.Calculate(), 4d);
        }

        [Test]
        public void SubstractionReturnsCorrectNegativeValue()
        {
            var sub = new Subtraction();
            sub.AddOperands(4, 6);

            Assert.AreEqual(sub.Calculate(), -2d);
        }
    }
}
