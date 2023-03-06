using RoskildeStudentHousing.Models;
using RoskildeStudentHousing.Services.Interfaces;

namespace RoskildeStudentHousing.Services.MockDataServices
{
    public class MockStudentService : IStudentService
    {
        private List<Student> students;

        public MockStudentService()
        {
            students = MockData.MockDataStudent.GettAllStudents();
        }

    }
}
