class Buffet
{
  public List<IConsumable> Menu;

  public Buffet()
  {
    Menu = new List<IConsumable>()
    {
      new Food("Mushroom Pasta", 1000, false, false),
      new Food("Green Bean Ice Cream", 10000, true, true),
      new Food("Hot Dog Water", 500, false, true),
      new Food("Cat Hair", 5, false, false),
      new Food("Toothpaste", 2, true, false),
      new Food("Cardboard", 10, false, false),
      new Food("5 Gum", 2, false, true),
      new Drink("Water", 0, false, false),
      new Drink("Whiskey Sour", 200, false, false)
    };
  }

  public IConsumable Serve()
  {
    Random rand = new Random();
    return Menu[rand.Next(Menu.Count)];
  }
}

