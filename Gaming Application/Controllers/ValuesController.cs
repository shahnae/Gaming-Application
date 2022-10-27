using Gaming_Application.Contract;
using Gaming_Application.Model;
using Gaming_Application.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Gaming_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IGuessTestService _guessTestService;

        public ValuesController(IGuessTestService guessTestService)
        { 
            _guessTestService = guessTestService;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetInputs(InputValue inputValue)
        {
            
            return Ok(_guessTestService.GetInputs());
        }

        //[HttpGet]
        //[Route("api/[controller]/{Num}")]
        //public IActionResult GetInputs(int Num)
        //{
        //    var inputs = _guessTestService.GetInputs(Num);
        //   if(inputs!=null)
        //    {
        //        return Ok(inputs);
        //    }
        //    return NotFound("no such input");
        //}

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetDivisibleResult(InputValue inputValue)
        {
            var inputnum = _guessTestService.GetInputs();
            if(inputnum != null)
            {
                _guessTestService.GetDivisibleResult(inputValue);
                return Ok();
            }
            return NotFound("No such Output");
        }
    }
}
 