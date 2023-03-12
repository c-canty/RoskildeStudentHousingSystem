using RoskildeStudentHousing.Models;
using RoskildeStudentHousing.Services.SQLServices;

namespace RoskildeStudentHousing.Services.Interfaces
{
    public interface IRoomService
    {
        public IEnumerable<Room> GetRooms();
        
        public IEnumerable<Room> GetEmptyRooms();

        public void AddRoom(Room r);

        public void UpdateRoom(Room r);

        public void DeleteStudent(Room r);

        public Room GetRoomById(string rid, int did);

        public IEnumerable<Room> FilterDormsByName(string filter);

        public IEnumerable<Room> FilterDormsByType(string filter);

        public IEnumerable<Room> FilterDormsByPrice(int min, int max);

        public IEnumerable<Room> FilterRoomsByDormId(int dorm);

        public IEnumerable<LeasingRoomStudentDorm> GetAllCollectedInformationFromRoom(string id, string dorm);

        public List<Room> GetAllEmptyRoomsByDorm(string dorm);
    }
}
