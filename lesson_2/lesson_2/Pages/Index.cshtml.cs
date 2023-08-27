using lesson_2.Data;
using lesson_2.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace lesson_2.Pages
{
    public class IndexModel : PageModel
    {
        public List<Book>? Books { get; set; }
        private readonly AppDbContext _context;
        public IndexModel(AppDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Books = _context.Books.ToList();
        }
        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var book = await _context.Books.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (book != null)
            {
                _context.Books.Remove(book);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("/Index");
        }
    }
}