namespace Project.Classes
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string WriterName { get; set; }
        public int CountPages { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public DateTime DateWrite { get; set; }
        public bool Status { get; set; }
    }
}
