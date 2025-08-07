using System;

namespace BookClass
{
    
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
    }
}
