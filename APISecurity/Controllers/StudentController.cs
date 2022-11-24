using APISecurity.Models;
using APISecurity.Repostory;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace APISecurity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentRepo _studentrepo;

        public StudentController(IConfiguration configuration)
        {
            _studentrepo = new StudentRepo(configuration);
        }
        [Authorize,Authorize]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_studentrepo.Get());
        }
        
        [HttpPost,Authorize]
        public IActionResult Create(Student student)
        {
            return Ok(_studentrepo.Create(student));
        }


        [HttpPut,Authorize]
        public IActionResult Put(Student student, int StudId)
        {
            return Ok(_studentrepo.Update(student, StudId));
        }

        [HttpDelete,Authorize]
        public IActionResult Delete(int StudId)
        {
            return Ok(_studentrepo.Delete(StudId));
        }
    }
}
