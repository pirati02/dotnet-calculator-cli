using System;

namespace docker._101
{
    public class Calculator
    {
        private readonly CalculatorExpressionType _expression;
        private readonly double _numberOne;
        private readonly double _numberTwo;

        public Calculator(
            CalculatorExpressionType expression,
            double numberOne,
            double numberTwo
        )
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