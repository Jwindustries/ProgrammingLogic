using System.Collections.Concurrent;
using System.Formats.Asn1;

namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        //Intro
        Console.WriteLine("This is my IT 1050 Lab 3");






        //Part 1 Operator Practise
        int MyLabThreeIntA = 10;
        Console.WriteLine("My integer variable A is " + MyLabThreeIntA);
        int MyLabThreeIntB = 5;
        Console.WriteLine("My integer variable B is " + MyLabThreeIntB);
        int MyLabThreeIntC = 15;
        Console.WriteLine("My integer variable C is " + MyLabThreeIntC);

        //Check to see if A is greater than B
        Console.WriteLine("Is A greater than B? (A > B): " + (MyLabThreeIntA > MyLabThreeIntB));

        //Check to see if A is less than C
        Console.WriteLine("Is A less than C? (A > C): " + (MyLabThreeIntA < MyLabThreeIntC));

        //Check to see if A is greater than both B and C
        Console.WriteLine("Is A greater than both B and C? ((A > B) && (A > C)): " + ((MyLabThreeIntA > MyLabThreeIntB) && (MyLabThreeIntA > MyLabThreeIntC)));

        //Check to see if A is greater than B or if A is greater than C
        Console.WriteLine("Is A greater than B or is A greater than C? ((A > B)||(A > C)): " + ((MyLabThreeIntA > MyLabThreeIntB)||(MyLabThreeIntA > MyLabThreeIntC)));




        //Part 2 Boolean Logic

        Console.WriteLine("If its raining you should take an umbrella with you to prevent you from getting wet");
        bool isRaining = true;
        Console.WriteLine("Its raining today");
        bool haveUmbrella = false;
        Console.WriteLine("You do not have an umbrella");
        if (isRaining && haveUmbrella)
        {
            Console.WriteLine("Your good to go!");
        }
        else
        {
            Console.WriteLine("Take an umbrella!"); 
        }



        //Part 3 Conditional Logic 
        //Prompt user for their age
        Console.WriteLine("What is your age? Please enter in numerical form and press the enter key");
        int MyLabThreeUserAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your age has been entered as " + MyLabThreeUserAge);

        //Use logic to decern what the appropriate ticket price is

        if (MyLabThreeUserAge < MyLabThreeIntB) //If the users age is below 5 the ticket is free
        {
            Console.WriteLine("Your ticket is free!");
        }
        else if (MyLabThreeUserAge >= 5 && MyLabThreeUserAge < 12)       
        {
            Console.WriteLine("Child ticket: $5");
        }
        else if (MyLabThreeUserAge >= 13 && MyLabThreeUserAge <64)
        {  
            Console.WriteLine("Standard ticket: $10");
        }
        else
        {
            Console.WriteLine("Senior Ticket: $6");
        }
        
        //Part 4 Using a switch Statement
        
        
        Console.WriteLine("Enter a day of the week in numerical form and press the enter key. Choose from 1-Monday, 2-Tuesday, 3-Wednesday, 4-Thursday, 5-Friday, 6-Saturday, 7-Sunday");
        int dayOfWeek = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You have entered " + dayOfWeek);
        
        if ( dayOfWeek > 0 && dayOfWeek < 8)
        {
            Console.WriteLine("You have entered a valid day");
            switch (dayOfWeek)
            {
                case 1:
                    Console.WriteLine("That is Monday");
                    break;
                case 2:
                    Console.WriteLine("That is Tuesday");
                    break;
                case 3:
                    Console.WriteLine("That is Wednesday");
                    break;
                case 4:
                    Console.WriteLine("That is Thursday");
                    break;
                case 5:
                    Console.WriteLine("That is Friday");
                    break;
                case 6:
                    Console.WriteLine("That is Saturday");
                    break;
                case 7:
                    Console.WriteLine("That is Sunday");
                    break;

            }

        }
        else
        {
            Console.WriteLine("You have entered an invalid day! Choose from 1-Monday, 2-Tuesday, 3-Wednesday, 4-Thursday, 5-Friday, 6-Saturday, 7-Sunday");
        }



   }
}
