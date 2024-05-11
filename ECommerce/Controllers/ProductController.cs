using ECommerce.Database;
using ECommerce.Entities.Concrete;
using ECommerce.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers;

public class ProductController: Controller
{
    private readonly ECommerceDb _context;

    public ProductController(ECommerceDb _context)
    {
        this._context = _context;
    }

    public IActionResult Index()
    {
        ViewBag.Products = _context.Products.ToList();
        ViewBag.Categories = _context.Categories.ToList();
        return View();
    }

    [HttpGet]
    public IActionResult AddProduct()
    {
        ViewBag.Categories = _context.Categories.ToList();
        return View();
    }

    [HttpPost]
    public IActionResult AddProduct(ProductVM p)
    {
        Console.WriteLine(p.Category_Id);
        _context.Products.Add(new Product(){Name = p.Name , Cost = p.Cost , Category_Id = p.Category_Id});
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult RemoveProduct(int id)
    {
        Product product = _context.Products.FirstOrDefault(p => p.Id == id);
        _context.Products.Remove(product);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}