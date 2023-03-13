using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RoskildeStudentHousing.Services.Interfaces;

namespace RoskildeStudentHousing.Pages.Dormitory
{
    public class GettAllDormitoryModel : PageModel
    {
        IDormitoryService _idormitoryService;

        public IEnumerable<Models.Dormitory> dormitory { get; set; }

        public GettAllDormitoryModel(IDormitoryService dormitoryService)
        {
            _idormitoryService = dormitoryService;
        }

        public void OnGet()
        {
            dormitory = _idormitoryService.GetDormitory();
        }
    }
}
