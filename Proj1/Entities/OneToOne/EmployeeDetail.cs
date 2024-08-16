namespace Proj1.Entities.OneToOne
{
    public class EmployeeDetail
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; } // Foreign Key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        // Navigation property
        public Employee Employee { get; set; }
    }
}
