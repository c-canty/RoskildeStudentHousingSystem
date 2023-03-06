using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RoskildeStudentHousing.Services.Interfaces;

namespace RoskildeStudentHousing.Pages.Leasing
{
    public class GetAllLeasingModel : PageModel
    {
        ILeasingService _ileasingService;

        public List<Models.Leasing> leasing;

        public GetAllLeasingModel(ILeasingService leasingService)
        {
            _ileasingService = leasingService;
        }

        public void OnGet()
        {
            leasing = MockData.MockDataLeasing.GetAllLeasings();
        }
    }
}
