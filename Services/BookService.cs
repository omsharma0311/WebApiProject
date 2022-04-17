using System.Collections.Generic;
using System.Linq;
using Web_APi.Models;

namespace Web_APi.Services
{
    public class BookService : IBookService
    {
        public static List<Books> Books = new List<Books>{
            new Books{ BookId = 0102, BookAuthor = "Cormen", BookName = "CLRS", NickName = "CLRS BOOKS", Subject="Data Structure"},
            new Books{ BookId = 0103, BookAuthor = "Peter Galvin", BookName = "OS", NickName = "Dinosaur BOOKS", Subject="Operating System"}
        };

        public List<Books> GetAllBooks()
        {
            return Books;
        }
        public Books GetBookById(int id)
        {
            return Books.FirstOrDefault(x => x.BookId == id);
        }
        public List<Books> AddBooks(Books newBooks)
        {
            Books.Add(newBooks);
            return Books;
        }
        public List<Books> UpdateBooks(Books updateBooks)
        {
            Books books = Books.FirstOrDefault(x => x.BookId == updateBooks.BookId);
            books.BookName = updateBooks.BookName;
            books.BookAuthor = updateBooks.BookAuthor;
            books.NickName =  updateBooks.NickName;
            books.Subject = updateBooks.Subject;
            return Books;
        }
    }
}