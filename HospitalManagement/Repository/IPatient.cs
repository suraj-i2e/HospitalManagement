using HospitalManagement.Models;

namespace HospitalManagement.Repository
{
    public interface IPatient
    {
        Task<List<Patient>> GetAllPatient();
        Task<Patient?> GetPatientById(int id);
        Task<List<Patient>> AddPatient(Patient patient);
        Task<List<Patient>?> UpdatePatient(int id, Patient newPatient);
        Task<List<Patient>?> DeletePatient(int id);
    }
}
