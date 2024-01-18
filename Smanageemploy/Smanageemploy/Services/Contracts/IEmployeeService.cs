using Smanageemploy.Dtos.Employee;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Smanageemploy.Services.Contracts
{
    public interface IEmployeeService
    {
        Task<ReadEmployee> CreateEmployeeAsync(CreateEmployee employee);

        Task<List<ReadEmployee>> GetEmployees();

        Task<ReadEmployee> GetEmployeeByIdAsync(int employeeId);

        Task<Employee> UpdateEmployeeAsync(int employeeId, UpdateEmployee employee);

        Task<Employee> DeleteEmployeeById(int employeeId);
    }
}
