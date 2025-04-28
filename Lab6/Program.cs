using System;
using System.Drawing;

class Car
{
  public string model;
  public string color;
  public int year;

  public void Start()
  {
    Console.WriteLine("The Car is starting");
  }

  public void Drive(int miles)
  {
    Console.WriteLine($"The Car Drove {miles} miles");
  }

  public string GetDescription()
  {
    return $"{year} {color} {model}";

  }

  public void Repaint(string newColor)
  {
    color = newColor;
    Console.WriteLine($"The car has been repainted to {newColor}");
  }

  // Example method to display car details. You can use this as an example for the other methods.
  public void Display()
  {
    Console.WriteLine("Car Details:");
    Console.WriteLine("Model: " + model);
    Console.WriteLine("Color: " + color);
    Console.WriteLine("Year: " + year);
  }
  
  
}


class Program
{
  static void Main()
  {
    // Creating a Car object and assigning values to its properties
    Car myCar = new Car();
    myCar.model = "Civic";
    myCar.color = "Black";
    myCar.year = 2020;

    myCar.Display(); // Calling the Display method

    myCar.Start();   //Calling the Start method   

    myCar.Drive(50); //Calling the Drive Method with parameter of (50)

    String carDescription = myCar.GetDescription();
    Console.WriteLine(carDescription);

    myCar.Repaint("Red");
    

  }

}