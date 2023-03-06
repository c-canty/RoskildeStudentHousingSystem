using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RoskildeStudentHousing.Models;
using RoskildeStudentHousing.Services.Interfaces;

namespace RoskildeStudentHousing.Pages.Student
{
    public class GetAllStudentModel : PageModel
    {
        IStudentService _iStudentService;

        public List<Models.Student>  students { get; set; }

        public GetAllStudentModel(IStudentService studentService)
        {
            _iStudentService = studentService;
        }

        public void OnGet()
        {
            students = _iStudentService.GetStudents();
        }
    }
}
