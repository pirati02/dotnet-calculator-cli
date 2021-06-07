using docker._101.contract;
using docker._101.core;
using Microsoft.AspNetCore.Mvc;

namespace docker._101.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculator _calculator;

        public CalculatorController(ICalculator calculator)
        {
            _calculator = calculator;
        }


        [HttpGet("{expression}/{numberOne:int}/{numberTwo:int}")]
        public IActionResult Calculate(
            [FromRoute] CalculatorExpressionType expression,
            [FromRoute] int numberOne,
            [FromRoute] int numberTwo
        )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _calculator.Expression(expression, numberOne, numberTwo);

            return Ok(_calculator.GetResult());
        }
    }
}