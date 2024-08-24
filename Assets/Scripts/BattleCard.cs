namespace CardGame
{
    public class BattleCard : ICard
    {
        readonly int value;

        public BattleCard(int value)
        {
            this.value = value;
        }

        int ICard.Play()
        {
            return value;
        }
    }
}
