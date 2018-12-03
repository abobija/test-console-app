using System;

namespace TestConsoleApp.Calculator
{
    public class Division : AbstractOperation
    {
        public override double Calculate()
        {
            double result = Operands[0];
            
            for(int i = 1; i < Operands.Count; i++)
            {
                var operand = Operands[i];

                if (operand == 0d)
                {
                    throw new DivideByZeroException();
                }

                result /= operand;
            }

            return result;
        }
    }
}
