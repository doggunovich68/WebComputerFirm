using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebComputerFirm.Models;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebComputerFirm.Data
{
    public partial class ComputerFirm_DataBaseContext : DbContext
    {
        public ComputerFirm_DataBaseContext()
        {
        }

        public ComputerFirm_DataBaseContext(DbContextOptions<ComputerFirm_DataBaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Component> Component { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<TypesComponent> TypesComponent { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseSqlite("Data Source = C:\\Users\\SHARCO Movie\\source\\repos\\WebComputerFirm\\ComputerFirm_DataBase.db");
                  optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=ComputerFirm_DataBase.db; Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Component>(entity =>
            {
                entity.Property(e => e.ComponentId)
                    .HasColumnName("Component_ID")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.ComponentCharacteristics)
                    .IsRequired()
                    .HasColumnName("Component_Characteristics")
                    .HasColumnType("VARCHAR(250)");

                entity.Property(e => e.ComponentCost)
                    .IsRequired()
                    .HasColumnName("Component_Cost")
                    .HasColumnType("VARCHAR(250)");

                entity.Property(e => e.ComponentCountryManufacturer)
                    .IsRequired()
                    .HasColumnName("Component_Country_Manufacturer")
                    .HasColumnType("VARCHAR(250)");

                entity.Property(e => e.ComponentDate)
                    .HasColumnName("Component_Date")
                    .HasColumnType("DATE");

                entity.Property(e => e.ComponentDiscription)
                    .IsRequired()
                    .HasColumnName("Component_Discription")
                    .HasColumnType("VARCHAR(250)");

                entity.Property(e => e.ComponentManufacturer)
                    .IsRequired()
                    .HasColumnName("Component_Manufacturer")
                    .HasColumnType("VARCHAR(250)");

                entity.Property(e => e.ComponentMark)
                    .IsRequired()
                    .HasColumnName("Component_Mark")
                    .HasColumnType("VARCHAR(250)");

                entity.Property(e => e.ComponentTermWarranty)
                    .HasColumnName("Component_Term_warranty")
                    .HasColumnType("INT");

                entity.Property(e => e.TypeId)
                    .HasColumnName("Type_ID")
                    .HasColumnType("INT");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Component)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerId)
                    .HasColumnName("Customer_ID")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.CustomerAddress)
                    .IsRequired()
                    .HasColumnName("Customer_Address")
                    .HasColumnType("VARCHAR(250)");

                entity.Property(e => e.CustomerFullName)
                    .IsRequired()
                    .HasColumnName("Customer_Full_name")
                    .HasColumnType("VARCHAR(250)");

                entity.Property(e => e.CustomerPhoneNumber)
                    .IsRequired()
                    .HasColumnName("Customer_Phone_number")
                    .HasColumnType("VARCHAR(250)");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.EmployeeId)
                    .HasColumnName("Employee_ID")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmployeeAddress)
                    .IsRequired()
                    .HasColumnName("Employee_Address")
                    .HasColumnType("VARCHAR(250)");

                entity.Property(e => e.EmployeeAge)
                    .IsRequired()
                    .HasColumnName("Employee_Age")
                    .HasColumnType("VARCHAR(250)");

                entity.Property(e => e.EmployeeFullName)
                    .IsRequired()
                    .HasColumnName("Employee_Full_name")
                    .HasColumnType("VARCHAR(250)");

                entity.Property(e => e.EmployeeGender)
                    .IsRequired()
                    .HasColumnName("Employee_Gender")
                    .HasColumnType("VARCHAR(250)");

                entity.Property(e => e.EmployeePassport)
                    .IsRequired()
                    .HasColumnName("Employee_Passport")
                    .HasColumnType("VARCHAR(250)");

                entity.Property(e => e.EmployeePhoneNumber)
                    .IsRequired()
                    .HasColumnName("Employee_Phone_number")
                    .HasColumnType("VARCHAR(250)");

                entity.Property(e => e.PositionId)
                    .HasColumnName("Position_ID")
                    .HasColumnType("INT");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.PositionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.Property(e => e.OrderId)
                    .HasColumnName("Order_ID")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.ComponentId1)
                    .HasColumnName("Component_ID_1")
                    .HasColumnType("INT");

                entity.Property(e => e.ComponentId2)
                    .HasColumnName("Component_ID_2")
                    .HasColumnType("INT");

                entity.Property(e => e.ComponentId3)
                    .HasColumnName("Component_ID_3")
                    .HasColumnType("INT");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("Customer_ID")
                    .HasColumnType("INT");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("Employee_ID")
                    .HasColumnType("INT");

                entity.Property(e => e.OrderExecutionDate)
                    .HasColumnName("Order_Execution_Date")
                    .HasColumnType("DATE");

                entity.Property(e => e.OrderExecutionMark)
                    .IsRequired()
                    .HasColumnName("Order_Execution_mark")
                    .HasColumnType("VARCHAR(250)");

                entity.Property(e => e.OrderGeneralWarrantyDuration)
                    .HasColumnName("Order_General_Warranty_Duration")
                    .HasColumnType("INT");

                entity.Property(e => e.OrderMarkOfPayment)
                    .IsRequired()
                    .HasColumnName("Order_Mark_of_payment")
                    .HasColumnType("VARCHAR(250)");

                entity.Property(e => e.OrderOrderDate)
                    .HasColumnName("Order_Order_date")
                    .HasColumnType("DATE");

                entity.Property(e => e.OrderPrepaidShare)
                    .IsRequired()
                    .HasColumnName("Order_Prepaid_Share")
                    .HasColumnType("VARCHAR(250)");

                entity.Property(e => e.ServiceId1)
                    .HasColumnName("Service_ID_1")
                    .HasColumnType("INT");

                entity.Property(e => e.ServiceId2)
                    .HasColumnName("Service_ID_2")
                    .HasColumnType("INT");

                entity.Property(e => e.ServiceId3)
                    .HasColumnName("Service_ID_3")
                    .HasColumnType("INT");

                entity.Property(e => e.TotalCost)
                    .HasColumnName("Total_cost")
                    .HasColumnType("INT");

                entity.HasOne(d => d.ComponentId1Navigation)
                    .WithMany(p => p.OrdersComponentId1Navigation)
                    .HasForeignKey(d => d.ComponentId1)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ComponentId2Navigation)
                    .WithMany(p => p.OrdersComponentId2Navigation)
                    .HasForeignKey(d => d.ComponentId2)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ComponentId3Navigation)
                    .WithMany(p => p.OrdersComponentId3Navigation)
                    .HasForeignKey(d => d.ComponentId3)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ServiceId1Navigation)
                    .WithMany(p => p.OrdersServiceId1Navigation)
                    .HasForeignKey(d => d.ServiceId1)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ServiceId2Navigation)
                    .WithMany(p => p.OrdersServiceId2Navigation)
                    .HasForeignKey(d => d.ServiceId2)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ServiceId3Navigation)
                    .WithMany(p => p.OrdersServiceId3Navigation)
                    .HasForeignKey(d => d.ServiceId3)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.Property(e => e.PositionId)
                    .HasColumnName("Position_ID")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasColumnName("Job_title")
                    .HasColumnType("VARCHAR(250)");

                entity.Property(e => e.Requirements)
                    .IsRequired()
                    .HasColumnType("VARCHAR(250)");

                entity.Property(e => e.Responsibilities)
                    .IsRequired()
                    .HasColumnType("VARCHAR(250)");

                entity.Property(e => e.Salary).HasColumnType("INT");
            });

            modelBuilder.Entity<Services>(entity =>
            {
                entity.HasKey(e => e.ServiceId);

                entity.Property(e => e.ServiceId)
                    .HasColumnName("Service_ID")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.ServiceCost)
                    .HasColumnName("Service_cost")
                    .HasColumnType("INT");

                entity.Property(e => e.ServiceDescription)
                    .IsRequired()
                    .HasColumnName("Service_description")
                    .HasColumnType("VARCHAR(250)");

                entity.Property(e => e.ServiceTitle)
                    .IsRequired()
                    .HasColumnName("Service_title")
                    .HasColumnType("VARCHAR(250)");
            });

            modelBuilder.Entity<TypesComponent>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("Types_Component");

                entity.Property(e => e.TypeId)
                    .HasColumnName("Type_ID")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.TypeDescription)
                    .IsRequired()
                    .HasColumnName("Type_description")
                    .HasColumnType("VARCHAR(250)");

                entity.Property(e => e.TypeTitle)
                    .IsRequired()
                    .HasColumnName("Type_title")
                    .HasColumnType("VARCHAR(250)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
