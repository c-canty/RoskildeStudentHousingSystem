using RoskildeStudentHousing.Models;

namespace RoskildeStudentHousing.MockData
{
    public class MockDataRoom
    {

        public static List<Room> roomsList = new List<Room>()
        {

        };

        public static List<Room> GetAllRooms()
        {
            return roomsList;
        }

    }
}
