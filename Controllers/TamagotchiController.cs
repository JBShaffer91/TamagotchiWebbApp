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

  [HttpPost]
  public IActionResult Feed(int id)
  {
    _tamagotchis[id].Feed();
    return RedirectToAction(nameof(Index));
  }

  [HttpPost]
  public IActionResult Play(int id)
  {
    _tamagotchis[id].Play();
    return RedirectToAction(nameof(Index));
  }

  [HttpPost]
  public IActionResult Sleep(int id)
  {
    _tamagotchis[id].Sleep();
    return RedirectToAction(nameof(Index));
  }

  [HttpPost]
  public IActionResult TimePasses()
  {
    bool anyDead = false;

    foreach (var tamagotchi in _tamagotchis)
    {
      if (tamagotchi.TimePasses())
      {
        anyDead = true;
      }
    }

    if (anyDead)
    {
      ViewBag.Message = "One or more of your tamagotchis have died!";
    }

    return RedirectToAction(nameof(Index));
  }
}
