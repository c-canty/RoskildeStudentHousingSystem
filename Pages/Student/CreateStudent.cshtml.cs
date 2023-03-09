using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RoskildeStudentHousing.Services.Interfaces;

namespace RoskildeStudentHousing.Pages.Student
{
    public class CreateStudentModel : PageModel
    {
        IStudentService _IstudentService;

        [BindProperty]
        public Models.Student Students { get; set; }

        public CreateStudentModel(IStudentService studentService)
        {
            _IstudentService = studentService;
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

            _IstudentService.AddStudent(Students);
            return RedirectToPage("/Student/GetAllStudent");
        }
    }
}
