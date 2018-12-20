namespace SushiGo.Models
{
    public class MakiCard: Card
    {
      public CardType Maki {get; set;}
      public CardColor Red {get; set;}

    }
    public class Maki1Card: MakiCard
    {
      public int Count {get; set;} = 1;
    }
    public class Maki2Card: MakiCard
    {
      public int Count {get; set;} = 2;
    }
    public class Maki3Card: MakiCard
    {
      public int Count {get; set;} = 3;
    }
}