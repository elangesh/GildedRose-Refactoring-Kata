using System;
using GildedRoseKata.Types;

namespace GildedRoseKata.Strategies
{
    // Interface for the update strategy, which all item strategies will implement.
    public interface IUpdateStrategy
    {
        void UpdateQuality(Item item);
    }

// Base class for the update strategy that provides common functionality to all derived strategy classes.
    public abstract class UpdateStrategyBase : IUpdateStrategy
    {
        public abstract void UpdateQuality(Item item);

        // Decreases the SellIn value of an item.
        protected virtual void DecreaseSellIn(Item item)
        {
            item.SellIn--;
        }

        // Increases the Quality of an item, ensuring it does not exceed the maximum value.
        protected void IncreaseQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality++;
            }
        }

        // Decreases the Quality of an item by a specified decrement, ensuring it does not drop below zero.
        protected void DecreaseQuality(Item item, int decrement = 1)
        {
            item.Quality = Math.Max(item.Quality - decrement, 0);
        }
    }
}