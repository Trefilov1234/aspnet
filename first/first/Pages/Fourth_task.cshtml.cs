using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace first.Pages
{
    public class Fourth_taskModel : PageModel
    {
        public List<string> Rests { get; set; }
        public void OnGet()
        {
            Rests = new List<string>() { "REST1", "REST2", "REST3", };
        }
    }
}
