using System.Collections.Generic;
using System.Reflection.Emit;

namespace DoctorsAppointmentAPI.context
{
    public class DoctorAppoinmentContext : DbContext
    {
        public DoctorAppoinmentContext(DbContextOptions options) : base(options)
        {
        }



        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee() { Id = 101, Name = "Ramu", DateOfBirth = new DateTime(2000, 2, 12), Phone = "9876543321", Image = "" },
                new Employee() { Id = 102, Name = "Somu", DateOfBirth = new DateTime(2002, 3, 24), Phone = "9988776655", Image = "" }
                );
        }
    }
}
