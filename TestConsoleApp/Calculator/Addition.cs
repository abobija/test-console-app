namespace TestConsoleApp.Calculator
{
    public class Addition : AbstractOperation
    {
        public override double Calculate()
        {
            double result = 0;
            Operands.ForEach(operand => result += operand);

            return result;
        }
    }
}
