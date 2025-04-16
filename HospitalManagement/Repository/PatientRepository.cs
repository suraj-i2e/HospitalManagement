using System.Numerics;
using HospitalManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Repository
{
    public class PatientRepository : IPatient
    {
        private readonly HospitalDBContext _hospitalDB;

        public PatientRepository(HospitalDBContext hospitalDB)
        {
            _hospitalDB = hospitalDB;
        }

        public async Task<List<Patient>> GetAllPatient()
        {
            return await _hospitalDB.Patients.ToListAsync();
        }
        public async Task<Patient?> GetPatientById(int id)
        {
            Patient? patient=await _hospitalDB.Patients.FindAsync(id);
            if (patient == null) return null;
            return patient;
        }
        public async Task<List<Patient>> AddPatient(Patient patient)
        {
            _hospitalDB.Patients.Add(patient);
            await _hospitalDB.SaveChangesAsync();
            return await _hospitalDB.Patients.ToListAsync();
        }

        public async Task<List<Patient>?> UpdatePatient(int id, Patient newPatient)
        {
            Patient? patient = await _hospitalDB.Patients.FindAsync(id);
            if (patient == null) return null;
            patient.Name = newPatient.Name;
            patient.doct_name = newPatient.doct_name;
            patient.dept_name=newPatient.dept_name;
            patient.appointment = newPatient.appointment;
            patient.status= newPatient.status;
            await _hospitalDB.SaveChangesAsync();
            return await _hospitalDB.Patients.ToListAsync();
        }
        public async Task<List<Patient>?> DeletePatient(int id)
        {
            Patient? patient = await _hospitalDB.Patients.FindAsync(id);
            if (patient == null) return null;
            _hospitalDB.Patients.Remove(patient);
            await _hospitalDB.SaveChangesAsync();
            return await _hospitalDB.Patients.ToListAsync();
        }

    }
}
