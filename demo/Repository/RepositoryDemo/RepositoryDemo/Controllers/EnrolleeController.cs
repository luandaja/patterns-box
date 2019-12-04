using System.Net;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace RepositoryDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnrolleeController : ControllerBase
    {
        private readonly IEnrolleeRepository _enrolleeRepository;
        public EnrolleeController(IEnrolleeRepository enrolleeRepository)
        {
            _enrolleeRepository = enrolleeRepository;
        }

        [HttpGet("{enrolleeId}")]
        public IActionResult GetEnrollee(int enrolleeId)
        {
            var response = _enrolleeRepository.GetById(enrolleeId);
            if(response != null)
                return StatusCode((int)HttpStatusCode.OK,response);
            return StatusCode((int)HttpStatusCode.NotFound);
        }
    }
}
