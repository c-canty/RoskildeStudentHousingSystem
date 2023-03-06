using RoskildeStudentHousing.Models;

namespace RoskildeStudentHousing.MockData
{
    public class MockDataLeasing
    {
       public static List<Leasing> leasingsList = new List<Leasing>()
       {
            new Leasing(1,  new DateTime(2021, 12, 01), new DateTime(2023, 05, 01), 1, 1, 1),
            new Leasing(2,  new DateTime(2020, 05, 01), new DateTime(2030, 01, 01), 2, 2, 2),
            new Leasing(3,  new DateTime(2023, 01, 16), new DateTime(2030, 01, 01), 3, 3, 3)

       };
        
        public static List<Leasing> GetAllLeasings()
        {
            return leasingsList;
        }

    }
}
