namespace hris.Models
{
    public class EmployeeShift
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee{ get; set; }
        public int ShiftId { get; set; }
        public Shift Shift { get; set; }
        public DateTime ShiftDate { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
