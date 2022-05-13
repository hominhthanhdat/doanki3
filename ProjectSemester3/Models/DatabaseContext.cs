using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProjectSemester3.Models
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<Business> Businesses { get; set; } = null!;
        public virtual DbSet<Candidate> Candidates { get; set; } = null!;
        public virtual DbSet<Career> Careers { get; set; } = null!;
        public virtual DbSet<CategoryBusiness> CategoryBusinesses { get; set; } = null!;
        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<Contract> Contracts { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Request> Requests { get; set; } = null!;
        public virtual DbSet<Testimonial> Testimonials { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-7O2C9NB\\GEOL;Database=StarSecurity;user id=sa;password=123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.Property(e => e.AccountId).HasColumnName("accountId");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .HasColumnName("email");

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .HasColumnName("password");

                entity.Property(e => e.Role).HasColumnName("role");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .HasColumnName("userName");
            });

            modelBuilder.Entity<Business>(entity =>
            {
                entity.ToTable("Business");

                entity.Property(e => e.BusinessId).HasColumnName("businessId");

                entity.Property(e => e.CategoryId).HasColumnName("categoryId");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");

                entity.Property(e => e.Duration)
                    .HasMaxLength(150)
                    .HasColumnName("duration");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .HasColumnName("name");

                entity.Property(e => e.Photo)
                    .HasMaxLength(150)
                    .HasColumnName("photo");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Businesses)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_business_categoryBusiness");
            });

            modelBuilder.Entity<Candidate>(entity =>
            {
                entity.ToTable("Candidate");

                entity.Property(e => e.CandidateId).HasColumnName("candidateId");

                entity.Property(e => e.Address)
                    .HasMaxLength(150)
                    .HasColumnName("address");

                entity.Property(e => e.CareerId).HasColumnName("careerId");

                entity.Property(e => e.FullName)
                    .HasMaxLength(150)
                    .HasColumnName("fullName");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(11)
                    .HasColumnName("phoneNumber");

                entity.Property(e => e.QualityEducation)
                    .HasMaxLength(150)
                    .HasColumnName("qualityEducation");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.Career)
                    .WithMany(p => p.Candidates)
                    .HasForeignKey(d => d.CareerId)
                    .HasConstraintName("FK_candidate_career");
            });

            modelBuilder.Entity<Career>(entity =>
            {
                entity.ToTable("Career");

                entity.Property(e => e.CareerId).HasColumnName("careerId");

                entity.Property(e => e.BusinessId).HasColumnName("businessId");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("date")
                    .HasColumnName("createdDate");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .HasColumnName("description");

                entity.Property(e => e.Location)
                    .HasMaxLength(1000)
                    .HasColumnName("location");

                entity.Property(e => e.Offer)
                    .HasMaxLength(1000)
                    .HasColumnName("offer");

                entity.Property(e => e.Requirement)
                    .HasMaxLength(1000)
                    .HasColumnName("requirement");

                entity.Property(e => e.Salary)
                    .HasMaxLength(500)
                    .HasColumnName("salary");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("('true')");

                entity.Property(e => e.Title)
                    .HasMaxLength(150)
                    .HasColumnName("title");

                entity.HasOne(d => d.Business)
                    .WithMany(p => p.Careers)
                    .HasForeignKey(d => d.BusinessId)
                    .HasConstraintName("FK_business_career");
            });

            modelBuilder.Entity<CategoryBusiness>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK__Category__23CAF1D8DEB42279");

                entity.ToTable("CategoryBusiness");

                entity.Property(e => e.CategoryId).HasColumnName("categoryId");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("Client");

                entity.Property(e => e.ClientId).HasColumnName("clientId");

                entity.Property(e => e.AddressClient)
                    .HasMaxLength(150)
                    .HasColumnName("addressClient");

                entity.Property(e => e.EmailClient)
                    .HasMaxLength(150)
                    .HasColumnName("emailClient");

                entity.Property(e => e.NameClient)
                    .HasMaxLength(50)
                    .HasColumnName("nameClient");

                entity.Property(e => e.PhoneClient)
                    .HasMaxLength(11)
                    .HasColumnName("phoneClient");
            });

            modelBuilder.Entity<Contract>(entity =>
            {
                entity.ToTable("Contract");

                entity.Property(e => e.ContractId).HasColumnName("contractId");

                entity.Property(e => e.BusinessId).HasColumnName("businessId");

                entity.Property(e => e.ClientId).HasColumnName("clientId");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeId");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("endDate");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("startDate");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.Business)
                    .WithMany(p => p.Contracts)
                    .HasForeignKey(d => d.BusinessId)
                    .HasConstraintName("FK_contract_business");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Contracts)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_contract_client");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Contracts)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_contract_employee");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentId");

                entity.Property(e => e.Address)
                    .HasMaxLength(150)
                    .HasColumnName("address");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeId");

                entity.Property(e => e.AccountId).HasColumnName("accountId");

                entity.Property(e => e.Achievement)
                    .HasMaxLength(150)
                    .HasColumnName("achievement");

                entity.Property(e => e.Address)
                    .HasMaxLength(150)
                    .HasColumnName("address");

                entity.Property(e => e.BusinessId).HasColumnName("businessId");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentId");

                entity.Property(e => e.FullName)
                    .HasMaxLength(50)
                    .HasColumnName("fullName");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(11)
                    .HasColumnName("phoneNumber");

                entity.Property(e => e.Photo)
                    .HasMaxLength(150)
                    .HasColumnName("photo");

                entity.Property(e => e.Position)
                    .HasMaxLength(150)
                    .HasColumnName("position");

                entity.Property(e => e.QualityEducation)
                    .HasMaxLength(200)
                    .HasColumnName("qualityEducation");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_employee_account");

                entity.HasOne(d => d.Business)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.BusinessId)
                    .HasConstraintName("FK_employee_business");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_employee_department");
            });

            modelBuilder.Entity<Request>(entity =>
            {
                entity.ToTable("Request");

                entity.Property(e => e.RequestId).HasColumnName("requestId");

                entity.Property(e => e.AddressClient)
                    .HasMaxLength(150)
                    .HasColumnName("addressClient");

                entity.Property(e => e.BusinessId).HasColumnName("businessId");

                entity.Property(e => e.ClientIdentify)
                    .HasMaxLength(50)
                    .HasColumnName("clientIdentify");

                entity.Property(e => e.EmailClient)
                    .HasMaxLength(150)
                    .HasColumnName("emailClient");

                entity.Property(e => e.NameClient)
                    .HasMaxLength(50)
                    .HasColumnName("nameClient");

                entity.Property(e => e.PhoneClient)
                    .HasMaxLength(11)
                    .HasColumnName("phoneClient");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.Business)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.BusinessId)
                    .HasConstraintName("FK_request_business");
            });

            modelBuilder.Entity<Testimonial>(entity =>
            {
                entity.HasKey(e => e.TestmonialId)
                    .HasName("PK__Testimon__C5612D1F0B892F88");

                entity.ToTable("Testimonial");

                entity.Property(e => e.TestmonialId).HasColumnName("testmonialId");

                entity.Property(e => e.Author)
                    .HasMaxLength(50)
                    .HasColumnName("author");

                entity.Property(e => e.Content)
                    .HasMaxLength(150)
                    .HasColumnName("content");

                entity.Property(e => e.Photo)
                    .HasMaxLength(150)
                    .HasColumnName("photo");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
