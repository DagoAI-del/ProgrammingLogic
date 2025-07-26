namespace Lab4;
using System;

class Car
{
    public string model;
    public string color;
    public int year;
    // Example method to display car details.
    public void Display()
    {
        Console.WriteLine("Car Details:");
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Year: " + year);
    }


    public void Start()
    {
        Console.WriteLine("The car is starting.");
    }

    public void Drive(int miles)
    {
        Console.WriteLine("My car drove " + miles + " miles .");
    }

    public string GetDescription()
    {
        return year + " " + color + " " + model;

    }
     
     public void Repaint(string newColor)
{
    color = newColor;
    Console.WriteLine("The car has been repainted to "+ color+ " .");
}
    
}




class Program
{
    static void Main(string[] args)
    {
        // Creating a Car object and assigning values to its properties
        Car myCar = new Car();
        myCar.model = "Civic";
        myCar.color = "Black";
        myCar.year = 2020;

        myCar.Display(); // Calling the Display method
         myCar.Start();   // Calling the Start 
         myCar.Drive(50); // Calling the drive method

        string description = myCar.GetDescription();
        Console.WriteLine(description);
        myCar.Repaint("Red");
        Console.WriteLine("Current color: " + myCar.color); 
        
    }
}
