using CalculatorWebAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculatorService<double> _calculatorService;

        public CalculatorController(ICalculatorService<double> calculatorService)
        {
            _calculatorService = calculatorService;
        }

        [HttpGet("add")]
        public ActionResult<double> Add(double num1, double num2)
        {
            return _calculatorService.Add(num1, num2);
        }

        [HttpGet("subtract")]
        public ActionResult<double> Subtract(double num1, double num2)
        {
            return _calculatorService.Subtract(num1, num2);
        }

        [HttpGet("multiply")]
        public ActionResult<double> Multiply(double num1, double num2)
        {
            return _calculatorService.Multiply(num1, num2);
        }

        [HttpGet("divide")]
        public ActionResult<double> Divide(double num1, double num2)
        {
            try
            {
                return _calculatorService.Divide(num1, num2);
            }
            catch (DivideByZeroException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
