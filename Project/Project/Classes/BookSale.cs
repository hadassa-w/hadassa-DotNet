namespace Project.Classes
{
    public class BookSale
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public double Price { get; set; }

        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}