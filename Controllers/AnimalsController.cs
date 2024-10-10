using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; 
using System.Threading.Tasks; 
using WebApplication1.Models;

public class AnimalsController : Controller
{
    private readonly MobileContext _context;

    public AnimalsController(MobileContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var animals = _context.Animals.ToList();
        return View(animals);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Animal animal)
    {
        if (ModelState.IsValid)
        {
            _context.Animals.Add(animal);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(animal);
    }
}
