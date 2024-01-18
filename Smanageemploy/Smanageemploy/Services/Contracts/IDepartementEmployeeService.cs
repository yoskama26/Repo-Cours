using Smanageemploy.Dtos.DepartmentEmployee;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Smanageemploy.Services.Contracts
{
    public interface IDepartmentEmployeeService
    {
        Task<ReadEmployeeDepartment> CreateEmployeeDepartmentAsync(CreateEmployeeDepartment employeeDepartment);

        Task<List<ReadEmployeeDepartment>> GetEmployeeDepartments();

        Task<ReadEmployeeDepartment> DeleteEmployeeDepartmentById(CreateEmployeeDepartment employeeDepartment);
    }
}
