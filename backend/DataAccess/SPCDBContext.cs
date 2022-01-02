using System;
using Microsoft.EntityFrameworkCore;
using Entities;

namespace DataAccess
{
    public class SPCDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=abul.db.elephantsql.com;Port=5432;Username=xglqlcuy;Password=EOF8asm57k18jlGm8KGHxIKm0IxpZm7u;Database=xglqlcuy;");
                base.OnConfiguring(optionsBuilder);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assigment>()
                .HasKey(nameof(Assigment.AssigneeID), nameof(Assigment.ComplaintID));
            modelBuilder.Entity<ComplaintDepartment>()
                .HasKey(nameof(ComplaintDepartment.ComplaintID), nameof(ComplaintDepartment.DepartmentID));
        }

        public DbSet<Assigment> Assigments { get; set; }
        public DbSet<AssigmentStatus> AssigmentStatuses { get; set; }
        public DbSet<Authorization> Authorizations { get; set; }
        public DbSet<Citizen> Citizens { get; set; }
        public DbSet<CitizenAuthentication> CitizenAuthentications { get; set; }
        public DbSet<Complaint> Complaints { get; set; }
        public DbSet<ComplaintDepartment> ComplaintDepartments { get; set; }
        public DbSet<ComplaintStatus> ComplaintStatuses { get; set; }
        public DbSet<ComplaintType> ComplaintTypes { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<StaffAuthentication> StaffAuthentications { get; set; }
    }
}
