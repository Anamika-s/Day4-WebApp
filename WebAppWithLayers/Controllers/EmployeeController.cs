using Microsoft.AspNetCore.Mvc;
using WebAppWithLayers.IRepository;

namespace WebAppWithLayers.Controllers
{
    public class EmployeeController : Controller
    {
        IEmplyeeRepo _employeeRepository;
        public EmployeeController(IEmplyeeRepo employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IActionResult Index()
        {
            _employeeRepository.GetAllEmployees().ToList();
            return View();
        }
    }
}
