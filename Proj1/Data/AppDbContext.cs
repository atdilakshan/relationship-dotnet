using Microsoft.EntityFrameworkCore;
using Proj1.Entities.ManyToMany;
using Proj1.Entities.OneToMany;
using Proj1.Entities.OneToOne;

namespace Proj1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        #region OneToOne
        // one-to-one relationship
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeDetail> EmployeesDetails { get; set; }
        #endregion

        #region OneToMany
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        #endregion

        #region ManyToMany
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrolment> Enrolments { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region OneToOne
            // optional because entity framework handle this on entity model creation
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.EmployeeDetail)
                .WithOne(ed => ed.Employee)
                .HasForeignKey<EmployeeDetail>(ed => ed.EmployeeId);

            // Adding unique constraint to EmployeeId in EmployeeDetails table
            modelBuilder.Entity<EmployeeDetail>()
                .HasIndex(ed => ed.EmployeeId)
                .IsUnique();
            #endregion

            #region OneToMany
            // optional because entity framework handle this on entity model creation
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Orders)
                .WithOne(o => o.Customer)
                .HasForeignKey(o => o.CustomerId);
            #endregion

            #region ManyToManyOneToMany
            // optional because entity framework handle this on entity model creation
            modelBuilder.Entity<Enrolment>()
                .HasOne(e => e.Student)
                .WithMany(s => s.Enrolments)
                .HasForeignKey(e => e.StudentId);

            modelBuilder.Entity<Enrolment>()
                .HasOne(e => e.Course)
                .WithMany(c => c.Enrolments)
                .HasForeignKey(e => e.CourseId);
            #endregion
        }
    }
}
