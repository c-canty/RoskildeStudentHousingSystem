using RoskildeStudentHousing.Models;
using RoskildeStudentHousing.Services.SQLServices;

namespace RoskildeStudentHousing.Services.Interfaces
{
    public interface ILeasingService
    {
        public IEnumerable<Leasing> GetAllLeasings();

        public void AddLeasing(Leasing r);

        public void UpdateLeasing(Leasing r);

        public void DeleteLeasing(Leasing r);

        public Leasing GetLeasingById(string id);

        public Leasing GetLeasingByRoomNumber(int id);

        public IEnumerable<Leasing> GetLeasingsByStudentId(string id);

        public IEnumerable<Leasing> GetLeasingsByDormId(int id);

        public IEnumerable<LeasingRoomStudentDorm> GetAllCollectedInformation();

        public IEnumerable<LeasingRoomStudentDorm> GetAllCollectedInformationFromDorm(string dorm);

        public IEnumerable<LeasingRoomStudentDorm> GetAllCollectedInformationFromRoom(int id);

        public IEnumerable<LeasingRoomStudentDorm> GetAllCollectedInformationFromStudentId(string sid);
       


    }
}
