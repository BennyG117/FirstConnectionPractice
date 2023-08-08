using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstConnectionPractice.Models;

namespace FirstConnectionPractice.Controllers;

public class PetController : Controller
{
    private readonly ILogger<PetController> _logger;
    
    //! Add field - adding context into our class // "db" can eb any name
    private MyContext db;


    //! update below adding context, etc
    public PetController(ILogger<PetController> logger, MyContext context)
    {
        _logger = logger;
        db = context;
    }


    // AllPosts Route - update View*
    [HttpGet("")]
    public IActionResult Index()
    {
        return View("AllPets");
    }


    // New View Route
    [HttpGet("pets/new")]
    public IActionResult NewPet()
    {
        return View("New");
    }


    //! CreatePost method
    [HttpPost("pets/create")]
    public IActionResult CreatePet(Pet newPet)
    {
        if(!ModelState.IsValid)
        {
            return View("New");
        }
        //! using db table name "Posts"
        db.Pets.Add(newPet);
        db.SaveChanges();
        return RedirectToAction("Index");
    }


    // Privacy Route
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
