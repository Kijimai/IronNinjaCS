class Food : IConsumable
{
  public string Name { get; set; }
  public int Calories { get; set; }
  public bool IsSpicy { get; set; }
  public bool IsSweet { get; set; }

  public string GetInfo()
  {
    return $"Name: {Name}, Calories: {Calories}, isSpicy: {IsSpicy}, isSweet: {IsSweet}";
  }
  public Food(string name, int cal, bool isSpicy, bool isSweet)
  {
    Name = name;
    Calories = cal;
    IsSpicy = isSpicy;
    IsSweet = isSweet;
  }

}