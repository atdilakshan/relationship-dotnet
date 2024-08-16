namespace Proj1.Entities.ManyToMany
{
    public class Course
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        // Navigation property
        public ICollection<Enrolment> Enrolments { get; set; }
    }
}
