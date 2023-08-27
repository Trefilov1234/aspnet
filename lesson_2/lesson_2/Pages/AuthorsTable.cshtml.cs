using lesson_2.Data;
using lesson_2.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace lesson_2.Pages
{
    public class AuthorsTableModel : PageModel
    {
        public List<Author>? Authors { get; set; }
        private readonly AppDbContext _context;
        public AuthorsTableModel(AppDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Authors=_context.Authors.ToList();
        }
        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var author = await _context.Authors.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (author != null)
            {
                _context.Authors.Remove(author);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("/AuthorsTable");
        }
    }
}
