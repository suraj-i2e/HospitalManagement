using HospitalManagement.Models;
using HospitalManagement.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatient _patientRepo;

        public PatientController(IPatient patientRepo)
        {
            _patientRepo = patientRepo;
        }

        [HttpGet]
        public async Task<ActionResult<List<Patient>>> GetAllPatient()
        {
            var patients = await _patientRepo.GetAllPatient();
            return Ok(patients);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Patient>> GetPatientById(int id)
        {
            var patient = await _patientRepo.GetPatientById(id);
            if (patient == null) {
                return NotFound("Patient Not found");
            }
            return Ok(patient);
        }

        [HttpPost]
        public async Task<ActionResult<List<Patient>>> AddPatient(Patient patient)
        {
            var patients = await _patientRepo.AddPatient(patient);
            return Ok(patients);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Patient>>> UpdatePatient(int id, Patient newPatient)
        {
            var patients = await _patientRepo.UpdatePatient(id, newPatient);
            return Ok(patients);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Patient>>> DeletePatient(int id)
        {
            var patients = await _patientRepo.DeletePatient(id);
            return Ok(patients);
        }
    }
}
