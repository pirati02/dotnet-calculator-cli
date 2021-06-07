using System;
using static System.Double;

namespace docker._101
{
    using static CalculatorExpressionType;

    public class CalculatorCommandLineReader
    {
        private CalculatorExpressionType _cliCalculatorExpression = None;
        private double _numberOne;
        private double _numberTwo;

        public double NumberOne => _numberOne;
        public double NumberTwo => _numberTwo;
        public CalculatorExpressionType CalculatorExpression => _cliCalculatorExpression;

        public CalculatorCommandLineReader(string[] args)
        {
            ReadArgs(args);
        }

        private void ReadArgs(string[] args)
        {
            if (args.Length == 0)
                return;

            ParseExpression(args);

            if (_cliCalculatorExpression == None)
                return;

            TryParse(args[2]?.Trim(), out _numberOne);
            TryParse(args[3]?.Trim(), out _numberTwo);
        }

        private void ParseExpression(string[] args)
        {
            if (args.Length < 2)
                return;

            var expression =
                !string.IsNullOrEmpty(args[0]) && args[0] == CalculatorCommandLineExpressionConstant.Expression
                    ? args[1]
                    : string.Empty;

            _cliCalculatorExpression = expression switch
            {
                "add" => Add,
                "sub" => Subtract,
                "mul" => Multiply,
                "div" => Divide,
                _ => None
            };
        }
    }

    public enum CalculatorExpressionType
    {
        None,
        Add,
        Subtract,
        Multiply,
        Divide
    }
}