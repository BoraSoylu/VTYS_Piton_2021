﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DataAccess.Migrations
{
    [DbContext(typeof(SPCDBContext))]
    [Migration("20220102124131_CreateTables")]
    partial class CreateTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Entities.Assigment", b =>
                {
                    b.Property<int>("AssigneeID")
                        .HasColumnType("integer");

                    b.Property<int>("ComplaintID")
                        .HasColumnType("integer");

                    b.Property<DateTime>("AssigmentEndDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("AssigmentStartDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("AssigmentStatusID")
                        .HasColumnType("integer");

                    b.Property<int>("AssignerID")
                        .HasColumnType("integer");

                    b.HasKey("AssigneeID", "ComplaintID");

                    b.ToTable("Assigments");
                });

            modelBuilder.Entity("Entities.AssigmentStatus", b =>
                {
                    b.Property<int>("StatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.HasKey("StatusID");

                    b.ToTable("AssigmentStatuses");
                });

            modelBuilder.Entity("Entities.Authorization", b =>
                {
                    b.Property<int>("AuthorizationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("AuthorizationName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<bool[]>("Authorizations")
                        .IsRequired()
                        .HasColumnType("boolean[]");

                    b.HasKey("AuthorizationID");

                    b.ToTable("Authorizations");
                });

            modelBuilder.Entity("Entities.Citizen", b =>
                {
                    b.Property<int>("CitizenID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("Gender")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.HasKey("CitizenID");

                    b.ToTable("Citizens");
                });

            modelBuilder.Entity("Entities.CitizenAuthentication", b =>
                {
                    b.Property<int>("CitizenID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("PasswordCreationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.HasKey("CitizenID");

                    b.ToTable("CitizenAuthentications");
                });

            modelBuilder.Entity("Entities.Complaint", b =>
                {
                    b.Property<int>("ComplaintID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("AddressDescription")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<int>("CitizenID")
                        .HasColumnType("integer");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("ComplaintDescription")
                        .IsRequired()
                        .HasMaxLength(4000)
                        .HasColumnType("character varying(4000)");

                    b.Property<DateTime>("ComplaintEndDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("ComplaintStartDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("ComplaintStatusID")
                        .HasColumnType("integer");

                    b.Property<int>("ComplaintTypeID")
                        .HasColumnType("integer");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<decimal>("Latitude")
                        .HasColumnType("numeric");

                    b.Property<decimal>("Longitude")
                        .HasColumnType("numeric");

                    b.Property<string>("NeighbourHood")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("PhotoURL")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int>("PlatformID")
                        .HasColumnType("integer");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<bool>("Valid")
                        .HasColumnType("boolean");

                    b.Property<int>("ValidatorStaffID")
                        .HasColumnType("integer");

                    b.Property<string>("ZIPCode")
                        .HasColumnType("text");

                    b.HasKey("ComplaintID");

                    b.ToTable("Complaints");
                });

            modelBuilder.Entity("Entities.ComplaintDepartment", b =>
                {
                    b.Property<int>("ComplaintID")
                        .HasColumnType("integer");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("integer");

                    b.HasKey("ComplaintID", "DepartmentID");

                    b.ToTable("ComplaintDepartments");
                });

            modelBuilder.Entity("Entities.ComplaintStatus", b =>
                {
                    b.Property<int>("StatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.HasKey("StatusID");

                    b.ToTable("ComplaintStatuses");
                });

            modelBuilder.Entity("Entities.ComplaintType", b =>
                {
                    b.Property<int>("TypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.HasKey("TypeID");

                    b.ToTable("ComplaintTypes");
                });

            modelBuilder.Entity("Entities.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<int>("ManagerID")
                        .HasColumnType("integer");

                    b.HasKey("DepartmentID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Entities.Platform", b =>
                {
                    b.Property<int>("PlatformID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("PlatformData")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.HasKey("PlatformID");

                    b.ToTable("Platforms");
                });

            modelBuilder.Entity("Entities.Staff", b =>
                {
                    b.Property<int>("StaffID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AuthorizationID")
                        .HasColumnType("integer");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("character varying(1)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.HasKey("StaffID");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("Entities.StaffAuthentication", b =>
                {
                    b.Property<int>("StaffID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("PasswordCreationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.HasKey("StaffID");

                    b.ToTable("StaffAuthentications");
                });
#pragma warning restore 612, 618
        }
    }
}
