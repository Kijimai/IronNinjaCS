class SweetTooth : Ninja
{

  public override bool IsFull
  {
    get { return calorieIntake > 1500; }
  }
  public override void Consume(IConsumable item)
  {
    if (IsFull)
    {
      Console.WriteLine("I AM SO FULL PLEASE. STOP.");
      return;
    }
    int adjustedCals;
    if (item.IsSweet)
    {
      adjustedCals = item.Calories + 10;
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