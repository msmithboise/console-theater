using System;
using console_theater.Models;

namespace console_theater
{
    class Program
    {
        static void Main(string[] args)
        {
            Theater myTheater = new Theater("Mike's Megaplex");
            myTheater.Initialize();
            Movie titanic = new Movie("Titanic");
            // myTheater.Movies.Add(titanic);
            myTheater.AddRoom(titanic, 100);
            myTheater.AddShowtime("12:00", 0);
            myTheater.AddShowtime("3:00", 0);
            myTheater.AddShowtime("5:20", 0);
            myTheater.AddShowtime("8:30", 0);
            System.Console.WriteLine($"Welcome to {myTheater.Name} Please select a movie.");


            myTheater.PrintMovies();

        }
    }
}
