using System.Collections.Generic;

namespace TestConsoleApp.Calculator
{
    public class Calculator
    {
        protected List<IOperation> Operations = new List<IOperation>();

        public void AddOperations(params IOperation[] operations)
            => Operations.AddRange(operations);

        public double[] Calculate()
        {
            var results = new double[Operations.Count];
            var i = 0;

            Operations.ForEach(operation => results[i++] = operation.Calculate());

            return results;
        }

        public void Clear()
            => Operations.Clear();
    }
}
