
using UnityEngine;

namespace CardGame
{
    [CreateAssetMenu(fileName = "New Card", menuName = "Card/CardDefinition")]   
    public class CardDefinition : ScriptableObject
    {
        public int value;
        public CardType type;
    }
}
