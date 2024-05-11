using ECommerce.Database;
using ECommerce.Entities.Concrete;
using ECommerce.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers;

public class CategoryController: Controller
{
    private readonly ECommerceDb _context;

    public CategoryController(ECommerceDb _context)
    {
        this._context = _context;
    }
    public IActionResult Index()
    {
        ViewBag.Categories = _context.Categories.ToList();
        ViewBag.Products = _context.Products.ToList();
        return View();
    }

    [HttpGet]
    public IActionResult AddCategory()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddCategory(CategoryVM c)
    {
        
        _context.Categories.Add(new Category(){Name = c.Name});
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult RemoveCategory(int id)
    {
        Category c = _context.Categories.FirstOrDefault(c => c.Id == id);
        _context.Categories.Remove(c);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}