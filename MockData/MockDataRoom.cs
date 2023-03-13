using RoskildeStudentHousing.Models;

namespace RoskildeStudentHousing.MockData
{
    public class MockDataRoom
    {

        public static List<Room> roomsList = new List<Room>()
        {
            new Room(1, "2 bedrooms", 5400, 1),
            new Room(2, "2 bedrooms", 5300, 2),
            new Room(3, "Studio", 0, 3)
        };

        public static List<Room> GetAllRooms()
        {
            return roomsList;
        }

    }
}
