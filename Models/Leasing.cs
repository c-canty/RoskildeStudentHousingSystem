namespace RoskildeStudentHousing.Models
{
    public class Leasing
    {
        public int LeasingNo { get; set; }
        public DateTime DateTimeFrom { get; set; }
        public DateTime DateTimeTo { get; set; }
        public string StudentNo { get; set; }
        public int RoomNo { get; set; }
        public int DormitoryNo { get; set; }

        public Leasing()
        {
            
        }

        public Leasing(int leasingNo, DateTime dateTimeFrom, DateTime dateTimeTo, string stundentNo, int roomNo, int dormitoryNo)
        {
            LeasingNo = leasingNo;
            DateTimeFrom = dateTimeFrom;
            DateTimeTo = dateTimeTo;
            StudentNo = stundentNo;
            RoomNo = roomNo;
            DormitoryNo = dormitoryNo;
        }

    }
}
