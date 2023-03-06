using RoskildeStudentHousing.Models;

namespace RoskildeStudentHousing.Services.Interfaces
{
    public interface IDormitoryService
    {
        IEnumerable<Dormitory> GetDormitory();

    }
}
