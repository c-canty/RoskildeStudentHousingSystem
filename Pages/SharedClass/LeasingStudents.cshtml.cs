using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RoskildeStudentHousing.Models;
using RoskildeStudentHousing.Services.Interfaces;

namespace RoskildeStudentHousing.Pages.SharedClass
{
    public class LeasingStudentsModel : PageModel
    {
        IStudentService _iStudentService;
        ILeasingService _iLeasingService;
        IDormitoryService _dormitoryService;
        IRoomService _roomService;

        [BindProperty] public string SearchString { get; set; }
        [BindProperty] public string SearchStringDorm { get; set; }
        [BindProperty] public string SearchStringDorm2 { get; set; }
        [BindProperty] public string SearchStringRid{ get; set; }
        [BindProperty] public DateTime DateFrom { get; set; }
        [BindProperty] public DateTime DateTo { get; set; }

        public IEnumerable<Models.LeasingRoomStudentDorm> leasing { get; set; }   
        public IEnumerable<Models.Dormitory> Dorms { get; set; }

        public LeasingStudentsModel(IStudentService studentService, ILeasingService iLeasingService, IDormitoryService dormitoryService, IRoomService roomService)
        {
            _iStudentService = studentService;
            _iLeasingService = iLeasingService;
            _dormitoryService = dormitoryService;
            Dorms = _dormitoryService.GetDormitory();
            _roomService = roomService;
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
            leasing = _dormitoryService.GetAllCollectedInformationFromDorm2(SearchStringDorm); ;
            return Page();
        }
        public IActionResult OnPostRoomSearch(string rid, string dorm)
        {
            leasing = _roomService.GetAllCollectedInformationFromRoom(SearchStringRid, SearchStringDorm2);
            return Page();
        }
        public IActionResult OnPostDateSearch(DateTime dateFrom, DateTime dateTo)
        {
            leasing = _iLeasingService.GetAllCollectedInformationByDate(dateFrom , dateTo);
            return Page();
        }
    }
}
