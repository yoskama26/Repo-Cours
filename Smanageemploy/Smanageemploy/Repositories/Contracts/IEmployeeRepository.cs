using Smanageemploy.Entities;

namespace Smanageemploy.Repositories.Contracts
{
    public interface IDepartementRepository
    {
        Task<List<Employee>> GetEmployeesAsync();

        Task<Employee> GetEmployeeByIdAsync(int employee_id);

        Task<Employee> GetEmployeeByIdWithIncludeAsync(int employee_id);

        Task<Employee> GetEmployeeByNameAsync(string employeefirst_name);
        Task<Employee> GetEmployeeByNameAsync(string employeelast_name);
        Task<Employee> GetEmployeeByNameAsync(string employeeemail);
        Task<Employee> GetEmployeeByNameAsync(string employeephone_number);
        Task<Employee> GetEmployeeByNameAsync(string employeeposition);

        Task UpdateEmployeeAsync(Employee employeeToUpdate);

        Task<Employee> CreateEmployeeAsync(Employee employeeToCreate);

        Task<Employee> DeleteEmployeeByIdAsync(int employeeId);
    }
}
