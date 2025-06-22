using System.ComponentModel.DataAnnotations;

namespace hris.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required,MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength (20)]
        public string Phone { get; set; }
        [MaxLength(100)]
        public string Position { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public ICollection<AttendanceRecord> AttendanceRecords { get; set; }
        public ICollection<EmployeeShift> employeeShifts { get; set; }

    }
}
