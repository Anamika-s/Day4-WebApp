using WebAppDemo.Context;
using WebAppDemo.Models;
using WebAppWithLayers.IRepository;

namespace WebAppWithLayers
{
    public class EmployeeRepository : IEmplyeeRepo
    {
        EmployeeDbContext _context;
        public EmployeeRepository(EmployeeDbContext context)
        {
            _context = context;
        }

        public void CreateEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();

        }

        public int DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public int EditEmployee(int id, Employee employee)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(int id)
        {
            throw new NotImplementedException();
        }
    }
}
