namespace demo.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CreditHrs { get; set; }

        //foreign key
        public int DepartmentId { get; set; }
        public Department Department { get; set; } // navigtion property

        //List Of Registrations
        public List<Registration> Registrations { get; set; }
    }
}
