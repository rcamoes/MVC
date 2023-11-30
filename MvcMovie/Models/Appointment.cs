public class Appointment
{
    public int Id { get; set; }
    public Doctor Doctor { get; set; }
    public Patient Patient { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string Description { get; set; }
}