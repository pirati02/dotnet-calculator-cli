using docker._101.contract;

namespace docker._101.core
{
    public class Calculator : ICalculator
    {
        private CalculatorExpressionType _expression;
        private double _numberOne;
        private double _numberTwo;

        public void Expression(CalculatorExpressionType expression,
            double numberOne,
            double numberTwo)
        {
            _expression = expression;
            _numberOne = numberOne;
            _numberTwo = numberTwo;
        }

        public double GetResult()
        {
            return _expression switch
            {
                CalculatorExpressionType.None => 0,
                CalculatorExpressionType.Add => _numberOne + _numberTwo,
                CalculatorExpressionType.Subtract => _numberOne - _numberTwo,
                CalculatorExpressionType.Multiply => _numberOne * _numberTwo,
                CalculatorExpressionType.Divide => _numberOne / _numberTwo,
                _ => 0
            };
        }
    }
}