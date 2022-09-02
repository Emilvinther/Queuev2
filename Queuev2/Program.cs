using System;

namespace Queuev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Manager manager = new Manager();

            // Menu list
            do
            {
                Console.WriteLine("==================================================");
                Console.WriteLine("            H1 Queue Operations Menu");
                Console.WriteLine("==================================================");
                Console.WriteLine("\n1. Add items");
                Console.WriteLine("2. Delete items");
                Console.WriteLine("3. Show the number of items");
                Console.WriteLine("4. Show min and max items");
                Console.WriteLine("5. Find an item");
                Console.WriteLine("6. Print all items");
                Console.WriteLine("7. Exit");
                Console.WriteLine("Indtast valg");

                int choice = int.Parse(Console.ReadLine());

                //Switch case calling methods
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Insert name on card");
                        string input = Console.ReadLine();
                        manager.EnqueueCard(input);
                        break;

                    case 2:
                        manager.Dequeue();
                        Console.WriteLine("Card Removed");
                        break;

                    case 3:
                        Console.WriteLine($"You have {manager.NumberOfItems()} items");
                        break;


                    case 4:
                        Console.WriteLine(manager.MinMaxItems());
                        break;

                    case 5:
                        Console.WriteLine("Ward card do you want to find?");
                        string input1 = Console.ReadLine();
                        Console.WriteLine(manager.FindItem(input1));
                        break;

                    case 6:
                        Console.WriteLine(manager.PrintAll());
                        break;

                    case 7:
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }

            } while (true);
        }
    }
}
