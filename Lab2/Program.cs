using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        //Part 1
        Console.WriteLine("This is my IT 1050 Lab 2 program Part 1, Variable Declarations");
        int myLabTwoNum = 123;
        Console.WriteLine("My int example number is " + myLabTwoNum);
        double myLabTwoDoubleNum = 9.876543219876D;
        Console.WriteLine("My double example number is " + myLabTwoDoubleNum);
        float myLabTwoFloatNum1 = 1.23456F;
        Console.WriteLine("My float example number is " + myLabTwoFloatNum1);
        char myLabTwoCharExample = 'A';
        Console.WriteLine("My char example is \"" + myLabTwoCharExample + "\"");
        bool myLabTwoBoolexample = true;
        Console.WriteLine("My bool example is \"" + myLabTwoBoolexample + "\"");
        string myLabTwoStringExample = "I am having a much easier time coding this week";
        Console.WriteLine("My string example is \"" + myLabTwoStringExample + "\"");
        
        //Part 2
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("This is my IT 1050 Lab 2 program Part 2, Type Casting");
        double myLabTwoDoubleNum2 = 9.78D;
        Console.WriteLine("My Part Two double example is " + myLabTwoDoubleNum2 );
        int myLabTwoNum2 = (int) myLabTwoDoubleNum2;
        Console.WriteLine("My part Two double to int explicit casting example is " + myLabTwoNum2);
        Console.WriteLine("My part Two int converted into a string is \"" + Convert.ToString(myLabTwoNum) + "\"");
        Console.WriteLine("My part Two bool converted into a string is \"" + Convert.ToString(myLabTwoBoolexample) + "\"");
       
        //Part 3
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("This is my IT 1050 Lab 2 program Part 3, User Input and Type Conversion");
        Console.WriteLine("Please enter username and press the enter key to submit");
        string user1Name = Console.ReadLine();
        Console.WriteLine("Username is now \"" + user1Name + "\"");
        Console.WriteLine("Thank you " + user1Name + " for inputting your username. Please enter your age and press the enter key to submit");
        int user1Age = Convert.ToInt32(Console.ReadLine()); 
        /* This is entered because the command Console.Readline() inputs values as a string by default, 
        if the value is needed as a number variable it must be converted into one after having been input as a string variable*/
        Console.WriteLine("Thank you for inputting your age. Your age has been entered as \"" + user1Age + "\"");
        Console.WriteLine("Hello " + user1Name + "! Congratulations on making it to " + user1Age + " years old! Thank you for registering in this program.");
        
        //Part 4
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("This is my IT 1050 Lab 2 program Part 4, Arithmetic Operators");
        int num1 = 14;
        Console.WriteLine("Number 1 for part four is " + num1);
        int num2 = 25;
        Console.WriteLine("Number 2 for part four is " + num2);
        //Addition
        Console.WriteLine(num1 + " + 10 = " + (num1 + 10));
        Console.WriteLine(num2 + " + 10 = " + (num2 + 10));
        //Subtraction
        Console.WriteLine(num1 + " - 2 = " + (num1 - 2));
        Console.WriteLine(num2 + " - 2 = " + (num2 - 2));
        //Multiplication
        Console.WriteLine(num1 + " * 3 = " + (num1 * 3));
        Console.WriteLine(num2 + " * 3 = " + (num2 * 3));    
        //Division
        Console.WriteLine(num1 + " / 2 = " + (num1 / 2));
        //Note that this was done with an int and the corrosponding answer is not entirely accurate, due to a lack of decimil places
        Console.WriteLine(num2 + " / 2 = " + (num2 / 2)); 
        //Note that this was done with an int and the corrosponding answer is not entirely accurate, due to a lack of decimil places  
        //Modulus
        Console.WriteLine(num1 + " modulus of 2 = " + (num1 % 2));
        Console.WriteLine(num2 + " modulus of 2 = " + (num2 % 2)); 
       
        //Part 5 
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("This is my IT 1050 Lab 2 program Part 5, Floating Point Precision");
        float myLabTwoFloatNum2 = 1.123456789F; 
        Console.WriteLine("The \"floating\" value of 1.123456789 is \"" + myLabTwoFloatNum2 + "\""); 
        //Ensure that if you change the value of myLabTwoFloatNum2 that you also change the text accordingly.
        double myLabTwoDoubleNum3 = 1.123456789D;
        Console.WriteLine("The \"double\" value of 1.123456789 is \"" + myLabTwoDoubleNum3 + "\""); 
        //Ensure that if you change the value of myLabTwoDoubleNum3 that you also change the text accordingly.
      
        //Part 6
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("This is my IT 1050 Lab 2 program Part 6, Increment and Decrement");
        int myLabTwoNum3 = 10;
        Console.WriteLine("Part 6's number is \"" + myLabTwoNum3 + "\"");
        //Increment operator adds one number.
        Console.WriteLine("Part 6's number is now \"" + ++myLabTwoNum3 + "\" after using the Increment operator to add one number");
        //Original variable myLabTwoNum3 now changed for the remainder of the program.
        Console.WriteLine("The orignial Part 6 number has been changed to \"" + myLabTwoNum3 + "\" for the remainder of the program");
        //Decrement operator subtracts one number.
        Console.WriteLine("Part 6's number is now \"" + --myLabTwoNum3 + "\" after using the Decrement operator to subtract one number");
        //Original variable myLabTwoNum3 now changed for the remainder of the program.
        Console.WriteLine("The orignial Part 6 number has been changed to \"" + myLabTwoNum3 + "\" for the remainder of the program");
        


         

    }
}
