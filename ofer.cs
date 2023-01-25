using System;


namespace travel
{
    public class ofer
    {
        DateTime FlightDay = new DateTime(2022, 6, 15);
         public int priceofert = 0;
        public int days;
        Hotel hotel;
        bool maels;//false - sniadanie true-all inclusive
        public ofer(bool meals, int days, Hotel hotel)
        {
            this.maels = meals;
            this.days = days;
            this.hotel = hotel;
            this.priceofert = cost();
        }
        string deadline()
        {
            DateTime ReturnDay = new DateTime();
            ReturnDay = FlightDay;
            ReturnDay.AddDays(days);

            return FlightDay.ToShortDateString() + " - " + ReturnDay.ToShortDateString() + "(" + days + ") dni";
        }
        string stars()
        {
            string a = "";
            for (int i = 0; i < hotel.category; i++)
            {
                a = a + "*";
            }
            return a;
        }
        public int cost()
        {
            int a = hotel.cost * days;
            if (maels)
                a = a + 1200;

            a = a + hotel.costFlight;
            return a;
        }
        public void showOfert()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Kraj: " + hotel.country);
            Console.WriteLine("Termin: " + deadline());
            Console.WriteLine("Hotel " + hotel.name + "(" + stars() + ")");
            Console.Write("Wyżywienie ");
            if (maels)
                Console.Write("All-inclusive");
            else
                Console.Write("Śniadanie");
            Console.WriteLine();
            Console.WriteLine("Cena " + priceofert + " pln/os");
            Console.WriteLine("--------------------------------------------");
        }

    }
}
