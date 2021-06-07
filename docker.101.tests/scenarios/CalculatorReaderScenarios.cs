using docker._101.contract;
using docker._101.core;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace docker._101.tests.scenarios
{
    [Binding]
    public class CalculatorReaderScenarios
    {
        private readonly ICalculatorCommandLineReader _calculatorCommandLineReader = new CalculatorCommandLineReader();

        [When(@"'(.*)'")]
        public void When(string invalid)
        {
            _calculatorCommandLineReader.ReadArgs(invalid);
        }

        [When(@"expression '(.*)' is '(.*)', numberOne '(.*)' and '(.*)'")]
        public void WhenExpressionIsNumberOneAnd(string p0, string add, string p2, string p3)
        {
            _calculatorCommandLineReader.ReadArgs(p0, add, p2, p3);
        }

        [When(@"expression '(.*)' is '(.*)', numberOne '(.*)'")]
        public void WhenExpressionIsNumberOne(string p0, string invalid, string p2)
        {
            _calculatorCommandLineReader.ReadArgs(p0, invalid, p2);
        }

        [When(@"expression is empty")]
        public void WhenExpressionIsEmpty()
        {
            _calculatorCommandLineReader.ReadArgs();
        }
 
        [Then(@"the expression should be (.*)")]
        public void ThenTheExpressionShouldBe(CalculatorExpressionType expressionType)
        {
            expressionType.Should().Be(_calculatorCommandLineReader.CalculatorExpression);
        }
    }
}