using RoskildeStudentHousing.Models;
using RoskildeStudentHousing.Services.Interfaces;
using System.Data.SqlClient;

namespace RoskildeStudentHousing.Services.SQLServices
{
    public class SQLDormitoryService : IDormitoryService
    {
        public IEnumerable<Dormitory> GetDormitory()
        {
            return SQLDormitory.GetAllDorms();
        }
       
        public void AddDorm(Dormitory dorm)
        {
            SQLDormitory.AddDorm(dorm);
        }
        
        public void UpdateDorm(Dormitory dorm)
        {
            SQLDormitory.UpdateDorm(dorm);
        }
  
        public void DeleteDorm(Dormitory dorm)
        {
            SQLDormitory.DeleteDorm(dorm);
        }    
        
        public Dormitory GetDormById(int id)
        {
            return SQLDormitory.GetDormById(id);
        }
        
        public IEnumerable<Dormitory> FilterDormsByName(string filter)
        {
            return SQLDormitory.FilterDormsByName(filter);
        }

        public IEnumerable<LeasingRoomStudentDorm> GetAllCollectedInformationFromDorm(string dorm)
        {
            return SQLDormitory.GetAllCollectedInformationFromDorm(dorm);
        }






    }
}
