using System.Formats.Asn1;
using System.Reflection.Metadata;

namespace Lab2;

class Program
{
    static void Main(string[] args)
    {

        // Part 1: Operator Practice
        int a = 10, b = 5, c = 15;
        Console.WriteLine(a > b);
        Console.WriteLine(a < c);
        Console.WriteLine(a > b && a > c);
        Console.WriteLine(a > b || a > c);

        //Part 2: Boolean Logic
        bool isRaining = true;
        bool haveUmbrella = false;

        if (isRaining && haveUmbrella)
        {
            Console.WriteLine("Take an umbrella!");
        }

        else { Console.WriteLine("You're good to go!"); }


        //Part 3: Conditional Logic – Movie Ticket Pricing

        Console.WriteLine("Please enter your age");
        int userAge = Convert.ToInt32(Console.ReadLine());
        if (userAge < 5)
        { Console.WriteLine("Ticket is free!"); }

        else if (userAge >= 5 && userAge <= 12)
        { Console.WriteLine("Child ticket: $5"); }

        else if (userAge >= 13 && userAge <= 64)
        { Console.WriteLine("Standard ticket: $10"); }

        else if (userAge >= 65)
        { Console.WriteLine("Senior ticket: $6"); }

        //Part 4: Using a switch Statement

        Console.WriteLine("Please enter a day of the week (1-7)");
        int day = Convert.ToInt32(Console.ReadLine());

        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid day");
                break;
    
            }
        
    
    }
}
