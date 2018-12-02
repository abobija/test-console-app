using System.Collections.Generic;

namespace TestConsoleApp.Calculator
{
    public abstract class AbstractOperation : IOperation
    {
        protected List<double> Operands = new List<double>();

        public void AddOperands(params double[] operands)
            => Operands.AddRange(operands);
        
        public abstract double Calculate();
    }
}
