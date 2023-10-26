class SpiceHound : Ninja
{
    public override bool IsFull => calorieIntake >= 1200;

    public override void Consume(IConsumable item)
    {
        if (!IsFull)
        {
            calorieIntake += item.Calories;
            ConsumptionHistory.Add(item);

            Console.WriteLine($"{item.GetInfo()}");
            if (item.IsSpicy)
            {
                calorieIntake -= 5;
            }
        }
        else
        {
            Console.WriteLine("SpiceHound is full and cannot consume more.");
        }
    }
}