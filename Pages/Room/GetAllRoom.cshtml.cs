using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RoskildeStudentHousing.Services.Interfaces;

namespace RoskildeStudentHousing.Pages.Room
{
    public class GetAllRoomModel : PageModel
    {
        IRoomService _iroomService;
        [BindProperty] public string searchString { get; set; }

        public IEnumerable<Models.Room> rooms { get; set; }

        public GetAllRoomModel(IRoomService roomService)
        {
            _iroomService = roomService;
        }

        public void OnGet()
        {
            rooms = _iroomService.GetRooms();
        }
        public IActionResult OnPostEmpty()
        {
            rooms = _iroomService.GetEmptyRooms();
            return Page();
        }

        public IActionResult OnPostOccupied()
        {
            rooms = _iroomService.GetOccupiedRooms();
            return Page();
        }
        public IActionResult OnPostReset()
        {
            rooms = _iroomService.GetRooms();
            return Page();
        }
        public IActionResult OnPostEmptyDormSearch(string dorm)
        {
            rooms = _iroomService.GetAllEmptyRoomsByDorm(searchString);
            return Page();
        }
    }
}
