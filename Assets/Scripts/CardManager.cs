using UnityEngine;

namespace CardGame
{
    public class CardManager : Singleton<CardManager>
    {
        public CardController SelectedCard;

        public void Decorate(CardController clickedCard)
        {
            if (SelectedCard == clickedCard)
            { 
                return; 
            }


            if(SelectedCard.Card is CardDecorator decorator)
            {
                Debug.Log("Decorating Card");
                decorator.Decorate(clickedCard.Card);
                clickedCard.Card = decorator;
                SelectedCard.MoveToAndDestroy(clickedCard.transform.position);
            }
            else
            {
                Debug.LogError("can't decorate card");
            }
        }
    }
    
}
