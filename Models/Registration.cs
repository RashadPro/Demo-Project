namespace demo.Models
{
    public enum GradeType
    {
        A,B,C,D,E,F
    }

    public class Registration
    {
        //foreign key
        public int CourseId { get; set; }
        public Course Course { get; set; } // navigtion property

        //foreign key
        public int studentId { get; set; }
        public student student { get; set; } // navigtion property

        public GradeType Grade { get; set; }



    }
}
