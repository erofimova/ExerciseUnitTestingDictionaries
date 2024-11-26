using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class OrdersTests
{
    [Test]
    public void Test_Order_WithEmptyInput_ShouldReturnEmptyString()
    {
        //Arrange
        string[] input = Array.Empty<string>();

        //Act
        string result = Orders.Order(input);

        //Assert
        Assert.That(result, Is.Empty);
    }


    [Test]
    public void Test_Order_WithMultipleOrders_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[] { "apple 1.99 2", "apple 1.99 1", "banana 3.50 2", "banana 1.25 1", "orange 0.99 2" };
        string expected = $"apple -> 5.97" +
            $"{Environment.NewLine}banana -> 3.75" +
            $"{Environment.NewLine}orange -> 1.98";

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Order_WithRoundedPrices_ShouldReturnTotalPrice()
    {
        //Arrange
        string[] input = new string[] { "apple 1.99 2", "apple 5 2" };
        string expected = "apple -> 20.00";

        //Act
        string result = Orders.Order(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Order_WithDecimalQuantities_ShouldReturnTotalPrice()
    {
        //Arrange
        string[] input = new string[] { "apple 1.99 2.2", "apple 5 1.3" };
        string expected = "apple -> 17.50";

        //Act
        string result = Orders.Order(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
