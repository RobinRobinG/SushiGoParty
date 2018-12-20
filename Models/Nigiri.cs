namespace SushiGo.Models
{
    public class NigiriCard: Card
    {
      public CardType Nigiri {get; set;}
      public CardColor Yellow {get; set;}
    }
    public class Nigiri1Card: NigiriCard
    {
      public int Point {get; set;} = 1;
    }
    public class Nigiri2Card: NigiriCard
    {
      public int Point {get; set;} = 2;
    }
    public class Nigiri3Card: NigiriCard
    {
      public int Point {get; set;} = 3;
    }
}