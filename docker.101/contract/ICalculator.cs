using docker._101.core;

namespace docker._101.contract
{
    public interface ICalculator
    {
        void Expression(CalculatorExpressionType expression,
            double numberOne,
            double numberTwo);
        double GetResult();
    }
}