using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem
{
    // Yazarlar Tablosu (Authors)
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
    }

    // Kitaplar Tablosu (Books)
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Yazarlar Tablosu
            List<Author> authors = new List<Author>
            {
                new Author { AuthorId = 1, Name = "J.K. Rowling" },
                new Author { AuthorId = 2, Name = "George R.R. Martin" },
                new Author { AuthorId = 3, Name = "J.R.R. Tolkien" }
            };

            // Kitaplar Tablosu
            List<Book> books = new List<Book>
            {
                new Book { BookId = 1, Title = "Harry Potter and the Sorcerer's Stone", AuthorId = 1 },
                new Book { BookId = 2, Title = "A Game of Thrones", AuthorId = 2 },
                new Book { BookId = 3, Title = "The Hobbit", AuthorId = 3 },
                new Book { BookId = 4, Title = "Harry Potter and the Chamber of Secrets", AuthorId = 1 }
            };

            // LINQ Join Sorgusu
            var booksWithAuthors = from book in books
                                   join author in authors
                                   on book.AuthorId equals author.AuthorId
                                   select new
                                   {
                                       BookTitle = book.Title,
                                       AuthorName = author.Name
                                   };

            // Sonuçları Yazdırma
            Console.WriteLine("Kitaplar ve Yazarları:");
            foreach (var item in booksWithAuthors)
            {
                Console.WriteLine($"Kitap: {item.BookTitle}, Yazar: {item.AuthorName}");
            }

            Console.ReadKey();
        }
    }
}
