using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RoskildeStudentHousing.Services.Interfaces;

namespace RoskildeStudentHousing.Pages.Leasing
{
    public class GetAllLeasingModel : PageModel
    {
        ILeasingService _ileasingService;

        public IEnumerable<Models.Leasing> leasing { get; set; }

        public GetAllLeasingModel(ILeasingService leasingService)
        {
            _ileasingService = leasingService;
        }

        public void OnGet()
        {
            leasing = _ileasingService.GetAllLeasings();
        }
    }
}
