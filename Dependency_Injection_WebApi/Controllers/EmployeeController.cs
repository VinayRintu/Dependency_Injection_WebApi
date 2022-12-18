using Dependency_Injection_WebApi.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Dependency_Injection_WebApi.Controllers
{
    //[ApiController]
    [Route("[controller]/[action]")]
    public class EmployeeController : ControllerBase
    {
        IEmployee _emp1;
        IEmployee _emp2;
        public EmployeeController(IEmployee emp1, IEmployee emp2)
        {
            _emp1 = emp1;
            _emp2 = emp2;
        }
        [HttpGet]
        public ActionResult Index()
        {
            List<string> empList = _emp1.GetEmploeeList();
            string gId1= _emp1.GenerateGuid().ToString();
            string gId2= _emp2.GenerateGuid().ToString();
            return Ok(empList);
        }
    }
}
