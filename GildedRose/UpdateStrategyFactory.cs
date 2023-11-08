using GildedRoseKata.Constants;
using GildedRoseKata.Strategies;
using GildedRoseKata.Types;

namespace GildedRoseKata
{
    // Factory class to create instances of update strategies based on item names.
    // This allows the application of the correct update rules depending on the item type.

    public static class UpdateStrategyFactory
    {
        // Creates the appropriate strategy for updating an item's quality based on its name.
        public static IUpdateStrategy CreateStrategy(Item item)
        {
            switch (item.Name)
            {
                case ItemNames.AgedBrie:
                    return new AgedBrieStrategy(); // Handles "Aged Brie" items
                case ItemNames.Sulfuras:
                    return new SulfurasStrategy(); // Handles "Sulfuras" items, which do not degrade
                case ItemNames.BackstagePasses:
                    return new BackstagePassStrategy(); // Handles "Backstage passes" items
                case var name when name.StartsWith(ItemNames.Conjured):
                    return new ConjuredItemStrategy(); // Handles "Conjured" items, which degrade faster
                default:
                    return new NormalItemStrategy(); // Handles all other items
            }
        }
    }
}