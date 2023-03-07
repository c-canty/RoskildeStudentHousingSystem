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

        public void AddStudent(Student s)
        {
            throw new NotImplementedException();
        }

        public void DeleteStudent(Student s)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> FilterDormsByName(string filter)
        {
            throw new NotImplementedException();
        }

        public Student GetStudentById(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetStudents()
        {
            return _students;
        }

        public void UpdateStudent(Student s)
        {
            throw new NotImplementedException();
        }
    }
}
