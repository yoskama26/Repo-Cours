using Smanageemploy.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Smanageemploy.Repositories.Contracts
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetEmployeesAsync();

        Task<Employee> GetEmployeeByIdAsync(int employeeId);

        Task<Employee> GetEmployeeByIdWithIncludeAsync(int employeeId);

        Task<Employee> GetEmployeeByNameAsync(string employeeName);

        Task UpdateEmployeeAsync(Employee employeeToUpdate);

        Task<Employee> CreateEmployeeAsync(Employee employeeToCreate);

        Task<Employee> DeleteEmployeeByIdAsync(int employeeId);
    }
}
