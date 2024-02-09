using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PetParty.Models;

namespace PetParty.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public static List<Pet> FakePetDb = new();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View("Index");
    }

    [HttpPost("pets/create")]
    public IActionResult CreatePet(Pet newPet)
    {
        if (!ModelState.IsValid)
        {
            var message = string.Join(" | ", ModelState.Values
                .SelectMany(v => v.Errors)
                .Select(e => e.ErrorMessage));
            Console.WriteLine(message);
        }

        if(!ModelState.IsValid)
        {
            return View("Index");
        }
        FakePetDb.Add(newPet);
        HttpContext.Session.SetString("LastPet", newPet.Name);

        // FakePetDb.SaveChanges();
        Console.WriteLine($"{newPet.Name} is a {newPet.Age} year(s) old {newPet.Species} {(newPet.IsCute ? "they are cute" : "they are rugged")}");
        return RedirectToAction("AllPets");
    }

    [HttpGet("pets")]
    public IActionResult AllPets()
    {
        // ViewBag.AllPets = FakePetDb;
        // string? LastPet = HttpContext.Session.GetString("LastPet");
        if (HttpContext.Session.GetString("LastPet") == null)
        {
            return RedirectToAction("Index");
        }
        return View(FakePetDb);
    }

    [HttpPost("pets/limit")]
    public RedirectToActionResult SetFilter(int Limit)
    {
        HttpContext.Session.SetInt32("Limit", Limit);
        return RedirectToAction("AllPets");
    }

    [HttpPost("pets/limit/clear")]
    public RedirectToActionResult ClearFilter()
    {
        // HttpContext.Session.Clear(); //this will remove EVERYTHING from session
        HttpContext.Session.Remove("Limit");
        return RedirectToAction("AllPets");
    }

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
