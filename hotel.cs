

namespace travel
{
  public   class Hotel
    {//DateTime someDate=new DateTime(2022,6,15);
        public string name;
        public string country;
        public int category;
        public int cost;
        public int costFlight;
        public Hotel(string name, string country, int category, int cost,int costFlight)
        {
            this.name = name;
            this.country = country;
            this.category = category;
            this.cost = cost;
            this.costFlight = costFlight;

        }
      

    }

}
