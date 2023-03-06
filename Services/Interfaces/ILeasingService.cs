using RoskildeStudentHousing.Models;

namespace RoskildeStudentHousing.Services.Interfaces
{
    public interface ILeasingService
    {

        IEnumerable<Leasing> GetLeasings();
    }
}
