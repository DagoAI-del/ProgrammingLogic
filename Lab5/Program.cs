namespace Lab5;

// Step 1 – Base Class
class Animal
{
    public virtual void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

// Step 2 – Derived Classes
class Cat : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The cat says: meow");
    }
}

class Dog : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The dog says: bow wow");
    }
}








class Program
{
    static void Main(string[] args)
    {
         // Step 3 – Test in Main()

        Animal myAnimal = new Animal();
        Animal myCat = new Cat();
        Animal myDog = new Dog();

        myAnimal.animalSound(); // Outputs: The animal makes a sound
        myCat.animalSound();    // Outputs: The cat says: meow
        myDog.animalSound();    // Outputs: The dog says: bow wow
    }
}
