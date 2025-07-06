using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Lab1;

class Program
{
    static void Main(string[] args)
    {

        // Step 1

        /*  Name: Dago Augustin
            Title: IT-1050 - Lab 1 */

        // Step 2
        string name = "Dago Augustin";
        string coursetitle = " IT-1050 - Lab 1";

        Console.WriteLine(name);
        Console.WriteLine(coursetitle);

        // Step 3
        int favoritNum1 = 10;
        int favoritNum2 = 20;
        Console.WriteLine($"My favorite numbers are {favoritNum1} and {favoritNum2}");


        string favProgram1 = " Python";
        string favProgram2 = "C#";
        Console.WriteLine("My favorite programs are " + favProgram1 + " and " + favProgram2);

        double numProgrambefor = 12.5D;
        Console.WriteLine("The numbers of programs I have written before are " + numProgrambefor);

        bool programExperience = true; //Yes
        Console.WriteLine("Have I any experience in programming? Answer: " + programExperience);

        // Step 4

        const string schoolName = "Tri-C";
        Console.WriteLine("My school name is" + schoolName);

        // Step 5

        double numDouble = 9.78D;
        Console.WriteLine("My double number is " + numDouble);

        int numBint = (int)numDouble;
        Console.WriteLine("My converted double into interger is " + (int)numDouble);

        int numInt = 22;
        Console.WriteLine("My converted number into string is " + Convert.ToString(numInt));

        bool myBool = false;
        Console.WriteLine("My answer was " + Convert.ToString(myBool));

        // Step 6

         Console.WriteLine("Please enter your name");
         string userName = Console.ReadLine();
         Console.WriteLine("Please enter your age");
         int userAge = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("Hello guy, your name is  " + userName + " and your are " + userAge + " years old.");

        // Step 7

        int num1 = 17;
        int num2 = 24;

        int Addition = num1 + 10;
        Console.WriteLine("The addiction of num1 add 10 is " + Addition);

        int Substraction = num2 - 2;
        Console.WriteLine("The substraction of num2 minus 2 is " + Substraction);

        int Multiplication = num1 * 3;
        Console.WriteLine(" The result of the multiplication is " + Multiplication);

        int Division = num1 / 2;
        Console.WriteLine("The result of divison is " + Division);

        int Modulus = num2 % 2;
        Console.WriteLine("The result of the modulus is " + Modulus);

        // Step 8
        float floatValue = 1.123456789f;
        double doubleValue = 1.123456789D;
        Console.WriteLine(" float value is " + floatValue + " and double value is " + doubleValue);
        // double have more digits than the float one

        // Step 9
        int numBer = 10;
        numBer++; // increment

        Console.WriteLine("The increment result is " + numBer);

        numBer--;
        Console.WriteLine("The decrement result is " + numBer);

        





        


    }
}
