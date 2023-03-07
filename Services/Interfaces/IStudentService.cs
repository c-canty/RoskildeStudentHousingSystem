using RoskildeStudentHousing.Models;
using RoskildeStudentHousing.Services.SQLServices;

namespace RoskildeStudentHousing.Services.Interfaces
{
    public interface IStudentService
    {
        public IEnumerable<Student> GetStudents();

        public void AddStudent(Student s);

        public void UpdateStudent(Student s);

        public void DeleteStudent(Student s);

        public Student GetStudentById(string id);

        public IEnumerable<Student> FilterDormsByName(string filter);       
    }
}
