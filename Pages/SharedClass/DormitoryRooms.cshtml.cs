using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RoskildeStudentHousing.Services.Interfaces;

namespace RoskildeStudentHousing.Pages.SharedClass
{
    public class DormitoryRoomsModel : PageModel
    {
        IDormitoryService _idormitoryService;

        public IEnumerable<Models.LeasingRoomStudentDorm> leasingRoomStudentDorms { get; set; }

        public DormitoryRoomsModel(IDormitoryService dormitoryService)
        {
            _idormitoryService = dormitoryService;
        }

        public void OnGet()
        {
            //leasingRoomStudentDorms = _idormitoryService.GetAllCollectedInformationFromDorm();
        }
    }
}
