using lesson_2.Data;
using lesson_2.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace lesson_2.Pages
{
    [BindProperties]
    public class CreateBookModel : PageModel
    {
        private readonly AppDbContext _context;
        public CreateBookModel(AppDbContext context) {
            _context=context;
        }
        [Required(ErrorMessage = "�������� ����������� � ����������")]
        [StringLength(50)]
        [DataType(DataType.Text)]
        [Display(Name = "�������� �����:")]
        public string? BookName { get; set; }
        [Required(ErrorMessage = "����� ���������")]
        [DataType(DataType.Currency, ErrorMessage = "������� �������������� ����")]
        [Display(Name = "��������� �����:")]
        public decimal BookPrice { get; set; }
        public string? BookAuthor { get; set; }
        public int Pages { get; set; }
        public Book? newBook { get; set; }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();
            newBook = new Book()
            {
                Name = BookName,
                Price = BookPrice,
                Author = BookAuthor,
                PageCount = Pages
            };

            _context.Add(newBook);
            _context.SaveChanges();
            return RedirectToPage("/Index");
        }
    }
}
