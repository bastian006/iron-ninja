 // Create a buffet with a menu of IConsumables
        Buffet buffet = new Buffet();
        buffet.AddToMenu(new Food("Pizza", 800, false, true));
        buffet.AddToMenu(new Food("Sushi", 500, true, false));
        buffet.AddToMenu(new Food("Burger", 1200, false, false));

        // Create a SweetTooth and a SpiceHound
        SweetTooth sweetTooth = new SweetTooth();
        SpiceHound spiceHound = new SpiceHound();

        // Have both consume from the buffet until full
        while (!sweetTooth.IsFull)
        {
            IConsumable item = buffet.Serve();
            sweetTooth.Consume(item);
        }

        while (!spiceHound.IsFull)
        {
            IConsumable item = buffet.Serve();
            spiceHound.Consume(item);
        }

        // Determine and display which ninja consumed the most items
        int sweetToothConsumedItems = sweetTooth.ConsumptionHistory.Count;
        int spiceHoundConsumedItems = spiceHound.ConsumptionHistory.Count;

        if (sweetToothConsumedItems > spiceHoundConsumedItems)
        {
            Console.WriteLine("SweetTooth consumed the most items: " + sweetToothConsumedItems);
        }
        else if (spiceHoundConsumedItems > sweetToothConsumedItems)
        {
            Console.WriteLine("SpiceHound consumed the most items: " + spiceHoundConsumedItems);
        }
        else
        {
            Console.WriteLine("Both ninjas consumed the same number of items: " + sweetToothConsumedItems);
        }
    