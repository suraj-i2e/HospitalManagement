using HospitalManagement.Models;
using HospitalManagement.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartment _departmentRepo;
        public DepartmentController(IDepartment departmentRepo)
        {
            _departmentRepo = departmentRepo;
        }

        [HttpGet]
        public async Task<ActionResult<List<Department>>> GetAllDepartment()
        {
            var departments = await _departmentRepo.GetAllDepartment();
            return Ok(departments);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Department>> GetDepartmentById(int id)
        {
            var department = await _departmentRepo.GetDepartmentById(id);
            return Ok(department);
        }

    }
}
