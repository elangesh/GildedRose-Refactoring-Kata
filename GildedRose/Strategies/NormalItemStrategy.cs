using GildedRoseKata.Types;

namespace GildedRoseKata.Strategies
{
    // Strategy for updating normal items that decrease in quality over time.
    public class NormalItemStrategy : UpdateStrategyBase
    {
        public override void UpdateQuality(Item item)
        {
            DecreaseQuality(item);
            DecreaseSellIn(item);

            // Once the sell by date has passed, Quality degrades twice as fast.
            if (item.SellIn < 0)
            {
                DecreaseQuality(item);
            }
        }
    }
}