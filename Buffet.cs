class Buffet
{
    private List<IConsumable> Menu;

    public Buffet()
    {
        Menu = new List<IConsumable>();
    }

    public void AddToMenu(IConsumable item)
    {
        Menu.Add(item);
    }

    public IConsumable Serve()
    {
        Random rand = new Random();
        int randomIndex = rand.Next(0, Menu.Count);
        return Menu[randomIndex];
    }
}