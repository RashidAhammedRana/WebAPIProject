using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS.Core;
using TestWebApi.Data;
using TestWebApi.Models;

namespace TestWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
         DatabaseContext _dbContext;
        public EmployeeController(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public List<Employee> GetEmployeeList()
        {
            var employeeList = _dbContext.employee.ToList();
            return employeeList;
        }

        [HttpPost]
        public Employee AddEmployee(Employee emp)
        {
            _dbContext.employee.Add(emp);

            bool isSaved = _dbContext.SaveChanges() > 0;

            if (isSaved)
            {
                return emp;

            }

            return null;
        }
    }
}
