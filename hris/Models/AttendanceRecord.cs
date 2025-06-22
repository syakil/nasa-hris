using Microsoft.EntityFrameworkCore;

namespace hris.Models
{
    public class AttendanceRecord
    {
        public int Id { get; set; }
        public int EmployeeId { get;set; }
        public Employee Employee { get; set; }
        public int? ShiftId { get; set; }
        public Shift Shift { get; set; }
        public DateTime CheckInTime { get; set; }
        [Precision(9, 6)]

        public decimal CheckInLat { get; set; }
        [Precision(9, 6)]

        public decimal CheckInLng { get; set; }
        public string? CheckInPhoto { get; set; }
        public DateTime? CheckOutTime { get; set; }
        [Precision(9, 6)]

        public Decimal? CheckOutLat { get;set; }
        [Precision(9, 6)]

        public Decimal? CheckOutLng { get;set; }
        public DateTime? CheckOutPhoto { get;set; }
        public string? Notes { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
