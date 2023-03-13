namespace RoskildeStudentHousing.Models
{
    public class DateClass
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public DateClass()
        {
            
        }

        public DateClass(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
