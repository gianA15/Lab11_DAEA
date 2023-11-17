namespace Lab11.Models
{
    public class Course
    {
        public Course()
        {
            Enrollments = new List<Enrollment>();

        }

        public IList<Enrollment> Enrollments { get; set; }

        public int CourseID { get; set; }
        public string Name { get; set; }
        public int Credit { get; set; }

    }
}
