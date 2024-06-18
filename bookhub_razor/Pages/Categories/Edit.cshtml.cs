using bookhub_razor.Data;
using bookhub_razor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace bookhub_razor.Pages.Categories
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public Category Category { get; set; }

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int? id)
        {
            if(id == null && id != 0)
            {
               Category =  _db.Categories.Find(id);
            }
        }

        public IActionResult OnPost()
        {
          if (ModelState.IsValid)
          {
                _db.Categories.Update(Category);
                _db.SaveChanges();
                TempData["success"] = "Category edited successfully";
                return RedirectToPage("Index");
          }
           return Page();
        }
    }
}
