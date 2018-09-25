using System.Collections.Generic;

namespace console_theater.Models
{


    public class Room
    {
        public Movie Movie { get; set; }

        private Dictionary<string, int> Showtimes { get; set; }

        public int MaxSeats { get; set; }


        // because we made the defition private we are using this method to add the showtimes.. this is a setter
        public void AddShowtime(string time)
        {
            Showtimes.Add(time, MaxSeats);
        }

        public void PrintShowtimes()
        {

            System.Console.WriteLine("CHOOSE A TIME");
            // this is iterating over dictionary.  time.key  and time. int
            // key is the string and the int is the value.  string is time, and int is number of seats available.  #endregion
            // for each key value pair in the dictionary, couple string and in as an object.  
            // int i = 1;
            foreach (KeyValuePair<string, int> showtime in Showtimes)
            {
                System.Console.WriteLine($"{showtime.Key} - Available Seats {showtime.Value}");
                // i++;
            }


        }

        public List<Ticket> BuyTickets(string showtime, int tickets)
        //[showtime] is pointing to dictionary
        {                                       // this is referring to Showtimes in the dictionary.
            if (Showtimes.ContainsKey(showtime) && Showtimes[showtime] >= tickets)
            {
                List<Ticket> purchased = new List<Ticket>();
                for (int i = 0; i < tickets; i++)
                {
                    purchased.Add(new Ticket(showtime, Movie, 15));
                }
                Showtimes[showtime] -= tickets;
                // returns list created "purchased"
                return purchased;
            }
            return null;
        }

        public Room(Movie movie, int maxSeats)
        {
            Movie = movie;
            MaxSeats = maxSeats;
            Showtimes = new Dictionary<string, int>();
        }
    }
}
