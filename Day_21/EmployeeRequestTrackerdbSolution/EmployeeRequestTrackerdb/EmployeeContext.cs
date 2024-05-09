using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRequestTrackerdb
{
    public class EmployeeContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-QL1TE6V\SQLEXPRESS;Integrated Security=true;Initial Catalog=dbEmployeeTrackerCF;");
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Request> Requests { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Request>()
               .HasOne(r => r.RaisedByEmployee)
               .WithMany(e => e.RequestsRaised)
               .HasForeignKey(r => r.RequestRaisedBy)
               .OnDelete(DeleteBehavior.Restrict)
               .IsRequired();

            modelBuilder.Entity<Request>()
               .HasOne(r => r.RequestClosedByEmployee)
               .WithMany(e => e.RequestsClosed)
               .HasForeignKey(r => r.RequestClosedBy)
               .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
