using FibonacciRest.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FibonacciRestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FibonacciController : Controller
    {

        #region Fields
        private readonly IFibonacciFunction _fibonacciFunction;
      

        #endregion

        #region Constructors
        public FibonacciController(IFibonacciFunction fibonacciFunction)
        {
            _fibonacciFunction = fibonacciFunction;
        }

       
        #endregion

        #region  Methods
        [HttpGet("GetFibonacci/{n}")]
        public IActionResult GetFibonacci(int n)
        {
            if (n < 0)
            {
                return BadRequest("Index must be a non-negative integer.");
            }

            int result = _fibonacciFunction.CalculateFibonacci(n);

            return Ok(result);
        }
        #endregion
    }
}
