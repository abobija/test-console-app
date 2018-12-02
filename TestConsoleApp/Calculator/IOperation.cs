namespace TestConsoleApp.Calculator
{
    public interface IOperation
    {
        void AddOperands(double[] operands);
        double Calculate();
    }
}
