using BookHub.DataAccess.Data;
using BookHub.DataAccess.Repository.IRepository;
using BookHub.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookHub.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            List<Category> objCategoryList = _unitOfWork.Category.GetAll().ToList();
            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (category.Name == category.DisplayOrder.ToString())
            {
                ModelState.AddModelError("DisplayOrder", "Name and Display Order cannot be same");
            }
            if (ModelState.IsValid)
            {
                _unitOfWork.Category.Add(category);
                _unitOfWork.Save();
                TempData["success"] = "Category Created Successfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category? categoryFromDb = _unitOfWork.Category.Get(u => u.Id == id);
            //Category? categoryFromDb1 = _db.Categories.FirstOrDefault(u=>u.Id == id);    
            //Category? categoryFromDb2 = _db.Categories.Where(u=>u.Id == id).FirstOrDefault();    
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }

        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("DisplayOrder", "Name and Display Order cannot be same");
            }
            if (ModelState.IsValid)
            {
                _unitOfWork.Category.Update(obj);
                _unitOfWork.Save();

                TempData["success"] = "Category Updated Successfully";

                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category? categoryFromDb = _unitOfWork.Category.Get(u => u.Id == id);
            //Category? categoryFromDb1 = _db.Categories.FirstOrDefault(u=>u.Id == id);    
            //Category? categoryFromDb2 = _db.Categories.Where(u=>u.Id == id).FirstOrDefault();    
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }

        [HttpPost, ActionName("Delete")]

        public IActionResult DeletePost(int? id)
        {
            Category? obj = _unitOfWork.Category.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            _unitOfWork.Category.Remove(obj);
            _unitOfWork.Save();

            TempData["success"] = "Category Deleted Successfully";

            return RedirectToAction("Index");
        }
    }
}
