using lesson_2.Data;
using lesson_2.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace lesson_2.Pages
{
    [BindProperties]
    public class CreateAuthorModel : PageModel
    {
        private readonly AppDbContext _context;
        public CreateAuthorModel(AppDbContext context)
        {
            _context = context;
        }
        [Required(ErrorMessage = "Название обязательно к заполнению")]
        [StringLength(50)]
        [DataType(DataType.Text)]
        [Display(Name = "Имя автора:")]
        public string? AuthorFirstName { get; set; }
        [Required(ErrorMessage = "Название обязательно к заполнению")]
        [StringLength(50)]
        [DataType(DataType.Text)]
        [Display(Name = "Фамилия автора:")]
        public string? AuthorLastName { get; set; }
        [Required(ErrorMessage = "Нужно заполнить")]
        [DataType(DataType.Date, ErrorMessage = "Введите действительную дату")]
        [Display(Name = "Дата рождения автора:")]
        public DateTime AuthorBirthday { get; set; }
        public Author? NewAuthor { get; set; }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();
            NewAuthor = new Author()
            {
                FirstName = AuthorFirstName,
                LastName = AuthorLastName,
                BirthDate = AuthorBirthday,
            };

            _context.Add(NewAuthor);
            _context.SaveChanges();
            return RedirectToPage("/AuthorsTable");
        }
    }
}
