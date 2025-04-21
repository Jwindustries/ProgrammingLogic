namespace Lab5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World! This is Lab 5 for IT 1050");

        //Problem 1

        string[] seasons = {"Spring", "Summer", "Fall", "Winter"};

            foreach (string season in seasons)
            {
                Console.WriteLine("Season: " + season);
            }

        //Problem 2

        string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

        Console.WriteLine("Enter a number between 1 and 7.");

        if (int.TryParse(Console.ReadLine(), out int dayInt))
        {
            if (dayInt >= 1 && dayInt <= 7)
            {
                Console.WriteLine("That day is: " + days[dayInt - 1]);
            }
            else
            {
                Console.WriteLine("Enter a number between 1 and 7.");
            }




        }
        else
        {
            Console.WriteLine("Enter a number between 1 and 7.");
        }

        //Problem 3
        //1984 is a favorite book of mine as well, very pertinent to today's world.

        string[] books = {"The hunt for Red October", "The Spy and the Traitor", "1984"};

        string[] authors = {"Tom Clancy", "Ben Macintyre", "George Orwell"};

        for (int bookNumInt = 0; bookNumInt < books.Length; bookNumInt++)
        {
            Console.WriteLine("Book " + (bookNumInt + 1) + " is " + books[bookNumInt] + " by " + authors[bookNumInt]);
        }

        //Problem 4

        int[] temperatures = {65, 72, 78, 70, 68};

        Array.Sort(temperatures);

        Console.WriteLine("Sorted Temperatures in acending order.");
        foreach (int temperature in temperatures)
        {
            Console.WriteLine(temperature);
        }
        int temperatureLow = temperatures[0];
        Console.WriteLine("The lowest temperature is " + temperatureLow);

        int temperaturehigh = temperatures[temperatures.Length - 1];
        Console.WriteLine("The highest temperature is " + temperaturehigh);

        //Problem 5

        int[] countdown = {5, 4, 3, 2, 1};
        Array.Reverse (countdown);
        
        for (int countdownInt = 0; countdownInt < 5; countdownInt++)
        {
            Console.WriteLine(countdown[countdownInt]);
        }
    }
}
