class SpiceHound : Ninja
{
  public override bool IsFull
  {
    get { return calorieIntake > 1200; }
  }

  public override void Consume(IConsumable item)
  {
    if (IsFull)
    {
      Console.WriteLine("This Spice hound is full...");
      return;
    }


    int adjustedCals;
    if (item.IsSpicy)
    {
      adjustedCals = item.Calories - 5;
    }
    else
    {
      adjustedCals = item.Calories;
    }
    calorieIntake += adjustedCals;
    ConsumptionHistory.Add(item);
    item.GetInfo();
  }
}