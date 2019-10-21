using Laboratorio_7_OOP_201902.Cards;
using Laboratorio_7_OOP_201902.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laboratorio_7_OOP_201902
{
    public class Deck : Interfaces.ICharacteristics
    {

        private List<Card> cards;

        public Deck()
        {
        
        }

        public List<Card> Cards { get => cards; set => cards = value; }

        public void AddCard(Card card)
        {
            Cards.Add(card);
        }
        public void DestroyCard(int cardId)
        {
            cards.RemoveAt(cardId);
        }

        

        public void Shuffle()
        {
            Random random = new Random();
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Card value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
        }
        
        public List<string> GetCharacteristics()
        {
           
            
                List<string> totalCards = new List<string>();

                int n = cards.Count();
                string nTotalOfCards = Convert.ToString(n);


                IEnumerable<Card> totalCartasMelee =                 
                    from card in cards
                    where card.Type == EnumType.melee
                    select card;

                IEnumerable<CombatCard> cardMelee =                    
                    from card in totalCartasMelee
                    select card as CombatCard;

                IEnumerable<int> totalAttackPonitsMelee =
                    from card in cardMelee
                    select card.AttackPoints;


                IEnumerable<Card> totalCartasRange =                
                    from card in cards
                    where card.Type == EnumType.range
                    select card;

                IEnumerable<CombatCard> cardRange =
                    from card in totalCartasRange
                    select card as CombatCard;

                IEnumerable<int> totalAttackPonitsRange =
                    from card in cardRange
                    select card.AttackPoints;

                IEnumerable<Card> totalCartasLongRange =                 
                    from card in cards
                    where card.Type == EnumType.longRange
                    select card;

                IEnumerable<CombatCard> cardLongRange =
                    from card in totalCartasLongRange
                    select card as CombatCard;

                IEnumerable<int> totalAttackPonitsLongRange =
                    from card in cardLongRange
                    select card.AttackPoints;

                IEnumerable<Card> totalCartasBuff =                 
                    from card in cards
                    where card.Type == EnumType.buff
                    select card;

                IEnumerable<Card> totalCartasWeather =                
                    from card in cards
                    where card.Type == EnumType.weather
                    select card;


            }
    }
}
