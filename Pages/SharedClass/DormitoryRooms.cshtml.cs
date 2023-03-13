using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RoskildeStudentHousing.Services.Interfaces;

namespace RoskildeStudentHousing.Pages.SharedClass
{
    public class DormitoryRoomsModel : PageModel
    {
        IDormitoryService _idormitoryService;

        [BindProperty]
        public IEnumerable<Models.DormsRooms> dormsRooms { get; set; }

        public DormitoryRoomsModel(IDormitoryService dormitoryService)
        {
            _idormitoryService = dormitoryService;
        }

        public IActionResult OnGet(string id)
        {
            dormsRooms = _idormitoryService.GetAllCollectedInformationFromDorm(id);
            if (dormsRooms == null)
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
