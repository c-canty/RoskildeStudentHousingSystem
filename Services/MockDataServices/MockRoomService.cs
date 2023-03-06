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

    }
}
