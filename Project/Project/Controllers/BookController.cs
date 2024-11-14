using Microsoft.AspNetCore.Mvc;
using Project.Classes;
using System.Runtime.InteropServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        public static List<Book> Books = new List<Book>()
        {
            new Book() { Id=1,BookName="Dudi",WriterName="Bracha Choen",
            CountPages =255,Price=25.5,DateWrite=new DateTime(11/02/2022),Status=true},
            new Book() { Id=2,BookName="Ptsasa",WriterName="Shoshi Levi",
            CountPages =589,Price=40,DateWrite=new DateTime(19/10/2020),Status=true},
        };

        // GET: api/<BookController>
        [HttpGet]
        public List<Book> Get()
        {
            return Books;
        }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public Book Get(int id)
        {
            if (Books == null)
                return null;
            return Books.Where(x => x.Id.Equals(id)).FirstOrDefault<Book>();
        }

        // POST api/<BookController>
        [HttpPost]
        public void Post(Book book)
        {
            Books.Add(book);
        }

        // PUT api/<BookController>/5
        [HttpPut("{id}")]
        public bool Put(int id, Book book)
        {
            if (Books == null)
                return false;
            Delete(id);
            Post(book);
            return true;
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Books.Remove(Books.Find(item => item.Id == id));
        }
    }
}
