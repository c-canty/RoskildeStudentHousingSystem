using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RoskildeStudentHousing.Services.Interfaces;

namespace RoskildeStudentHousing.Pages.SharedClass
{
    public class LeasingStudentsModel : PageModel
    {
        IStudentService _iStudentService;
        ILeasingService _iLeasingService;
        IDormitoryService _dormitoryService;

        [BindProperty] public string SearchString { get; set; }
        [BindProperty] public string SearchStringDorm { get; set; }

        public IEnumerable<Models.LeasingRoomStudentDorm> leasing { get; set; }
        public IEnumerable<Models.Dormitory> Dorms { get; set; }

        public LeasingStudentsModel(IStudentService studentService, ILeasingService iLeasingService, IDormitoryService dormitoryService)
        {
            _iStudentService = studentService;
            _iLeasingService = iLeasingService;
            _dormitoryService = dormitoryService;
            Dorms = _dormitoryService.GetDormitory();
        }

        public void OnGet()
        {
            leasing = _iLeasingService.GetAllCollectedInformation();
        }

        public IActionResult OnPostIdSearch(string studentId) 
        {  
           leasing = _iStudentService.GetAllCollectedInformationFromStudentId(SearchString).ToList();
            return Page();
        }
        public IActionResult OnPostReset()
        {
            leasing = _iLeasingService.GetAllCollectedInformation();
            return Page();
        }
        public IActionResult OnPostDormSearch(string dorm)
        {
            if(SearchString == "silo")
            {
                SearchString = "Silo";
            }
            if (SearchString == "musicon")
            {
                SearchString = "Musicon";
            }
            if (SearchString == "spritfabrikken")
            {
                SearchString = "Spritfabrikken";
            }
            leasing = _dormitoryService.GetAllCollectedInformationFromDorm2(SearchString);
            return Page();
        }
    }
}
