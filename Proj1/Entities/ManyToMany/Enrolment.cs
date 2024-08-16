namespace Proj1.Entities.ManyToMany
{
    public class Enrolment
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; } // Foreign Key
        public Guid CourseId { get; set; } // Foreign Key
        public DateTime EnrolmentDate { get; set; }

        // Navigation properties
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
