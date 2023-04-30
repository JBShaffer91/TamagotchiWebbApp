using System;

namespace TamagotchiWebbApp.Models
{
  public class Tamagotchi
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public int Food { get; set; }
    public int Attention { get; set; }
    public int Rest { get; set; }
    public DateTime LastInteractedWith { get; set; }
  }
}
