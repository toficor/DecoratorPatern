using UnityEngine;
using System;

namespace CardGame
{
    public abstract class CardDecorator : ICard
    {
        protected ICard card;
        protected readonly int value;

        protected CardDecorator(int value)
        {
            this.value = value;
        }

        public void Decorate(ICard card)
        {
            if(ReferenceEquals(this, card))
            {
                return;
            }

            if(this.card is CardDecorator decorator)
            {
                decorator.Decorate(card);
            }
            else
            {
                this.card = card;
            }
        }

        public virtual int Play()
        {
            Debug.Log("Playing Decorator card with value: " + value);
            return card?.Play() + value ?? value;

        }
    }
}