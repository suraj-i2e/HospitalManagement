using HospitalManagement.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Repository
{
    public class DoctorRepository : IDoctor
    {
        //private static List<Doctor> doctors = new List<Doctor>
        //{
        //    new Doctor {Id= 1, doctor_name="Dr. Brown"},
        //    new Doctor {Id= 2, doctor_name="Dr. Williams"},
        //    new Doctor {Id= 3, doctor_name="Dr. Tylor"},
        //    new Doctor {Id= 4, doctor_name="Dr. Lee"},
        //    new Doctor {Id= 5, doctor_name="Dr. Harris"},
        //};

        private readonly HospitalDBContext _hospitalDB;

        public DoctorRepository(HospitalDBContext hospitalDB)
        {
            _hospitalDB = hospitalDB;
        }

        public async Task<List<Doctor>> GetAllDoctors()
        {
            return await _hospitalDB.Doctors.ToListAsync();
        }
        public async Task<Doctor?> GetDoctorById(int id)
        {
            Doctor? doctor =await  _hospitalDB.Doctors.FindAsync(id);
            if (doctor == null) return null;
            return doctor;
        }
        public async Task<List<Doctor>> AddDoctor(Doctor doctor)
        {
            _hospitalDB.Doctors.Add(doctor);
            await _hospitalDB.SaveChangesAsync();
            return await _hospitalDB.Doctors.ToListAsync(); 
        }
        public async Task<List<Doctor>?> UpdateDoctor(int id, Doctor newDoctor)
        {
            Doctor? doctor =await  _hospitalDB.Doctors.FindAsync(id);
            if (doctor == null) return null;
            doctor.doctor_name = newDoctor.doctor_name;
            await _hospitalDB.SaveChangesAsync();
            return await _hospitalDB.Doctors.ToListAsync();
        }

        public async Task<List<Doctor>?> DeleteDoctor(int id)
        {
            Doctor? doctor = await _hospitalDB.Doctors.FindAsync(id);
            if (doctor == null) return null;
            _hospitalDB.Doctors.Remove(doctor);
            await _hospitalDB.SaveChangesAsync();
            return await _hospitalDB.Doctors.ToListAsync(); ;
        }



    }
}
