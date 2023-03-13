using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RoskildeStudentHousing.Models;
using RoskildeStudentHousing.Services.Interfaces;

namespace RoskildeStudentHousing.Pages.Student
{
    public class DeleteStudentModel : PageModel
    {
        [BindProperty] public Models.Student student { get; set; }


        private IStudentService studentService { get; set; }

        public DeleteStudentModel(IStudentService _studentService)
        {
            this.studentService = _studentService;
        }
        public void OnGet(string StudentNo)
        {

            student = studentService.GetStudentById(StudentNo);
        }
        public IActionResult OnPost(string StudentNo)
        {
            student = studentService.GetStudentById(StudentNo);
            studentService.DeleteStudent(student);
            return RedirectToPage("GetAllStudent");
        }
    }
}
