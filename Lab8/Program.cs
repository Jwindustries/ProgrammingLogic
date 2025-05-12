using System;

public class Animal
{
    public virtual void animalSound()
    {
        Console.WriteLine("The animal makes a sound!");
    }
}

public class Cat : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The cat says Meow!");
    }
}

public class Dog : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The dog says Bow! Wow!");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Animal myAnimal = new Animal();  
        Animal myCat = new Cat();        
        Animal myDog = new Dog();        

        myAnimal.animalSound();
        myCat.animalSound();
        myDog.animalSound();
    }
}