using System.Collections.Generic;
using GildedRoseKata.Strategies;
using GildedRoseKata.Types;

namespace GildedRoseKata
{
    // Main class representing the Gilded Rose store.
    public class GildedRose
    {
        private readonly IList<Item> _items; 
        public GildedRose(IList<Item> items)
        {
            _items = items;
        }

        // Updates the quality of all items in the store for the end of the day.
        public void UpdateQuality()
        {
            // Iterate over each item in the store and update its quality based on its type.
            foreach (var item in _items)
            {
                // Retrieve the appropriate strategy for the item's type
                IUpdateStrategy strategy = UpdateStrategyFactory.CreateStrategy(item);
                // Apply the strategy to update the item's quality
                strategy.UpdateQuality(item);
            }
        }
    }
}