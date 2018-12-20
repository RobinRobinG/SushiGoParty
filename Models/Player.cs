using System.Collections.Generic;

namespace SushiGo.Models
{
    public class Player
    {
        public User UserId {get;set;}
        public List<Card> Hand {get;set;}
        public List<Card> ChosenCards {get;set;}
        public int TotalPoint {get;set;}
    }
}