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


            Movie lotr = new Movie("Lord of the Rings");
            myTheater.AddRoom(lotr, 80);
            myTheater.AddShowtime("11:00", 1);
            myTheater.AddShowtime("2:00", 1);
            myTheater.AddShowtime("7:00", 1);
            myTheater.AddShowtime("10:00", 1);

            var intheTheaterMenu = true;
            while (intheTheaterMenu)
            {
                Console.Clear();
                System.Console.WriteLine($"Welcome to {myTheater.Name} Please select a movie.");
                myTheater.PrintMovies();


                var userInput = Console.ReadLine();
                if (Int32.TryParse(userInput, out int choice))
                {
                    if (myTheater.SetActiveRoom(0))
                    {
                        myTheater.activeRoom.PrintShowtimes();
                        //take prompt for showtime
                        Console.ReadLine();
                    }

                }

            }
        }




    }
}

