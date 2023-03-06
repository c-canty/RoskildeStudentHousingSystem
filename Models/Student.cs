namespace RoskildeStudentHousing.Models
{
    public class Student
    {
        public int StudentNo { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Student()
        {
        }

        public Student(int studentNo, string name, string address)
        {
            StudentNo = studentNo;
            Name = name;
            Address = address;
        }
    }
}
