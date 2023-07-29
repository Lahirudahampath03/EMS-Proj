﻿// <auto-generated />
using System;
using EMS_Proj.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EMS_Proj.Migrations
{
    [DbContext(typeof(AppDBcontext))]
    partial class AppDBcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EMS_Proj.Models.Account", b =>
                {
                    b.Property<int>("UID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UID"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UID");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("EMS_Proj.Models.Attendance", b =>
                {
                    b.Property<int>("attenID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("attenID"));

                    b.Property<string>("Checkintime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Checkouttime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmpID")
                        .HasColumnType("int");

                    b.HasKey("attenID");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("EMS_Proj.Models.Department", b =>
                {
                    b.Property<int>("DeptID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeptID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MgrID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeptID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("EMS_Proj.Models.Employee", b =>
                {
                    b.Property<int>("EmpID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmpID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartID")
                        .HasColumnType("int");

                    b.Property<int?>("DepartmentDeptID")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phonenumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("jobtitleJobID")
                        .HasColumnType("int");

                    b.Property<string>("salary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmpID");

                    b.HasIndex("DepartmentDeptID");

                    b.HasIndex("jobtitleJobID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EMS_Proj.Models.Jobtitle", b =>
                {
                    b.Property<int>("JobID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobID"));

                    b.Property<string>("JobDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JobID");

                    b.ToTable("Jobtitles");
                });

            modelBuilder.Entity("EMS_Proj.Models.Leave", b =>
                {
                    b.Property<int>("LeaveID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LeaveID"));

                    b.Property<int>("EmpID")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeEmpID")
                        .HasColumnType("int");

                    b.Property<string>("Enddate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Startdate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LeaveID");

                    b.HasIndex("EmployeeEmpID");

                    b.ToTable("Leaves");
                });

            modelBuilder.Entity("EMS_Proj.Models.Salary", b =>
                {
                    b.Property<int>("SalID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SalID"));

                    b.Property<string>("Amount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Effectivedate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmpID")
                        .HasColumnType("int");

                    b.HasKey("SalID");

                    b.ToTable("Salaries");
                });

            modelBuilder.Entity("EMS_Proj.Models.Employee", b =>
                {
                    b.HasOne("EMS_Proj.Models.Department", null)
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentDeptID");

                    b.HasOne("EMS_Proj.Models.Jobtitle", "jobtitle")
                        .WithMany()
                        .HasForeignKey("jobtitleJobID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("jobtitle");
                });

            modelBuilder.Entity("EMS_Proj.Models.Leave", b =>
                {
                    b.HasOne("EMS_Proj.Models.Employee", "Employee")
                        .WithMany("leaves")
                        .HasForeignKey("EmployeeEmpID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("EMS_Proj.Models.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("EMS_Proj.Models.Employee", b =>
                {
                    b.Navigation("leaves");
                });
#pragma warning restore 612, 618
        }
    }
}
