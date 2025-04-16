using HospitalManagement.Models;

namespace HospitalManagement.Repository
{
    public interface IDoctor
    {
        Task<List<Doctor>> GetAllDoctors();
        Task<Doctor?> GetDoctorById(int id);
        Task<List<Doctor>> AddDoctor(Doctor doctor);
        Task<List<Doctor>?> UpdateDoctor(int id, Doctor newDoctor);
        Task<List<Doctor>?> DeleteDoctor(int id);
    }
}
