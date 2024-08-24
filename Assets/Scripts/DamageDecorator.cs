
using UnityEngine;

namespace CardGame
{
    public class DamageDecorator : CardDecorator
    {
        public DamageDecorator(int value) : base(value)
        {
             
        }

        public override int Play()
        {
            Debug.Log("doubling dmg");
            return card?.Play() * 2 ?? 0;
        }
    }
}