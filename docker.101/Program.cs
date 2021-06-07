using System;

namespace docker._101
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandLineReader = new CalculatorCommandLineReader(args);
            
            var calculator = new Calculator(
                commandLineReader.CalculatorExpression,
                commandLineReader.NumberOne,
                commandLineReader.NumberTwo
            );

            Console.WriteLine(calculator.GetResult()); 
        }
    }
}