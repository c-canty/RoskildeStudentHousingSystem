using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RoskildeStudentHousing.Services.Interfaces;

namespace RoskildeStudentHousing.Pages.SharedClass
{
    public class DormitoryRoomsModel : PageModel
    {
        IDormitoryService _idormitoryService;

        [BindProperty]
        public IEnumerable<Models.LeasingRoomStudentDorm> leasingRoomStudentDorms { get; set; }

        public DormitoryRoomsModel(IDormitoryService dormitoryService)
        {
            _idormitoryService = dormitoryService;
        }

        public IActionResult OnGet(string id)
        {
            leasingRoomStudentDorms = _idormitoryService.GetAllCollectedInformationFromDorm(id);
            if (leasingRoomStudentDorms == null)
            {
                return RedirectToPage("/NotFound");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            return Page();
        }
    }
}
