// ClinicDbContext.cs

using Microsoft.EntityFrameworkCore;

namespace MvcMovie.Models
{
    public class ClinicDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        // Outras configurações do DbContext, se necessário
    }
}
