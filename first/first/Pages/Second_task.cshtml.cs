using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace first.Pages
{
    public class Second_taskModel : PageModel
    {
        public string Letter { get; set; }
        public int Value { get; set; }
        private string alphabet="abcdefghijklmnopqrstuvwxyz";
        public void OnGet()
        {
            Random rnd=new Random();
            Value = rnd.Next(0, 26);
            Letter = alphabet[Value].ToString();
        }
    }
}
