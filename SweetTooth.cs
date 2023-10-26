class SweetTooth : Ninja
{
    public override bool IsFull => calorieIntake >= 1500;

    public override void Consume(IConsumable item)
    {
        if (!IsFull)
        {
            calorieIntake += item.Calories;
            ConsumptionHistory.Add(item);

            Console.WriteLine($"{item.GetInfo()}");
            if (item.IsSweet)
            {
                calorieIntake += 10;
            }
        }
        else
        {
            Console.WriteLine("SweetTooth is full and cannot consume more.");
        }
    }
}