using RoskildeStudentHousing.Models;

namespace RoskildeStudentHousing.MockData
{
    public class MockDataDormitory
    {
        public static List<Dormitory> dormitoriesList = new List<Dormitory>()
        {
            new Dormitory(1, "Silo", "Roskilde"),
            new Dormitory(2, "Musicon", "Holbæk"),
            new Dormitory(3, "Trekroner", "Slagelse")
        };


        public static List<Dormitory> GetAllDormitories()
        {
            return dormitoriesList;
        }
    }
}
