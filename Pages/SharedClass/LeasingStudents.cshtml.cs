using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RoskildeStudentHousing.Services.Interfaces;

namespace RoskildeStudentHousing.Pages.SharedClass
{
    public class LeasingStudentsModel : PageModel
    {
        IStudentService _iStudentService;
        ILeasingService _iLeasingService;

        public IEnumerable<Models.LeasingRoomStudentDorm> leasing { get; set; }

        public LeasingStudentsModel(IStudentService studentService, ILeasingService iLeasingService)
        {
            _iStudentService = studentService;
            _iLeasingService = iLeasingService;
        }

        public void OnGet()
        {
            leasing = _iLeasingService.GetAllCollectedInformation();
        }

        public IActionResult OnPost(string studentId) 
        { 
           leasing = _iStudentService.GetAllCollectedInformationFromStudentId(studentId);
            return RedirectToPage("LeasingStudents");
        }
        public IActionResult OnPostReset()
        {
            leasing = _iLeasingService.GetAllCollectedInformation();
            return RedirectToPage("LeasingStudents");
        }
    }
}
