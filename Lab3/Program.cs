namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        //Problem 1: Simple For Loop

        for (int xum = 1; xum <= 10; xum++)
        {
            Console.WriteLine(xum);
        }
        //Problem 2: Even Numbers from 1 to 20 (Using Modulus Operator)

        for (int xam = 1; xam <= 20; xam++) // Loop from 1 to 20, inclusive
        {
            if (xam % 2 == 0)           // Check if 'i' is divisible by 2
            {
                Console.WriteLine(xam); // Print the even number
            }

            //Problem 3: While Loop Countdown

            int a = 5;                 // Start at 5
            while (a >= 1)             // Loop as long as 'a' is greater than or equal to 1
            {
                Console.WriteLine(a); // Print the current value of 'a'
                a--;                  // Decrease 'a' by 1 each time
            }

            int num = 10;
            while (num <= 1000)
            {
                Console.WriteLine(num);
                num += 10;
            }

            //Problem 5: Seasons of the Year
            // Declare and initialize the array
            string[] seasons = { "Spring", "Summer", "Fall", "Winter" };

            // Loop through each element with foreach
            foreach (string season in seasons)
            {
                Console.WriteLine(season);

            }
            //Problem 6: Days of the Week (1–7)

             string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            Console.Write("Enter a number from 1 to 7: ");
              string userInput = Console.ReadLine();
             try
             {
            // Try to convert the input string into a interger
              int dayNumber = Convert.ToInt32(userInput);

            // Check if the number is in the valid range
             if (dayNumber >= 1 && dayNumber <= 7)
             {
            // Display the matching day name (array is 0-based, so subtract 1)
                 Console.WriteLine("The day is: " + days[dayNumber - 1]);
               }
               else
                {
            Console.WriteLine("Please enter a number between 1 and 7.");
               }
             }
               catch
              {
            // If conversion fails, show an error message
            Console.WriteLine("Invalid input. Make sure you enter a number like 1, 2, or 3.");
             }

            //Problem 7: Favorite Books and Authors
            // Array of 3 favorite book titles
            string[] books = { "La storia", "La revoltee", "La ronde des jours" };

            // Array of authors corresponding to each book
            string[] authors = { "Elsa Morente", "Guy des Cars", "Bernard Dadie" };

            // Loop through each book and print the title with its author
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine(books[i] + " by " + authors[i]);
            }

            //Problem 8: Temperature Tracker

            // Create an integer array with 5 temperature values
            int[] temperatures = { 91, 52, 77, 88, 79 };

            // Sort the array in ascending order
            Array.Sort(temperatures);

            // Print sorted temperatures
            Console.WriteLine("Temperatures in ascending order:");
            foreach (int temp in temperatures)
            {
                Console.WriteLine(temp);
            }

            // Print the lowest and highest temperatures
            Console.WriteLine("Lowest temperature: " + temperatures[0]);
            Console.WriteLine("Highest temperature: " + temperatures[temperatures.Length - 1]);
    
             //Problem 9: Reverse Countdown
            // Declare an integer array with values from 5 to 1
        int[] numbS = { 5, 4, 3, 2, 1 };

        // Reverse the array using Array.Reverse()
        Array.Reverse(numbS);

        // Use a for loop to display the reversed array
        Console.WriteLine("Reversed array:");
        for (int i = 0; i < numbS.Length; i++)
        {
            Console.WriteLine(numbS[i]);
        }
        }
    }

    }

