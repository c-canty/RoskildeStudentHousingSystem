namespace RoskildeStudentHousing.Models
{
    public class Student
    {
        public string StudentNo { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Student()
        {
        }

        public Student(string studentNo, string name, string address)
        {
            StudentNo = studentNo;
            Name = name;
            Address = address;
        }
    }
}
