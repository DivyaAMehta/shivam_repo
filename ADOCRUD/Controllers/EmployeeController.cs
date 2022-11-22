using ADOCRUD.Models;
using ADOCRUD.Repostory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ADOCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeRepo _employeerepo;

        public EmployeeController(IConfiguration configuration)
        {
            _employeerepo = new EmployeeRepo(configuration);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_employeerepo.Get());
        }

        [HttpPost]
        public IActionResult Post(Employees employees)
        {
            return Ok(_employeerepo.Create(employees));
        }

        [HttpPut]
        public IActionResult Put(Employees employees, int EmpId)
        {
            return Ok(_employeerepo.Update(employees, EmpId));
        }

        [HttpDelete]
        public IActionResult Delete(int EmpId)
        {
            return Ok(_employeerepo.Delete(EmpId));
        }
    }
}
