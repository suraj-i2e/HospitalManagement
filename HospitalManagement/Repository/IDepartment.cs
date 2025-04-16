using HospitalManagement.Models;

namespace HospitalManagement.Repository
{
    public interface IDepartment
    {
        Task<List<Department>> GetAllDepartment();
        Task<Department?> GetDepartmentById(int id);
    }
}
