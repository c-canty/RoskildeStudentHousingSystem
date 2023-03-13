using RoskildeStudentHousing.Models;
using RoskildeStudentHousing.Services.Interfaces;
using System.Data.SqlClient;

namespace RoskildeStudentHousing.Services.SQLServices
{
    public class SQLStudentService : IStudentService
    {

        public IEnumerable<Student> GetStudents()
        {
            return SQLStudent.GetAllStudents();
        }

        public void AddStudent(Student s)
        {
            SQLStudent.AddStudent(s);
        }

        public void UpdateStudent(Student s)
        {
            SQLStudent.UpdateStudent(s);
        }

        public void DeleteStudent(Student s)
        {
            SQLStudent.DeleteStudent(s);
        }

        public Student GetStudentById(string id)
        {
            return SQLStudent.GetStudentById(id);
        }

        public IEnumerable<Student> FilterDormsByName(string filter)
        {
            return SQLStudent.FilterDormsByName(filter);
        }

        public IEnumerable<LeasingRoomStudentDorm> GetAllCollectedInformationFromStudentId(string sid)
        {
            return SQLStudent.GetAllCollectedInformationFromStudentId(sid);
        }
    }
}
