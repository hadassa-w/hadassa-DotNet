﻿namespace Project.Classes
{
    public class BookBuy
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public double Price { get; set; }

        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}
