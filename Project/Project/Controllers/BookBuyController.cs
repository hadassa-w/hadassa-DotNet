using Microsoft.AspNetCore.Mvc;
using Project.Classes;
using System.Linq;
using static System.Reflection.Metadata.BlobBuilder;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookBuyController : ControllerBase
    {
        public static List<BookBuy> BookBuy = new List<BookBuy>()
        {
            new BookBuy() {Id=1,Book=new Book(){Id=1,BookName="Dudi",WriterName="Bracha Choen",
            CountPages =255,Price=25.5,DateWrite=new DateTime(11/02/2022),Status=true},Date=new DateTime(11,08,2021),Status=true },
            new BookBuy() {Id=2,Book=new Book(){Id=2,BookName="Ptsasa",WriterName="Shoshi Levi",
            CountPages =589,Price=40,DateWrite=new DateTime(19/10/2020),Status=true},Date=new DateTime(09,07,2023),Status=false },
        };

        // GET: api/<BookBuyController>
        [HttpGet]
        public List<BookBuy> Get()
        {
            return BookBuy;
        }

        // GET api/<BookBuyController>/5
        [HttpGet("{id}")]
        public BookBuy Get(int id)
        {
            if (BookBuy == null)
                return null;
            return BookBuy.Where(x => x.Id.Equals(id)).FirstOrDefault<BookBuy>();
        }

        // POST api/<BookBuyController>
        [HttpPost]
        public void Post(BookBuy bookBuy)
        {
            BookBuy.Add(bookBuy);
        }

        // PUT api/<BookBuyController>/5
        [HttpPut("{id}")]
        public bool Put(int id, BookBuy bookBuy)
        {
            if (BookBuy == null)
                return false;
            Delete(id);
            Post(bookBuy);
            return true;
        }

        // DELETE api/<BookBuyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            BookBuy.Remove(BookBuy.Find(item => item.Id == id));
        }
    }
}
