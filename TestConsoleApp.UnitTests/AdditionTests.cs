using NUnit.Framework;
using TestConsoleApp.Calculator;

namespace TestConsoleApp.UnitTests
{
    [TestFixture]
    public class AdditionTests
    {
        [Test]
        public void AdditionReturnsCorrectResultWithTwoOperand()
        {
            var addition = new Addition();
            addition.AddOperands(3, 4);

            Assert.AreEqual(addition.Calculate(), 7d);
        }

        [Test]
        public void AdditionReturnsCorrectResultWithMultipleOperands()
        {
            var addition = new Addition();
            addition.AddOperands(5, 4, 2, 0, 4);

            Assert.AreEqual(addition.Calculate(), 15d);
        }
    }
}
