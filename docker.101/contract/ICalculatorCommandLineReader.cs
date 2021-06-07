using docker._101.core;

namespace docker._101.contract
{
    public interface ICalculatorCommandLineReader
    {
        public double NumberOne { get; }
        public double NumberTwo  { get; }
        public CalculatorExpressionType CalculatorExpression  { get; }

        void ReadArgs(params string[] args);
    }
}