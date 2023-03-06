using RoskildeStudentHousing.Models;
using RoskildeStudentHousing.Services.Interfaces;

namespace RoskildeStudentHousing.Services.MockDataServices
{
    public class MockDomitoryService : IDormitoryService 
    {
        private List<Dormitory> dormitoryList;

        public MockDomitoryService()
        {
            dormitoryList = MockData.MockDataDormitory.GetAllDormitories();
        }

    }
}
