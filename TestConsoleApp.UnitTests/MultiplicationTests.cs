using NUnit.Framework;
using TestConsoleApp.Calculator;

namespace TestConsoleApp.UnitTests
{
    [TestFixture]
    public class MultiplicationTests
    {
        [Test]
        public void MultiplicationRetursCorrectResultForTwoOperands()
        {
            var mul = new Multiplication();
            mul.AddOperands(3, 2);

            Assert.AreEqual(mul.Calculate(), 6d);
        }

        [Test]
        public void MultiplicationRetursCorrectResultForMultipleOperands()
        {
            var mul = new Multiplication();
            mul.AddOperands(3, 5, 2);

            Assert.AreEqual(mul.Calculate(), 30d);
        }

        [Test]
        public void MultiplicationReturnsZeroIfOneOfOperandsAreZero()
        {
            var mul = new Multiplication();
            mul.AddOperands(3, 2, 4, 3, 0, 2, 3);

            Assert.AreEqual(mul.Calculate(), 0d);
        }
    }
}
