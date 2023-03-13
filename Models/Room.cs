namespace RoskildeStudentHousing.Models
{
    public class Room
    {
        public int RoomNo { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public int DormitoryNo { get; set; }


        public Room()
        {
        }

        public Room(int roomNo, string type, int price, int dormitoryNo)
        {
            RoomNo = roomNo;
            Type = type;
            Price = price;
            DormitoryNo = dormitoryNo;
        }
    }
}
