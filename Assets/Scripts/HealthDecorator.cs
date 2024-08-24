using UnityEngine;

namespace CardGame
{
    public class HealthDecorator : CardDecorator
    {
        public HealthDecorator(int value) : base(value) { }

        public override int Play()
        {
            Debug.Log("Playing Decorator healing card with value: " + value);
            HealPlayer();
            return card?.Play() ?? 0;
        }

        private void HealPlayer()
        {
            //Heal Player
        }
    }
}