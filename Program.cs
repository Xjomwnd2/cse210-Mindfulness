using System;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        
        while (!quit)
        {
            // Display the menu
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;
                case "2":
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;
                case "4":
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}