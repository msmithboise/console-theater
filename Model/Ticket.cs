using console_theater.Interfaces;

namespace console_theater.Models
{

    // Definining
    public class Ticket : IPurchasable
    {
        public string Time { get; set; }

        // First movie is the class, second is the property
        public Movie Movie { get; set; }

        public decimal Price { get; set; }
        private string Type { get; set; }
        string IPurchasable.Type { get; set; }


        // Constructor 
        public Ticket(string time, Movie movie, decimal price)
        {
            Time = time;
            Movie = movie;
            Price = price;
            Type = "Ticket";


        }

        public void PrintName()
        {
            System.Console.WriteLine($"Ticket for {Movie} at {Time}");
        }
    }
}