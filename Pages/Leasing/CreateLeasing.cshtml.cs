using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RoskildeStudentHousing.Services.Interfaces;

namespace RoskildeStudentHousing.Pages.Leasing
{
    public class CreateLeasingModel : PageModel
    {
        ILeasingService _ileasingService;

        [BindProperty]
        public Models.Leasing Leasing { get; set; } = new Models.Leasing();

        public CreateLeasingModel(ILeasingService leasingService)
        {
            _ileasingService = leasingService;
        }

        public void OnGet(int rid, int did)
        {
            Leasing.RoomNo = rid;
            Leasing.DormitoryNo = did;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _ileasingService.AddLeasing(Leasing);
            return RedirectToPage("/Leasing/GetAllLeasing");
        }

    }
}
