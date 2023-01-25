using System;
using System.Collections.Generic;

namespace travel
{ 
     public class generate
    {
        List<Hotel> hotels = new List<Hotel>();
         public List<ofer> oferts = new List<ofer>();
        public void GenerateHotel()
        {
            List<Hotel> hotels = new List<Hotel>();
            hotels.Add(new Hotel("Cancun Bay Resort", "Meksyk", 4, 450, 2500));
            hotels.Add(new Hotel("Iberostar Quetzal", "Meksyk", 5, 690, 2500));
            hotels.Add(new Hotel("Imperial Laguna by Faranda", "Meksyk", 3, 320, 2500));
            hotels.Add(new Hotel("Playacalida", "Hiszpania", 5, 600, 1000));
            hotels.Add(new Hotel("Palia Puerto del Sol", "Hiszpania",3, 240, 1000));
            hotels.Add(new Hotel("Playa Real Resort", "Hiszpania", 4, 380, 1000));
            hotels.Add(new Hotel("Sea Gull", "Egipt", 3, 270, 1500));
            hotels.Add(new Hotel("Continental Hurghada", "Egipt",4, 360, 1500));
            hotels.Add(new Hotel("Sharm Grand Plaza", "Egipt", 5, 620, 1500));
            hotels.Add(new Hotel("Ikaros Hotel", "Grecja", 3, 220, 1000));
            hotels.Add(new Hotel("Labranda Sandy Beach Resort", "Grecja", 5, 290, 1000));
            hotels.Add(new Hotel("Lida Corfu", "Grecja", 4, 310, 1000));
            hotels.Add(new Hotel("Mytt Beach Hotel", "Tajlandia", 5, 720, 2000));
            hotels.Add(new Hotel("Mytt Beach Hotel", "Tajlandia", 5, 720, 2000));
            hotels.Add(new Hotel("Novotel Rayong", "Tajlandia", 4, 410, 2000));
            hotels.Add(new Hotel("Cholchan Pattaya Resort", "Tajlandia", 3, 290, 2000));
            this.hotels = hotels;
        }
        public static List<int> GetNumbers()
        {
            var numbers = new List<int>();
            var random = new Random();
            while (numbers.Count < 3)
            {
                int number = random.Next(1, 6);
                if (!numbers.Contains(number))
                    numbers.Add(number);
            }
            return numbers;
        }
        public void generateOferts()
        {
            List<int> numbers = GetNumbers();
            List<ofer> oferts = new List<ofer>();
            oferts.Add( new ofer(false , 7, hotels[numbers[oferts.Count]]));
            oferts.Add(new ofer(true ,10, hotels[numbers[oferts.Count]]));
            oferts.Add(new ofer(true, 14, hotels[numbers[oferts.Count]]));
            this.oferts = oferts;
        }
    
        public void endprice( int price)
        {
            string adulst = "";
            string children ="";
            int adulstint;
            int childrenint;
            Console.WriteLine("Podaj liczbę dorosłych");
            adulst = Console.ReadLine();
            Console.WriteLine("Podaj liczbę dzieci");
            children= Console.ReadLine();
            
            if (int.TryParse(adulst,out adulstint)&& int.TryParse(children, out childrenint))
            {
            Console.WriteLine( "cena całkowita wycieczki wynosi: "+ ((price * adulstint + (childrenint * price / 2)))+" pln");
            }
            else
            {
                Console.WriteLine("coś poszło nie tak");
            }
        }
    }
}
