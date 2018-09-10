namespace SoftUniClone.Models
{
    public class StudentsInCourses
    {
       public int StudentId { get; set; }

        public User Student { get; set; }

        public int CourseId { get; set; }

        public CourseInstance Course { get; set; }
    }
}
