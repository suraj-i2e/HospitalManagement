using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }= string.Empty;
        public string doct_name { get; set; } = string.Empty;

        public string dept_name { get; set; } = string.Empty;

        public DateTime appointment { get; set; }

        [EnumDataType(typeof(AppointmentStatus))]
        public AppointmentStatus status { get; set; } =AppointmentStatus.Pending;
    }

    public enum AppointmentStatus
    {
        Schedule,
        Pending,
        Cancelled,
        Completed,
        Emergency
    }
}
