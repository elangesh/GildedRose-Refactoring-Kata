using GildedRoseKata.Types;

namespace GildedRoseKata.Strategies
{
    // Strategy for "Aged Brie" which increases in quality the older it gets.
    public class AgedBrieStrategy : UpdateStrategyBase
    {
        public override void UpdateQuality(Item item)
        {
            IncreaseQuality(item);
            DecreaseSellIn(item);

            // Once the sell by date has passed, "Aged Brie" increases in Quality twice as fast.
            if (item.SellIn < 0)
            {
                IncreaseQuality(item);
            }
        }
    }
}