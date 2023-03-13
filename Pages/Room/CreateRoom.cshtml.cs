using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RoskildeStudentHousing.Services.Interfaces;

namespace RoskildeStudentHousing.Pages.Room
{
    public class CreateRoomModel : PageModel
    {
        IRoomService _iroomService;

        [BindProperty]
        public Models.Room room {  get; set; } = new Models.Room();

        public CreateRoomModel(IRoomService roomService)
        {
            _iroomService = roomService;
        }

        public void OnGet(int did)
        {
            room.DormitoryNo = did;
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            
            _iroomService.AddRoom(room);
            return RedirectToPage("/Room/GetAllRoom");
        }
    }
}
