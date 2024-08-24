namespace CardGame
{
    public static class CardFactory
    {
        public static ICard Create(CardDefinition cardDefinition) 
        {
            return cardDefinition.type switch
            {               
                CardType.Damage => new DamageDecorator(cardDefinition.value),
                CardType.Health => new HealthDecorator(cardDefinition.value),
                _ => new BattleCard(cardDefinition.value),
            };
        }

    }

}
