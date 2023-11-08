using GildedRoseKata.Types;

namespace GildedRoseKata.Strategies
{
    // Strategy for "Backstage Passes" which vary in quality as the concert date approaches.
    public class BackstagePassStrategy : UpdateStrategyBase
    {
        public override void UpdateQuality(Item item)
        {
            if (item.SellIn <= 0)
            {
                item.Quality = 0;
            }
            else
            {
                if (item.Quality < 50)
                {
                    IncreaseQuality(item); // This increases by 1

                    if (item.SellIn < 11)
                    {
                        IncreaseQuality(item); // This potentially increases by 1 more, total 2
                    }

                    if (item.SellIn < 6)
                    {
                        IncreaseQuality(item); // This potentially increases by 1 more, total 3
                    }
                }
            }

            DecreaseSellIn(item); // Decrement SellIn after all checks
        }
    }
}