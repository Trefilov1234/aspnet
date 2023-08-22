using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace first.Pages
{
    public class quotesModel : PageModel
    {
        public Dictionary<string, string> Data { get; set; }
        public KeyValuePair<string, string> Value { get; set; }
        public void OnGet()
        {
            Data = new Dictionary<string, string>() {
                {"PUSHKIN1","QUOTE1" },
                {"PUSHKIN2","QUOTE2" },
                {"PUSHKIN3","QUOTE3" },
                {"PUSHKIN4","QUOTE4" }
            };
            Random rnd = new Random();
            int index = rnd.Next(0, 4);
            Value= Data.ElementAt(index);
        }
    }
}
