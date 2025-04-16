using HospitalManagement.Models;
using HospitalManagement.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctor _doctorRepository;
        public DoctorController(IDoctor doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<Doctor>>> GetAllDoctors()
        {
            var doctors = await _doctorRepository.GetAllDoctors();
            return Ok(doctors);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Doctor>> GetDoctorById(int id)
        {
            var doctor = await _doctorRepository.GetDoctorById(id);
            return Ok(doctor);
        }

        [HttpPost]
        public async Task<ActionResult<List<Doctor>>> AddDoctor(Doctor doctor)
        {
            var doctors = await _doctorRepository.AddDoctor(doctor);
            return Ok(doctors);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Doctor>>> UpdateDoctor(int id,Doctor newDoctor)
        {
            var doctors = await _doctorRepository.UpdateDoctor(id, newDoctor);
            return Ok(doctors);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Doctor>>> DeleteDoctor(int id)
        {
            var doctors = await _doctorRepository.DeleteDoctor(id);
            return Ok(doctors);
        }
    }
}
