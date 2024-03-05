namespace demo.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //List Of Courses
        public List<Course> Courses { get; set; }
    }
}
