using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string doctor_name { get; set; }= string.Empty;
    }
}
