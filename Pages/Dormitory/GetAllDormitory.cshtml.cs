using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RoskildeStudentHousing.Services.Interfaces;

namespace RoskildeStudentHousing.Pages.Dormitory
{
    public class GettAllDormitoryModel : PageModel
    {
        IDormitoryService _idormitoryService;

        public List<Models.Dormitory> dormitory;

        public GettAllDormitoryModel(IDormitoryService dormitoryService)
        {
            _idormitoryService = dormitoryService;
        }

        public void OnGet()
        {
            dormitory = MockData.MockDataDormitory.GetAllDormitories();
        }
    }
}
