using System;

namespace TestConsoleApp.Calculator
{
    public class Multiplication : AbstractOperation
    {
        public override double Calculate()
        {
            double result = 1;
            Operands.ForEach(operand => result *= operand);

            return result;
        }
    }
}
