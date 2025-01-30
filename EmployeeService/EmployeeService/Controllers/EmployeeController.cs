using EmployeeService.BLL.Services.IServices;
using EmployeeService.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController(IEmployeeService employeeService) : ControllerBase
    {
        [HttpGet]
        public async Task<IEnumerable<Employee>> GetEmployeeList(CancellationToken cancellationToken)
        {
            return await employeeService.GetEmployeeListAsync(cancellationToken);
        }

        [HttpGet("{id}")]
        public async Task<Employee> GetEmployee(Guid id, CancellationToken cancellationToken)
        {
            return await employeeService.GetEmployeeAsync(id, cancellationToken);
        }

        [HttpPost]
        public async Task<Employee> CreateEmployee(Employee employee, CancellationToken cancellationToken)
        {
            return await employeeService.CreateEmployeeAsync(employee, cancellationToken);
        }

        [HttpDelete("{id}")]
        public async Task DeleteEmployee(Guid id, CancellationToken cancellationToken)
        {
            await employeeService.DeleteEmployeeAsync(id, cancellationToken);
        }
    }
}
