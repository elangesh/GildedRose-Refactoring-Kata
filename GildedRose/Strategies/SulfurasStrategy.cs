using GildedRoseKata.Types;

namespace GildedRoseKata.Strategies
{
    // Strategy for "Sulfuras" items, which do not decrease in quality or sell-in.
    public class SulfurasStrategy : UpdateStrategyBase
    {
        public override void UpdateQuality(Item item)
        {
            // "Sulfuras" being a legendary item, never has to be sold or decreases in Quality.
        }

        // "Sulfuras" items do not decrease in SellIn, override to do nothing.
        protected override void DecreaseSellIn(Item item)
        {
            // Intentionally left blank.
        }
    }
}