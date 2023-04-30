using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TamagotchiWebbApp.Models;

public class TamagotchiController : Controller
{
    private static List<Tamagotchi> _tamagotchis = new List<Tamagotchi>();

    public IActionResult Index()
    {
        return View(_tamagotchis);
    }

    public IActionResult New()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Tamagotchi tamagotchi)
    {
        _tamagotchis.Add(tamagotchi);
        return RedirectToAction(nameof(Index));
    }
}
