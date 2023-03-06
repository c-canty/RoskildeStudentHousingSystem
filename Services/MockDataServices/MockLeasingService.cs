using RoskildeStudentHousing.Models;
using RoskildeStudentHousing.Services.Interfaces;

namespace RoskildeStudentHousing.Services.MockDataServices
{
    public class MockLeasingService : ILeasingService
    {
        private List<Leasing> _leasings;

        public MockLeasingService()
        {
            _leasings = MockData.MockDataLeasing.GetAllLeasings();
        }


    }
}
