using System.Collections.Generic;
using Web_APi.Models;

namespace Web_APi.Services
{
    public interface IBookService
    {
         List<Books> GetAllBooks();
         Books GetBookById(int id);
         List<Books> AddBooks(Books newBooks);
         List<Books> UpdateBooks(Books updateBooks);
    }
}