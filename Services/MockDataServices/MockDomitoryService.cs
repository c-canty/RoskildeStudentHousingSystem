using RoskildeStudentHousing.Models;
using RoskildeStudentHousing.Services.Interfaces;

namespace RoskildeStudentHousing.Services.MockDataServices
{
    public class MockDomitoryService : IDormitoryService 
    {
        private List<Dormitory> _dormitoryList;

        public MockDomitoryService()
        {
            _dormitoryList = MockData.MockDataDormitory.GetAllDormitories();
        }

    }
}
