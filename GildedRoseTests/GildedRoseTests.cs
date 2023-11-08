using System.Collections.Generic;
using GildedRoseKata;
using GildedRoseKata.Types;
using NUnit.Framework;

namespace GildedRoseTests;

public class GildedRoseTests
{
    [Test]
    public void UpdateQuality_WithAgedBrie_IncreasesQuality()
    {
        // Arrange
        var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 1, Quality = 1 } };
        var app = new GildedRose(items);

        // Act
        app.UpdateQuality();

        // Assert
        Assert.AreEqual(2, items[0].Quality);
        Assert.AreEqual(0, items[0].SellIn);
    }

    [Test]
    public void UpdateQuality_WithNormalItem_DecreasesQuality()
    {
        // Arrange
        var items = new List<Item> { new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 } };
        var app = new GildedRose(items);

        // Act
        app.UpdateQuality();

        // Assert
        Assert.AreEqual(19, items[0].Quality);
        Assert.AreEqual(9, items[0].SellIn);
    }

    [Test]
    public void UpdateQuality_WithSulfuras_DoesNotChangeQualityOrSellIn()
    {
        // Arrange
        var items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 } };
        var app = new GildedRose(items);

        // Act
        app.UpdateQuality();

        // Assert
        Assert.AreEqual(80, items[0].Quality);
        Assert.AreEqual(0, items[0].SellIn);
    }

    [Test]
    public void UpdateQuality_WithBackstagePasses_IncreasesQualityApproachingConcert()
    {
        // Arrange
        var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20 } };
        var app = new GildedRose(items);

        // Act
        app.UpdateQuality();

        // Assert
        Assert.AreEqual(21, items[0].Quality);
        Assert.AreEqual(14, items[0].SellIn);
    }

    [Test]
    public void UpdateQuality_WithBackstagePasses_DropsQualityToZeroAfterConcert()
    {
        // Arrange
        var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 20 } };
        var app = new GildedRose(items);

        // Act
        app.UpdateQuality();

        // Assert
        Assert.AreEqual(0, items[0].Quality);
        Assert.AreEqual(-1, items[0].SellIn);
    }

    [Test]
    public void UpdateQuality_WithConjuredItem_DecreasesQualityTwiceAsFast()
    {
        // Arrange
        var items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 } };
        var app = new GildedRose(items);

        // Act
        app.UpdateQuality();

        // Assert
        Assert.AreEqual(4, items[0].Quality);
        Assert.AreEqual(2, items[0].SellIn);
    }

    [Test]
    public void UpdateQuality_BackstagePasses_IncreaseByTwoWhenSellInTenOrLess()
    {
        // Arrange
        var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 25 } };
        var app = new GildedRose(items);

        // Act
        app.UpdateQuality();

        // Assert
        Assert.AreEqual(27, items[0].Quality);
        Assert.AreEqual(9, items[0].SellIn);
    }

    [Test]
    public void UpdateQuality_BackstagePasses_IncreaseByThreeWhenSellInFiveOrLess()
    {
        // Arrange
        var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 25 } };
        var app = new GildedRose(items);

        // Act
        app.UpdateQuality();

        // Assert
        Assert.AreEqual(28, items[0].Quality);
        Assert.AreEqual(4, items[0].SellIn);
    }

    [Test]
    public void UpdateQuality_ItemQualityNeverNegative()
    {
        // Arrange
        var items = new List<Item> { new Item { Name = "+5 Dexterity Vest", SellIn = 1, Quality = 0 } };
        var app = new GildedRose(items);

        // Act
        app.UpdateQuality();

        // Assert
        Assert.GreaterOrEqual(items[0].Quality, 0);
    }

    [Test]
    public void UpdateQuality_ItemQualityNeverMoreThanFifty()
    {
        // Arrange
        var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 1, Quality = 50 } };
        var app = new GildedRose(items);

        // Act
        app.UpdateQuality();

        // Assert
        Assert.LessOrEqual(items[0].Quality, 50);
    }

    [Test]
    public void UpdateQuality_ConjuredItemsDegradeTwiceAsFastAfterSellIn()
    {
        // Arrange
        var items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 0, Quality = 6 } };
        var app = new GildedRose(items);

        // Act
        app.UpdateQuality();

        // Assert
        Assert.AreEqual(2, items[0].Quality);
    }

    [Test]
    public void UpdateQuality_SulfurasQualityAlwaysEighty()
    {
        // Arrange
        var items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 } };
        var app = new GildedRose(items);

        // Act
        app.UpdateQuality();

        // Assert
        Assert.AreEqual(80, items[0].Quality);
    }
}