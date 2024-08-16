namespace Proj1.Entities.OneToOne
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        // Navigation property
        public EmployeeDetail EmployeeDetail { get; set; }
    }
}
