using Smanageemploy.Dtos.Department;
using Smanageemploy.Entities;
using Smanageemploy.Services.Contracts;
using Smanageemploy.Services.Implementations;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Smanageemploy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly EmployeeService _employeeService;

        public EmployeesController(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // POST api/<EmployeesController>
        [HttpPost]
        public async Task<ActionResult<ReadEmployee>> Post([FromBody] CreateEmployee employee)
        {
            if (
                employee == null
                || string.IsNullOrWhiteSpace(employee.FirstName)
                || string.IsNullOrWhiteSpace(employee.LastName)
                || string.IsNullOrWhiteSpace(employee.Email)
                || string.IsNullOrWhiteSpace(employee.PhoneNumber)
                || employee.Position == null
            )
            {
                return BadRequest(
                    "Echec de création d'un departement : les informations sont null ou vides"
                );
            }

            try
            {
                var employeeCreated = await _employeeService.CreateEmployeeAsync(employee);
                return Ok(employeeCreated);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        // GET api/<EmployeesController>
        [HttpGet]
        public async Task<ActionResult<List<ReadEmployee>>> Get()
        {
            try
            {
                var employees = await _employeeService.GetEmployees();
                return Ok(employees);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        // GET api/<EmployeesController>/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<ReadEmployee>> Get(int id)
        {
            try
            {
                var employee = await _employeeService.GetEmployeeByIdAsync(id);
                return Ok(employee);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        // PUT api/<EmployeesController>/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult<ReadEmployee>> Put(
            int id,
            [FromBody] UpdateEmployee updateEmployee
        )
        {
            try
            {
                var employee = await _employeeService.UpdateEmployeeAsync(id, updateEmployee);
                return Ok(employee);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        // DELETE api/<EmployeesController>/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult<ReadEmployee>> Delete(int id)
        {
            try
            {
                var employee = await _employeeService.DeleteEmployeeById(id);
                return Ok(employee);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}
