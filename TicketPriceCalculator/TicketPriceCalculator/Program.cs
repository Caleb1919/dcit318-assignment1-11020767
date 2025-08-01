using System;

class MovieTicketPricing
{
    static void Main()
    {
        const decimal RegularPrice = 10.00m;
        const decimal DiscountPrice = 7.00m;

        Console.WriteLine("Movie Theater Ticket Pricing");
        Console.WriteLine("----------------------------");

        bool continuePricing = true;

        while (continuePricing)
        {
            // Prompt user for age
            Console.Write("\nPlease enter your age: ");

            // Read input and try to convert to integer
            if (int.TryParse(Console.ReadLine(), out int age) && age > 0)
            {
                // Calculate ticket price
                decimal price = (age <= 12 || age >= 65) ? DiscountPrice : RegularPrice;

                // Display result
                Console.WriteLine($"\nTicket price: GHC{price:F2}");

                // Add explanation if discount applied
                if (price == DiscountPrice)
                {
                    if (age <= 12)
                        Console.WriteLine("Child discount applied (age 12 or below)");
                    else
                        Console.WriteLine("Senior discount applied (age 65 or above)");
                }
            }
            else
            {
                Console.WriteLine("Error: Please enter a valid positive age.");
            }

            // Ask if user wants to continue
            Console.Write("\nCalculate another ticket price? (Y/N): ");
            string response = Console.ReadLine().Trim().ToUpper();

            if (response != "Y")
            {
                continuePricing = false;
            }
        }

        Console.WriteLine("\nThank you for using our ticket pricing system!");
    }
}