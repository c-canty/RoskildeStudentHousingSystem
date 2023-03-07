using RoskildeStudentHousing.Models;
using RoskildeStudentHousing.Services.SQLServices;

namespace RoskildeStudentHousing.Services.Interfaces
{
    public interface IDormitoryService
    {
        IEnumerable<Dormitory> GetDormitory();

        public void AddDorm(Dormitory dorm);

        public void UpdateDorm(Dormitory dorm);

        public void DeleteDorm(Dormitory dorm);

        public Dormitory GetDormById(int id);

        public IEnumerable<Dormitory> FilterDormsByName(string filter);
        

    }
}
