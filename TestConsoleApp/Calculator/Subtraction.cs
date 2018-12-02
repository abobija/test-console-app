namespace TestConsoleApp.Calculator
{
    public class Subtraction : AbstractOperation
    {
        public override double Calculate()
        {
            double result = Operands[0];

            for(int i = 1; i < Operands.Count; i++)
            {
                result -= Operands[i];
            }

            return result;
        }
    }
}
