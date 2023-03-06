using RoskildeStudentHousing.Models;

namespace RoskildeStudentHousing.Services.Interfaces
{
    public interface IStudentService
    {
        IEnumerable<Student> GetStudents();
    }
}
