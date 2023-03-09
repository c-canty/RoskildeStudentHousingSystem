using RoskildeStudentHousing.Models;
using RoskildeStudentHousing.Services.Interfaces;

namespace RoskildeStudentHousing.Services.SQLServices
{
    public class SQLLeasingService : ILeasingService
    {
       
        public IEnumerable<Leasing> GetAllLeasings()
        {
            return SQLLeasing.GetAllLeasings();
        }
       
        public void AddLeasing(Leasing r)
        {
            SQLLeasing.AddLeasing(r);
        }
        
        public void UpdateLeasing(Leasing r)
        {
            SQLLeasing.UpdateLeasing(r);
        }
      
        public void DeleteLeasing(Leasing r)
        {
            SQLLeasing.DeleteLeasing(r);
        }
        
        public Leasing GetLeasingById(string id)
        {
            return SQLLeasing.GetLeasingById(id);
        }

        public Leasing GetLeasingByRoomNumber(int id)
        {
            return SQLLeasing.GetLeasingByRoomNumber(id);
        }

        public IEnumerable<Leasing> GetLeasingsByStudentId(string id)
        {
            return SQLLeasing.GetLeasingsByStudentId(id);
        }

        public IEnumerable<Leasing> GetLeasingsByDormId(int id)
        {
            return SQLLeasing.GetLeasingsByDormId(id);
        }

        public IEnumerable<LeasingRoomStudentDorm> GetAllCollectedInformation()
        {
            return SQLLeasing.GetAllCollectedInformation();
        }

    }
}
