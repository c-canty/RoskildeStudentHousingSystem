using RoskildeStudentHousing.Models;
using RoskildeStudentHousing.Services.Interfaces;

namespace RoskildeStudentHousing.Services.MockDataServices
{
    public class MockLeasingService : ILeasingService
    {
        private List<Leasing> leasings;

        public MockLeasingService()
        {
            leasings = MockData.MockDataLeasing.GetAllLeasings();
        }


    }
}
