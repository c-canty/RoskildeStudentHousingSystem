namespace RoskildeStudentHousing.Models
{
    public class LeasingRoomStudentDorm
    {
        public string StudentId { get; set; }
        public string StudentName { get; set;}
        public int RoomId { get; set; }
        public string Address { get; set; }
        public string DormName { get; set; }
        public int Price { get; set; }
        public string RoomType { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int LeasingId { get; set; }

        public LeasingRoomStudentDorm()
        {
        }

    }

}




 