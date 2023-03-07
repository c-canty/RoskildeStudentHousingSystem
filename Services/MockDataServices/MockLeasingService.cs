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

        public void AddLeasing(Leasing r)
        {
            throw new NotImplementedException();
        }

        public void DeleteLeasing(Leasing r)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LeasingRoomStudentDorm> GetAllCollectedInformation()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LeasingRoomStudentDorm> GetAllCollectedInformationFromDorm(string dorm)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LeasingRoomStudentDorm> GetAllCollectedInformationFromRoom(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LeasingRoomStudentDorm> GetAllCollectedInformationFromStudentId(string sid)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Leasing> GetAllLeasings()
        {
            throw new NotImplementedException();
        }

        public Leasing GetLeasingById(string id)
        {
            throw new NotImplementedException();
        }

        public Leasing GetLeasingByRoomNumber(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Leasing> GetLeasings()
        {
            return _leasings;
        }

        public IEnumerable<Leasing> GetLeasingsByDormId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Leasing> GetLeasingsByStudentId(string id)
        {
            throw new NotImplementedException();
        }

        public void UpdateLeasing(Leasing r)
        {
            throw new NotImplementedException();
        }
    }
}
