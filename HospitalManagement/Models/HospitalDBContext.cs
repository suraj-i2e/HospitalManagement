using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Models
{
    public class HospitalDBContext: DbContext
    {
        public HospitalDBContext(DbContextOptions<HospitalDBContext> options) : base(options)
        {
        }
        public DbSet<Doctor> Doctors {  get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Patient> Patients { get; set; }
    }
}
