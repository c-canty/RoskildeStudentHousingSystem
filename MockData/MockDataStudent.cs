using RoskildeStudentHousing.Models;

namespace RoskildeStudentHousing.MockData
{
    public class MockDataStudent
    {
        public static List<Student> studentsList = new List<Student>()
        {
            new Student("1", "Mads Ludvigsen", "Roskilde"),
            new Student("2", "Christian Canty", "Holbæk"),
            new Student("3", "Mille Alstrøm", "Slagelse")
        };

        public static List<Student> GettAllStudents()
        {
            return studentsList;
        }

    }
}
