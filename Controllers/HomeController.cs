using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using proyectoNuevo.Models;

namespace proyectoNuevo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    // public IActionResult Privacy()
    // {
    //     return View();
    // }

    public IActionResult ItemMuestra()
    {
        Item item = new Item
        {
            id = 1,
            name = "Caja de cigarrillos",
            type = "Suplemento alimenticio",
            STR = 10,
            AGI = 10,
            INTE = 10,
            MND = 10,
            VIT = 10
        };
        // return Content("Hola!"); //Podemos retornar lo que se nos de la gana
        return View(item);
    }

    public IActionResult CharacterMuestra() //id, name, type, hp, speed, attack, defense, weight
    {
        Character character = new Character
        {
            id = 1,
            name = "Finn el humano",
            type = "Humano",
            HP = 10,
            SPEED = 5,
            ATTACK = 16,
            DEFENSE = 3,
            WEIGHT = 55
        };
        return View(character);
    }

    public IActionResult VehicleMuestra() //id, name, brand, TOPSPEED, WIDTH, LENGHT, WEIGHT
    {
        Vehicle vehicle = new Vehicle
        {
            id = 1,
            name = "MX-5",
            brand = "Mazda",
            TOPSPEED = 220,
            WIDTH = 5,
            LENGTH = 16,
            WEIGHT = 55
        };
        return View(vehicle);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
