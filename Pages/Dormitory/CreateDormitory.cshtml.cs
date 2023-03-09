using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RoskildeStudentHousing.Services.Interfaces;

namespace RoskildeStudentHousing.Pages.Dormitory
{
    public class CreateDormitoryModel : PageModel
    {

        IDormitoryService _idormitoryService;

        [BindProperty]
        public Models.Dormitory Dormitory { get; set; }

        public CreateDormitoryModel(IDormitoryService dormitoryService)
        {
            _idormitoryService = dormitoryService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }


        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _idormitoryService.AddDorm(Dormitory);
            return RedirectToPage("/Dormitory/GetAllDormitory");
        }
    }
}
