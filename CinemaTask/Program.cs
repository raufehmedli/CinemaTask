namespace CinemaTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cinema cinema = new Cinema(1, "Cinema Park");
            Hall hall1 = new Hall(1, "Hall A", 20, 12);
            Hall hall2 = new Hall(2, "Hall B", 15, 16);
            cinema.AddHall(hall1);
            cinema.AddHall(hall2);
            hall1.OrderTicket(1, "Sadig", "Aliyev", "Kurtlar Vadisi Irak", new DateTime(2022, 05, 14, 16, 0, 0), new DateTime(2022, 05, 14, 18, 0, 0), 5, 10);
            hall1.OrderTicket(2, "Araz", "Merdanov", "Kurtlar Vadisi Irak", new DateTime(2022, 05, 14, 16, 0, 0), new DateTime(2022, 05, 14, 18, 0, 0), 8, 10);
            hall1.GetStatus();
            hall1.OrderTicket(3, "Rauf", "Ehmedli", "Kurtlar Vadisi Irak", new DateTime(2022, 05, 14, 15, 0, 0), new DateTime(2022, 05, 14, 16, 0, 0), 8, 10);

        }
    }
}