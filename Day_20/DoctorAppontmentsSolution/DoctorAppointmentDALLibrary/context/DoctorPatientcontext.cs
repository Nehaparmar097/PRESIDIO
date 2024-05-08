using DoctorsAppontmentModelLibrary;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointmentDALLibrary.context
{
    public class DoctorPatientcontext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-QL1TE6V\\SQLEXPRESS;Integrated Security=true;Initial Catalog=dbDoctorPatient;");
        }
        public DbSet<Doctor> doctor { get; set; }

        public DbSet<Patient> patient { get; set; }

        public DbSet<Appointments> appointments { get; set; }

    }
}
