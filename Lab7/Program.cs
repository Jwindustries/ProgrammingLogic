using System;

public class Book
{
    private string title;
    private string author;

    // Problem 1
    public Book()
    {
        title = "Unknown Title";
        author = "Unknown Author";
    }

    // Problem 2
    public Book(string title)
    {
        this.title = title;
        this.author = "Unknown Author";
    }

    // Problem 3
    public Book(string title, string author)
    {
        this.title = title;
        this.author = author;
    }

    // Problem 1
    public string GetTitle()
    {
        return title;
    }

    // Problem 1
    public void SetTitle(string newTitle)
    {
        title = newTitle;
    }

    // Problem 3
    public string GetAuthor()
    {
        return author;
    }

    // Problem 3
    public void SetAuthor(string newAuthor)
    {
        author = newAuthor;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Problem 1
        Console.WriteLine("Problem 1");

        Book book1 = new Book();
        Console.WriteLine(book1.GetTitle());  


        book1.SetTitle("C# Fundamentals");
        Console.WriteLine(book1.GetTitle());

        Console.WriteLine("----------------------------------------------------"); 


        // Problem 2
        Console.WriteLine("Problem 2");

        Book book2 = new Book("Advanced C#");
        Console.WriteLine(book2.GetTitle()); 

        Console.WriteLine("----------------------------------------------------"); 


        // Problem 3
        Console.WriteLine("Problem 3");

        Book book3 = new Book("Advanced C#", "John Doe");
        Console.WriteLine("Title: " + book3.GetTitle());
        Console.WriteLine("Author: " + book3.GetAuthor());

        Console.WriteLine("----------------------------------------------------"); 


        // Problem 4
        Console.WriteLine("Problem 4");

        Book book4 = new Book();
        book4.SetTitle("Mastering C#");
        book4.SetAuthor("Jane Smith");
        Console.WriteLine("Title: " + book4.GetTitle());
        Console.WriteLine("Author: " + book4.GetAuthor());







    }
}
