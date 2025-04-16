using HospitalManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Repository
{
    public class DepartmentRepository : IDepartment
    {
        private readonly HospitalDBContext _hospitalDB;

        public DepartmentRepository(HospitalDBContext hospitalDB)
        {
            _hospitalDB = hospitalDB;
        }

        public async Task<List<Department>> GetAllDepartment()
        {
            return await _hospitalDB.Departments.ToListAsync();
        }

        public async Task<Department?> GetDepartmentById(int id)
        {
            Department? department = await _hospitalDB.Departments.FindAsync(id);
            if (department == null) return null;
            return department;
        }
    }
}
