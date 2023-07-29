using EMS_Proj.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System;

namespace EMS_Proj.Data
{
    public class AppDBcontext:DbContext
    {

        public AppDBcontext(DbContextOptions<AppDBcontext> options) : base(options) {


            Database.EnsureCreated();


        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Jobtitle> Jobtitles { get; set; }
        public DbSet<Leave> Leaves { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<Account> Accounts { get; set; }
       


    }
}
