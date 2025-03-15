using System.Data;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyectoNuevo.Data;
using proyectoNuevo.Models;

namespace proyectoNuevo.Controllers;

public class HomeController : Controller
{
    private readonly MySQLDbContext _context;
    public HomeController(MySQLDbContext context)
    {
        _context = context;
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

    public async Task<IActionResult> VerItems()
    {
        List<Item> arrItems = await _context.Items.ToListAsync();
        return View(arrItems);
    }

    public async Task<IActionResult> VerItem(int id)
    {
        Item? item = await _context.Items.FindAsync(id);
        if (item == null) return NotFound("No se encontró, lo siento mi loco");
        return View("ItemMuestra", item);
    }

    // Crear
    [HttpGet]
    public IActionResult Crear()
    {
        return View();
    }

    [HttpPost]
    // [ValidateAntiForgeryToken]
    public async Task<IActionResult> Crear(Item item)
    {
        if (item == null) return Error();
        if (ModelState.IsValid)
        {
            _context.Items.Add(item);
            await _context.SaveChangesAsync();
            return RedirectToAction("VerItems");
        }
        return View(item);
    }

    //Modificar
    [HttpGet]
    public async Task<IActionResult> Modificar(int id)
    {
        Item? item = await _context.Items.FindAsync(id);
        if (item == null) return NotFound();
        return View(item);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Modificar(Item item)
    {
        if (ModelState.IsValid)
        {
            try
            {
                _context.Items.Update(item);
                await _context.SaveChangesAsync();
            }
            catch (DBConcurrencyException)
            {
                return Content("Error al modificar el item");
            }
            return RedirectToAction("VerItems");
        }
        return View(item);
    }

    [HttpGet("Home/ElItem/{name}/{id}")] //Para que sea un link amigable
    public IActionResult ElItem(int id, string name)
    {
        return Content($"El id es: {id} y el nombre es {name}");
    }

    public IActionResult ItemESpecifico(int id)
    {
        Item[] arrItems = {
        new Item { id = 1, name = "Caja de cigarrillos", type = "Suplemento alimenticio", STR = 10, AGI = 10, INTE = 10, MND = 10, VIT = 1 },
        new Item { id = 2, name = "Caja de cerillos", type = "Suplemento alimenticio", STR = 8, AGI = 16, INTE = 17, MND = 6, VIT = 4 },
        new Item { id = 3, name = "Caja de cereal", type = "Suplemento alimenticio", STR = 5, AGI = 12, INTE = 3, MND = 4, VIT = 7 }
    };
        Item? item = arrItems.FirstOrDefault(p => id == p.id);
        if (item == null) return NotFound("No se econtró");
        return View("ItemMuestra", item);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
