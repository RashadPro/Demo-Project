namespace demo.Models
{
    public class student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DataofBirth { get; set; }
        public int CreatedAt { get; set; }


        //List Of Registrations
        public List<Registration> Registrations { get; set; }


    }
}
