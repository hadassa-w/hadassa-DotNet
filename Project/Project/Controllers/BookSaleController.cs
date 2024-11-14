using Microsoft.AspNetCore.Mvc;
using Project.Classes;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookSaleController : ControllerBase
    {
        public static List<BookSale> BookSale = new List<BookSale>()
        {
            new BookSale() {Id=1,Book=new Book(){ Id=1,BookName="Dudi",WriterName="Bracha Choen",
            CountPages =255,Price=25.5,DateWrite=new DateTime(11/02/2022),Status=true},Price=40,Date=new DateTime(23,03,2023),Status=false },
            new BookSale() {Id=2,Book=new Book(){ Id=2,BookName="Ptsasa",WriterName="Shoshi Levi",
            CountPages =589,Price=40,DateWrite=new DateTime(19/10/2020),Status=true},Price=45,Date=new DateTime(04,10,2020),Status=true },
        };

        // GET: api/<BookSaleController>
        [HttpGet]
        public List<BookSale> Get()
        {
            return BookSale;
        }

        // GET api/<BookSaleController>/5
        [HttpGet("{id}")]
        public BookSale Get(int id)
        {
            if (BookSale == null)
                return null;
            return BookSale.Where(x => x.Id.Equals(id)).FirstOrDefault<BookSale>();
        }

        // POST api/<BookSaleController>
        [HttpPost]
        public void Post(BookSale bookSale)
        {
            BookSale.Add(bookSale);
        }

        // PUT api/<BookSaleController>/5
        [HttpPut("{id}")]
        public bool Put(int id, BookSale bookSale)
        {
            if (BookSale == null)
                return false;
            Delete(id);
            Post(bookSale);
            return true;
        }

        // DELETE api/<BookSaleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            BookSale.Remove(BookSale.Find(item => item.Id == id));
        }
    }
}
