namespace RoskildeStudentHousing.Models
{
    public class Leasing
    {
        public int LeasingNo { get; set; }
        public DateTime DateTimeFrom { get; set; }
        public DateTime DateTimeTo { get; set; }

        public Leasing()
        {
            
        }

        public Leasing(int leasingNo, DateTime dateTimeFrom, DateTime dateTimeTo)
        {
            LeasingNo = leasingNo;
            DateTimeFrom = dateTimeFrom;
            DateTimeTo = dateTimeTo;
        }

    }
}
