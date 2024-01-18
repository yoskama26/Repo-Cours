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
    public class DepartmentsController : ControllerBase
    {
        private readonly DepartmentService _departementService;

        public DepartmentsController(DepartmentService departementService)
        {
            _departementService = departementService;
        }

        // POST api/<DepartmentsController>
        [HttpPost]
        public async Task<ActionResult<ReadDepartment>> Post([FromBody] CreateDepartment department)
        {
            if (
                department == null
                || string.IsNullOrWhiteSpace(department.Name)
                || string.IsNullOrWhiteSpace(department.Address)
                || string.IsNullOrWhiteSpace(department.Description)
            )
            {
                return BadRequest(
                    "Echec de création d'un departement : les informations sont null ou vides"
                );
            }

            try
            {
                var departmentCreated = await _departementService.CreateDepartmentAsync(department);
                return Ok(departmentCreated);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        // GET api/<DepartmentsController>
        [HttpGet]
        public async Task<ActionResult<List<ReadDepartment>>> Get()
        {
            try
            {
                var departments = await _departementService.GetDepartments();
                return Ok(departments);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        // GET api/<DepartmentsController>/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<ReadDepartment>> Get(int id)
        {
            try
            {
                var department = await _departementService.GetDepartmentByIdAsync(id);
                return Ok(department);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        // PUT api/<DepartmentsController>/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult<ReadDepartment>> Put(
            int id,
            [FromBody] UpdateDepartment updateDepartment
        )
        {
            try
            {
                var department = await _departementService.UpdateDepartmentAsync(
                    id,
                    updateDepartment
                );
                return Ok(department);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        // DELETE api/<DepartmentsController>/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult<ReadDepartment>> Delete(int id)
        {
            try
            {
                var department = await _departementService.DeleteDepartmentById(id);
                return Ok(department);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}
