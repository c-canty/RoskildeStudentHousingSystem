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

        public void AddDorm(Dormitory dorm)
        {
            throw new NotImplementedException();
        }

        public void DeleteDorm(Dormitory dorm)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Dormitory> FilterDormsByName(string filter)
        {
            throw new NotImplementedException();
        }

        public Dormitory GetDormById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Dormitory> GetDormitory()
        {
            return _dormitoryList;
        }

        public void UpdateDorm(Dormitory dorm)
        {
            throw new NotImplementedException();
        }
    }
}
