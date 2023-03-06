using RoskildeStudentHousing.Models;
using RoskildeStudentHousing.Services.Interfaces;

namespace RoskildeStudentHousing.Services.MockDataServices
{
    public class MockRoomService : IRoomService
    {
        private List<Room> rooms;

        public MockRoomService()
        {
            rooms = MockData.MockDataRoom.GetAllRooms();
        }

    }
}
