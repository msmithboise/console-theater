using console_theater.Interfaces;

namespace console_theater.Models
{

    public class Concession : IPurchasable
    {

        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; }

        public void PrintName()
        {
            System.Console.WriteLine($"Purchase of {Name} at {Price}");
        }

        public Concession(string name, decimal price)
        {
            Name = name;
            Price = price;
            Type = "Concession";
        }
    }

}