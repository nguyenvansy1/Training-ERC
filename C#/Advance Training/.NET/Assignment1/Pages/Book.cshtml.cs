using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesBook.Models;
using RazorPagesBook.Services;

namespace BookPage.Pages
{
    public class BookModel : PageModel
    {
        public List<Book> books = new();
        [BindProperty]
        public Book NewBook { get; set; } = new();

        public void OnGet()
        {
            books = BookService.GetAll();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            BookService.Add(NewBook);
            return RedirectToAction("Get");
        }

        public IActionResult OnPostDelete(int id)
        {
            BookService.Delete(id);
            return RedirectToAction("Get");
        }
    }
}
