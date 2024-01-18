using Smanageemploy.Entities;
using Smanageemploy.Infrastructures.Database;
using Smanageemploy.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Smanageemploy.Repositories.Implementations
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ManageEmployeeDbContext _dbContext;

        public EmployeeRepository(ManageEmployeeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Employee>> GetEmployeesAsync()
        {
            return await _dbContext.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployeeByIdAsync(int employeeId)
        {
            return await _dbContext.Employees.FirstOrDefaultAsync(x => x.EmployeeId == employeeId);
        }

        public async Task<Employee> GetEmployeeByIdWithIncludeAsync(int employeeId)
        {
            return await _dbContext.Employees
                .Include(x => x.Departments)
                .FirstOrDefaultAsync(x => x.EmployeeId == employeeId);
        }

        public async Task<Employee> GetEmployeeByNameAsync(string employeeName)
        {
            return await _dbContext.Employees.FirstOrDefaultAsync(x => x.Name == employeeName);
        }

        public async Task UpdateEmployeeAsync(Employee employeeToUpdate)
        {
            _dbContext.Employees.Update(employeeToUpdate);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Employee> CreateEmployeeAsync(Employee employeeToCreate)
        {
            await _dbContext.Employees.AddAsync(employeeToCreate);
            await _dbContext.SaveChangesAsync();

            return employeeToCreate;
        }

        public async Task<Employee> DeleteEmployeeByIdAsync(int employeeId)
        {
            var employeeToDelete = await _dbContext.Employees.FindAsync(employeeId);
            _dbContext.Employees.Remove(employeeToDelete);
            await _dbContext.SaveChangesAsync();
            return employeeToDelete;
        }
    }
}
