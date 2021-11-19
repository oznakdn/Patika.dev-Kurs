using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Linq;


namespace WebApi.Controllers
{

    [ApiController]
    [Route("[controller]s")]
    public class BookController:ControllerBase
    {
        private static List<Book> BookList=new List<Book>()
        {
            new Book
            {
                Id=1,
                Title="Lean Startup",
                GenreId=1,
                PageCount=200,
                PublishDate=new DateTime(2001,6,12)
            },
            new Book
            {
                Id=2,
                Title="Herland",
                GenreId=2,
                PageCount=250,
                PublishDate=new DateTime(2010,5,23)
            },
            new Book
            {
                Id=3,
                Title="Dune",
                GenreId=2,
                PageCount=540,
                PublishDate=new DateTime(2001,12,21)
            }
        };

        /****HttpGet metodu****/
        [HttpGet]
        public List<Book>GetBooks()
        {
            var bookList=BookList.OrderBy(x=>x.Id).ToList();
            return bookList;
        }
        

        [HttpGet("{id}")]
        public Book GetById(int id)
        {
            var book=BookList.FirstOrDefault(x=>x.Id==id);
            return book;
        }

        /* HttpGet metodunun aynısından iki tane olamaz.    
        [HttpGet]
        public Book GetBook([FormQuery]string id)
        {
            var book=BookList.Where(x=>x.Id==Convert.ToInt32(id)).SingleOrDefault();
            return book;
        }
        */

        /****HttpPost metodu****/
        [HttpPost]
        public IActionResult AddBook([FromBody] Book newBook)
        {
            var book=BookList.SingleOrDefault(x=>x.Title==newBook.Title);
            if(book is not null)
                return BadRequest();
            BookList.Add(newBook);
            return Ok();

        }

        /****HttpPut metodu****/
        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id,[FromBody] Book updatedBook)
        {
             var book=BookList.SingleOrDefault(x=>x.Id==id);
             if(book is null)
                return BadRequest();

             book.Title=updatedBook.Title!=default ? updatedBook.Title : book.Title;
             book.GenreId=updatedBook.GenreId!=default ? updatedBook.GenreId : book.GenreId;
             book.PageCount=updatedBook.PageCount!=default ? updatedBook.PageCount : book.PageCount;
             book.PublishDate=updatedBook.PublishDate!=default ? updatedBook.PublishDate : book.PublishDate;

             return Ok();

        }

        /****HttpDelete metodu****/
        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var book=BookList.SingleOrDefault(x=>x.Id==id);
            if(book is null)
                return BadRequest();
            BookList.Remove(book);
            return Ok();

        }




        

    }



}