namespace HistoryIn20Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                
                foreach (HistoricalEvent db in EventsDB.Events)
                {
                    Console.Write("This is the year of the historic event: ");
                    Console.WriteLine(db.Year);
                    Console.WriteLine();

                    Console.WriteLine("Press any key to show the name of the event.\n");
                    Console.ReadKey(true);
                    Console.WriteLine($"Name:\n{db.Name}\n");

                    Console.WriteLine("Press \'d\' to show the description of the event, else to continue.\n");

                    if (Console.ReadKey(true).Key == ConsoleKey.D)
                    {
                        Console.WriteLine($"Description:\n{db.Description}\n");

                        if (db.ContainsExtraDescription())
                        {
                            Console.WriteLine("Press \'e\' to show the extra description of the event, else to continue.\n");
                            if (Console.ReadKey(true).Key == ConsoleKey.E)
                            {
                                Console.WriteLine($"Extra Description:\n{db.ExtraDescription}\n");
                            }
                        }
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey(true);
                    }
                    Console.Clear();
                }

                Console.WriteLine("Press \'q\' to quit, else to restart.");
                if (Console.ReadKey(true).Key == ConsoleKey.Q) break;
            }
            
        }
    }
}
