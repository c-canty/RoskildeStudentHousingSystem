using RoskildeStudentHousing.Models;

namespace RoskildeStudentHousing.MockData
{
    public class MockDataDormitory
    {
        public static List<Dormitory> dormitoriesList = new List<Dormitory>()
        {

        };


        public static List<Dormitory> GetAllDormitories()
        {
            return dormitoriesList;
        }
    }
}
