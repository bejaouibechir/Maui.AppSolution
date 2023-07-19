using Microsoft.EntityFrameworkCore;

namespace HRProjet.MAUI.MVVM.Models
{
    public class EmployeeContext :DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) 
            : base(options)
        {
            
        }
        public DbSet<Employee> Employees { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "EmployeeA",
                    Salary = 3000
                },
                new Employee
                {
                    Id = 1,
                    Name = "EmployeeB",
                    Salary = 6000
                },
                new Employee
                {
                    Id = 1,
                    Name = "EmployeeC",
                    Salary = 4000
                },
                new Employee
                {
                    Id = 1,
                    Name = "EmployeeD",
                    Salary = 2000
                },
                new Employee
                {
                    Id = 1,
                    Name = "EmployeeE",
                    Salary = 5000
                }
                );

        }


    }
}
