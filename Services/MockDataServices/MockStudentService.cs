using RoskildeStudentHousing.Models;
using RoskildeStudentHousing.Services.Interfaces;

namespace RoskildeStudentHousing.Services.MockDataServices
{
    public class MockStudentService : IStudentService
    {
        private List<Student> _students;

        public MockStudentService()
        {
            _students = MockData.MockDataStudent.GettAllStudents();
        }

    }
}
