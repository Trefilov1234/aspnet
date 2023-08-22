using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace first.Pages
{
    public class Fifth_taskModel : PageModel
    {
        public List<Country> Countries { get; set; }
        public void OnGet()
        {
            Countries=new List<Country>() { 
                new Country(){Name="name1",CountCivils=1,Description="Description1"},
                new Country(){Name="name2",CountCivils=2,Description="Description2"},
                new Country(){Name="name3",CountCivils=3,Description="Description3"},
            };
        }
    }
    public class Country
    {
        public string? Name { get; set; }
        public int CountCivils { get;set; }
        public string? Description { get;set; }
    }
}
