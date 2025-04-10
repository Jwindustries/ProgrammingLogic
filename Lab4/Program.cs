using System.Diagnostics;
using Microsoft.VisualBasic;

namespace Lab4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello! This is my IT 1050 week 4 program");

        Console.WriteLine("-------------------------------------------------------------------------------------");
        //Problem 1 : Simple For Loop
        Console.WriteLine("This is Part 1");
        for (int problemOneInt = 1; problemOneInt <= 10; problemOneInt = problemOneInt + 1)
        {
            Console.WriteLine(problemOneInt);

        }
        Console.WriteLine("This is the end of Part 1");

        Console.WriteLine("-------------------------------------------------------------------------------------");
        //Problem 2 : Even numbers from 1 to 20 (Using Modulus Operator)
        Console.WriteLine("This is Part 2");
        
        for (int problemTwoInt = 1; problemTwoInt <= 20; problemTwoInt = problemTwoInt + 1)
        {
            if (problemTwoInt == 1)
                {
                    // Console.WriteLine(problemTwoInt); Redacted this line because post check showed that I am not to print out the number "1" 
                }
            else if (problemTwoInt % 2 == 0)
                {
                    Console.WriteLine(problemTwoInt);  
                }
            else

                {} //Placeholder code - NO TOUCH - This allows it to return to the top of the for statement and add another 1 to the number so it might cycle. 



        }   
        Console.WriteLine("This is the end of Part 2");

        Console.WriteLine("-------------------------------------------------------------------------------------"); 
        //Problem 3 : While loop countdown
        Console.WriteLine("This is the start of Part 3");

        int problemThreeInt = 6;
        while (problemThreeInt >= 2)
        {
            Console.WriteLine(problemThreeInt = problemThreeInt - 1);
        }



        Console.WriteLine("This is the end of Part 3");

        Console.WriteLine("-------------------------------------------------------------------------------------");
        //Problem 4 : Do/While User Input
        Console.WriteLine("This is the start of Part 4");
        int problemFourInt = 0;
        

        do
        {
            Console.WriteLine("Enter a number greater than 100");
            problemFourInt = Convert.ToInt32 (Console.ReadLine());

        }
        while (problemFourInt <= 100);

        Console.WriteLine("You have entered " + problemFourInt + " which is greater than 100.");
        Console.WriteLine("This is the end of Part 4");
        
        Console.WriteLine("-------------------------------------------------------------------------------------");
        //Problem 5 : While Loop - Multiples of 10 to 1000

        Console.WriteLine("This is the start of Part 5");

        int problemFiveInt = 0;
        do
        {
            Console.WriteLine (problemFiveInt = problemFiveInt + 10);
        }
        while (problemFiveInt <= 990);


        Console.WriteLine("This is the end of Part 5");

        Console.WriteLine("-------------------------------------------------------------------------------------");
        //Problem 6 : Pattern Printer (Using Nested Loops)

        Console.WriteLine ("This is the start of Part 6");

        for (int problemSixIntA = 1; problemSixIntA <= 10; problemSixIntA = problemSixIntA + 1)
        {
            for (int problemSixIntB = 1; problemSixIntB <= problemSixIntA; problemSixIntB = problemSixIntB + 1)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }



        Console.WriteLine("This is the end of Part 6");




    }
}
