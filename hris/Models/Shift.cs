using System.ComponentModel.DataAnnotations;

namespace hris.Models
{
    public class Shift
    {
        public int Id { get; set; }
        [Required,MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public TimeSpan StartTime { get; set; }
        [Required]
        public TimeSpan EndTime { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<EmployeeShift> EmployeeShifts { get; set; }
        public ICollection<AttendanceRecord> AttendanceRecords { get; set; }
    }
}
