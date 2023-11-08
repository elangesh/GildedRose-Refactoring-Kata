using GildedRoseKata.Types;

namespace GildedRoseKata.Strategies
{
    // Strategy for "Conjured" items that degrade in quality twice as fast as normal items.
    public class ConjuredItemStrategy : UpdateStrategyBase
    {
        public override void UpdateQuality(Item item)
        {
            DecreaseQuality(item, 2);
            DecreaseSellIn(item);

            // Once the sell by date has passed, "Conjured" items degrade in Quality twice as fast.
            if (item.SellIn < 0)
            {
                DecreaseQuality(item, 2);
            }
        }
    }
}