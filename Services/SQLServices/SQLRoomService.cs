using RoskildeStudentHousing.Models;
using RoskildeStudentHousing.Services.Interfaces;
using System.Data.SqlClient;

namespace RoskildeStudentHousing.Services.SQLServices
{
    public class SQLRoomService : IRoomService
    {
        public IEnumerable<Room> GetRooms()
        {
            return SQLRoom.GetAllRooms();
        }

        public IEnumerable<Room> GetEmptyRooms()
        {
            return SQLRoom.GetAllEmptyRooms();
        }

        public IEnumerable<Room> GetOccupiedRooms()
        {
            return SQLRoom.GetAllOccupiedRooms();
        }

        public void AddRoom(Room r)
        {
            SQLRoom.AddRoom(r);
        }
       
        public void UpdateRoom(Room r)
        {
            SQLRoom.UpdateRoom(r);
        }
       
        public void DeleteStudent(Room r)
        {
            SQLRoom.DeleteStudent(r);
        }
       
        public Room GetRoomById(string rid, int did)
        {
            return SQLRoom.GetRoomById(rid, did);
        }
       
        public IEnumerable<Room> FilterDormsByName(string filter)
        {
            return SQLRoom.FilterDormsByName(filter);
        }
      
        public IEnumerable<Room> FilterDormsByType(string filter)
        {
            return SQLRoom.FilterDormsByType(filter);   
        }
       
        public IEnumerable<Room> FilterDormsByPrice(int min, int max)
        {
            return SQLRoom.FilterDormsByPrice(min, max);
        }
        
        public IEnumerable<Room> FilterRoomsByDormId(int dorm)
        {
            return SQLRoom.FilterRoomsByDormId(dorm);
        }

        public IEnumerable<LeasingRoomStudentDorm> GetAllCollectedInformationFromRoom(string id, string dorm)
        {
            return SQLRoom.GetAllCollectedInformationFromRoom(id, dorm);
        }
        public  List<Room> GetAllEmptyRoomsByDorm(string dorm)
        {
            return SQLRoom.GetAllEmptyRoomsByDorm(dorm);
        }
    }
}
