using NUnit.Framework;
using TestConsoleApp.Calculator;

namespace TestConsoleApp.UnitTests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void CalculatorReturnCorrectResult()
        {
            var calc = new Calc();

            var add = new Addition();
            add.AddOperands(2, 4, -4); // 2

            var sub = new Subtraction();
            sub.AddOperands(3, 4, -5); // 4

            var mul = new Multiplication();
            mul.AddOperands(2, 5, 1); // 10

            var add2 = new Addition();
            add2.AddOperands(9, 13); // 22

            calc.AddOperations(
                    add,
                    sub,
                    mul,
                    add2
                );

            Assert.That(calc.Calculate(), Is.EquivalentTo(new double[]{
                    2d,
                    4d,
                    10d,
                    22d
                }));
        }
    }
}
