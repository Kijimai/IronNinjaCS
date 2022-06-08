class Drink : IConsumable
{
  public String Name { get; set; }
  public int Calories { get; set; }
  public bool IsSpicy { get; set; }
  public bool IsSweet { get; set; }

  public Drink(string name, int calories, bool isSpicy, bool isSweet)
  {
    Name = name;
    Calories = calories;
    IsSpicy = isSpicy;
    IsSweet = isSweet;
  }

  public string GetInfo()
  {
    return $"Name: {Name}, Calories: {Calories}, isSpicy: {IsSpicy}, isSweet: {IsSweet}";
  }

}