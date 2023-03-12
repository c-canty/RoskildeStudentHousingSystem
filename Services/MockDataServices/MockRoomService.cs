using RoskildeStudentHousing.Models;
using RoskildeStudentHousing.Services.Interfaces;

namespace RoskildeStudentHousing.Services.MockDataServices
{
    public class MockRoomService : IRoomService
    {
        private List<Room> _rooms;

        public MockRoomService()
        {
            _rooms = MockData.MockDataRoom.GetAllRooms();
        }

        public void AddRoom(Room r)
        {
            throw new NotImplementedException();
        }

        public void DeleteStudent(Room r)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Room> FilterDormsByName(string filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Room> FilterDormsByPrice(int min, int max)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Room> FilterDormsByType(string filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Room> FilterRoomsByDormId(int dorm)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LeasingRoomStudentDorm> GetAllCollectedInformationFromRoom(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LeasingRoomStudentDorm> GetAllCollectedInformationFromRoom(string id, string dorm)
        {
            throw new NotImplementedException();
        }

        public Room GetRoomById(string rid, int did)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Room> GetRooms()
        {
            return _rooms;
        }

        public void UpdateRoom(Room r)
        {
            throw new NotImplementedException();
        }
    }
}
