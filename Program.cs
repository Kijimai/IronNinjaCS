Buffet myBuffet = new Buffet();
SweetTooth newSweetTooth = new SweetTooth();
SpiceHound newSpiceHound = new SpiceHound();

while (!newSweetTooth.IsFull)
{
  newSweetTooth.Consume(myBuffet.Serve());
}

while (!newSpiceHound.IsFull)
{
  newSpiceHound.Consume(myBuffet.Serve());
}

Ninja winner;
if (newSweetTooth.ConsumptionHistory.Count > newSpiceHound.ConsumptionHistory.Count)
{
  winner = newSweetTooth;
}
else
{
  winner = newSpiceHound;
}

Console.WriteLine($"{winner} won!");