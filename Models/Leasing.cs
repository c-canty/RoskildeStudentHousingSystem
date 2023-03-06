namespace RoskildeStudentHousing.Models
{
    public class Leasing
    {
        public int LeasingNo { get; set; }
        public DateTime DateTimeFrom { get; set; }
        public DateTime DateTimeTo { get; set; }
        public int StudentNo { get; set; }
        public int RoomNo { get; set; }

        public Leasing()
        {
            
        }

        public Leasing(int leasingNo, DateTime dateTimeFrom, DateTime dateTimeTo, int stundentNo, int roomNo)
        {
            LeasingNo = leasingNo;
            DateTimeFrom = dateTimeFrom;
            DateTimeTo = dateTimeTo;
            StudentNo = stundentNo;
            RoomNo = roomNo;
        }

    }
}
