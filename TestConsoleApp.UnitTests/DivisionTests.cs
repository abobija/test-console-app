using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsoleApp.Calculator;

namespace TestConsoleApp.UnitTests
{
    [TestFixture]
    public class DivisionTests
    {
        [Test]
        public void DivisionReturnsCorrectResultForTwoOperands()
        {
            var div = new Division();
            div.AddOperands(6, 3);

            Assert.AreEqual(div.Calculate(), 2d);
        }

        [Test]
        public void DivisionReturnsCorrectResultForMultipleOperands()
        {
            var div = new Division();
            div.AddOperands(32, 2, 4, 2);

            Assert.AreEqual(div.Calculate(), 2d);
        }

        [Test]
        public void DivisionReturnsZeroIfFirstOperandIsZero()
        {
            var div = new Division();
            div.AddOperands(0, 4, 3);

            Assert.AreEqual(div.Calculate(), 0d);
        }

        [Test]
        public void DivisionThrowsExceptionWhenDivideWithZero()
        {
            var div = new Division();
            div.AddOperands(4, 0);

            Assert.Throws<DivideByZeroException>(() => div.Calculate());
        }

        [Test]
        public void DivisionThrowsExceptionIfAnyOfOperandsAreZeroExceptFirstOne()
        {
            var div = new Division();
            div.AddOperands(4, 2, 3, 0, 2, 3, 0, 2);

            Assert.Throws<DivideByZeroException>(() => div.Calculate());
        }
    }
}
