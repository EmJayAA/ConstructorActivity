/*
Aranzado, Martin Jonas A.
Quino, Bryan E.
*/
using System;
public class Book
{
    private readonly string? title;
    private readonly string? author;
    private readonly int? yearPublished;
    private readonly string? genre;

    //Constructor 1
    public Book()
    {
        title = "Unknown";
        author = "Unknown";
        yearPublished = 0;
        genre = "Unknown";
    }

    //Constructor 2
    public Book(string Title, string Author)
    {
        title = Title;
        author = Author;
        yearPublished = 0;
        genre = "Unknown";
    }

    //Constructor 3
    public Book(string Title, string Author, int YearPublished)
    {
        title = Title;
        author = Author;
        yearPublished = YearPublished;
        genre = "Unknown";
    }

    //Constructor 4
    public Book(string Title, string Author, int YearPublished, string Genre)
    {
        title = Title;
        author = Author;
        yearPublished = YearPublished;
        genre = Genre;
    }

    public string DisplayBookInfo()
    {
        return $"Title: {title}\n" +
               $"Author: {author}\n" +
               $"Year Published: {yearPublished}\n" +
               $"Genre: {genre}\n";
    }

    static void Main()
    {
        //Book 1
        Console.WriteLine("---Book 1: Default Constructor---");
        Book book1 = new Book();
        Console.WriteLine(book1.DisplayBookInfo());

        //Book 2
        Console.WriteLine("\n--- Book 2: Basic Constructor ---");
        Book book2 = new Book("To Kill a Mockingbird", "Harper Lee");
        Console.WriteLine(book2.DisplayBookInfo());

        //Book 3
        Console.WriteLine("\n--- Book 3: Detailed Constructor ---");
        Book book3 = new Book("1984", "George Orwell", 1925);
        Console.WriteLine(book3.DisplayBookInfo());

        //Book 4
        Console.WriteLine("\n--- Book 4: Complete Constructor ---");
        Book book4 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925, "Fiction/Tragedy");
        Console.WriteLine(book4.DisplayBookInfo());
    }
}
