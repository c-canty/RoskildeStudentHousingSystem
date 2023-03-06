using RoskildeStudentHousing.Models;

namespace RoskildeStudentHousing.MockData
{
    public class MockDataLeasing
    {
       public static List<Leasing> leasingsList = new List<Leasing>()
       {
            new Leasing(),
            new Leasing(),
            new Leasing(),
            new Leasing(),
       };
        
        public static List<Leasing> GetAllLeasings()
        {
            return leasingsList;
        }

    }
}
