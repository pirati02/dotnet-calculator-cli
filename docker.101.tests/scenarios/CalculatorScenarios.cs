using System.Globalization;
using docker._101.contract;
using docker._101.core;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace docker._101.tests.scenarios
{
    [Binding]
    public class CalculatorScenarios
    {
        private readonly ICalculator _calculator = new Calculator();
        private readonly ICalculatorCommandLineReader _calculatorCommandLineReader = new CalculatorCommandLineReader();
        private double _numberOne, _numberTwo;

        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(double numberOne)
        {
            _numberOne = numberOne;
        }

        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(double numberTwo)
        {
            _numberTwo = numberTwo;
        }
        
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(double result)
        {
            result.Should().Be(_calculator.GetResult());
        }
        
        [When(@"the two expression type equals '(.*)'")]
        public void WhenTheTwoExpressionTypeEquals(string expression)
        {
            _calculatorCommandLineReader.ReadArgs(
                "-e",
                expression,
                _numberOne.ToString(CultureInfo.CurrentCulture),
                _numberTwo.ToString(CultureInfo.InvariantCulture)
            );
            _calculator.Expression(
                _calculatorCommandLineReader.CalculatorExpression,
                _calculatorCommandLineReader.NumberOne,
                _calculatorCommandLineReader.NumberTwo
            );
        }
        
        [When(@"expression is not defined")]
        public void WhenExpressionIsNotDefined()
        {
            _calculatorCommandLineReader.ReadArgs(
                "-e",
                string.Empty,
                _numberOne.ToString(CultureInfo.CurrentCulture),
                _numberTwo.ToString(CultureInfo.InvariantCulture)
            );
            _calculator.Expression(
                _calculatorCommandLineReader.CalculatorExpression,
                _calculatorCommandLineReader.NumberOne,
                _calculatorCommandLineReader.NumberTwo
            );
        } 
    }
}