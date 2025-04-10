using System.Diagnostics;
using Microsoft.VisualBasic;

namespace Lab4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello! This is my IT 1050 week 4 program");

        //Problem 1 : Simple For Loop
        Console.WriteLine("This is Part 1");
        for (int problemOneInt = 1; problemOneInt <= 10; problemOneInt = problemOneInt + 1)
        {
            Console.WriteLine(problemOneInt);

        }
        Console.WriteLine("This is the end of Part 1");

        //Problem 2 : Even numbers from 1 to 20 (Using Modulus Operator)
        Console.WriteLine("This is Part 2");
        
        for (int problemTwoInt = 1; problemTwoInt <= 20; problemTwoInt = problemTwoInt + 1)
        {
            if (problemTwoInt == 1)
                {
                    Console.WriteLine(problemTwoInt);
                }
            else if (problemTwoInt % 2 == 0)
                {
                    Console.WriteLine(problemTwoInt);  
                }
            else

                {} //Placeholder code - NO TOUCH - This allows it to return to the top of the for statement and add another 1 to the number so it might cycle. 



        }   
        Console.WriteLine("This is the end of Part 2");

        //Problem 3 : While loop countdown
        Console.WriteLine("This is the start of Part 3");

        int problemThreeInt = 5;
        while (problemThreeInt >= 1)
        {
            Console.WriteLine(problemThreeInt = problemThreeInt - 1);
        }



        Console.WriteLine("This is the end of Part 3");






    }
}
