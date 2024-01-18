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
    public class EmployeeDepartementsController : ControllerBase
    {
        private readonly EmployeeDepartmentService _employeeDepartmentService;

        public EmployeeDepartementsController(EmployeeDepartmentService employeeDepartmentService)
        {
            _employeeDepartmentService = employeeDepartmentService;
        }

        // POST api/<EmployeeDepartementsController>
        [HttpPost]
        public async Task<ActionResult<ReadEmployeeDepartment>> Post(
            [FromBody] CreateEmployeeDepartment employeeDepartment
        )
        {
            if (
                employeeDepartment == null
                || employeeDepartment.EmployeeId == null
                || employeeDepartment.DepartmentId == null
            )
            {
                return BadRequest(
                    "Echec de création d'un departement : les informations sont null ou vides"
                );
            }

            try
            {
                var departmentCreated =
                    await _employeeDepartmentService.CreateEmployeeDepartmentAsync(
                        employeeDepartment
                    );
                return Ok(departmentCreated);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        // GET api/<EmployeeDepartementsController>
        [HttpGet]
        public async Task<ActionResult<List<ReadEmployeeDepartment>>> Get()
        {
            try
            {
                var employeeDepartments = await _employeeDepartmentService.GetEmployeeDepartments();
                return Ok(employeeDepartments);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        // DELETE api/<EmployeeDepartementsController>
        [HttpDelete]
        public async Task<ActionResult<ReadEmployeeDepartment>> Delete(
            [FromBody] CreateEmployeeDepartment employeeDepartment
        )
        {
            try
            {
                var department = await _employeeDepartmentService.DeleteEmployeeDepartmentById(
                    employeeDepartment
                );
                return Ok(department);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}
