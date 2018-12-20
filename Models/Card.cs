namespace SushiGo.Models
{

    public class Card
    {
        public CardType Type { get; set; }
        public CardColor Color { get; set; }
    }

    // define card colors
    public enum CardColor
    {
        Yellow,
        Red,
        Maroon,
        Orange,
        Green,
        Lightgreen,
        Teal,
        Lightpink,
    }

    //define card types
    public enum CardType
    {
        Nigiri,
        Maki,
        Tea,
        SoySauce,
        Tofu,
        Sashimi,
        MisoSoup,
        Pudding
    }

}