using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    
    public class InMemoryBookDal:IBookDal
    {
        List<Book> _books;

        public InMemoryBookDal()
        {
            _books = new List<Book>
            {
                new Book
                {
                    BookId = 1, CategoryId = 1, BookName = "Çiyanın Hatıra Defteri", Author = "Çiya Baran Öner",
                    NumberOfPage = 300,
                    Publisher = "BM Kitap", UnitPrice = 25, UnitsInStock = 10
                },
                new Book
                {
                    BookId = 2, CategoryId = 1, BookName = "Güncenin Hatıra Defteri", Author = "Itır Günce Mülayim",
                    NumberOfPage = 200,
                    Publisher = "BMD Kitap", UnitPrice = 55, UnitsInStock = 23
                },
                new Book
                {
                    BookId = 3, CategoryId = 2, BookName = "Bilinmeyen Hatıra Defteri", Author = "Samet Dogan",
                    NumberOfPage = 100,
                    Publisher = "BMF Kitap", UnitPrice = 45, UnitsInStock = 32
                },
            };
        }

        public List<Book> GetAll()
        {
            return _books;
        }

        public void Add(Book book)
        {
           _books.Add(book);
        }

        public void Update(Book book)
        {
            Book bookToUpdate = _books.SingleOrDefault(b => b.BookId == book.BookId);
            bookToUpdate.BookName = book.BookName;
            bookToUpdate.CategoryId = book.CategoryId;
            bookToUpdate.Author = book.Author;
            bookToUpdate.NumberOfPage = book.NumberOfPage;
            bookToUpdate.Publisher = book.Publisher;
            bookToUpdate.UnitPrice = book.UnitPrice;
            bookToUpdate.UnitsInStock = book.UnitsInStock;
        }

        public void Delete(Book book)
        {
            Book bookToDelete = _books.SingleOrDefault(b => b.BookId == book.BookId);

            _books.Remove(bookToDelete);
        }

        public List<Book> GetAllByCategory(int categoryId)
        {
            return _books.Where(b => b.CategoryId == categoryId).ToList();
        }
    }
}
