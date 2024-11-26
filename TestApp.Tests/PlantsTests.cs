using NUnit.Framework;

using System;
using System.Numerics;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();

        // Act
        string result = Plants.GetFastestGrowing(input);

        // Assert
        Assert.That(result, Is.Empty);
    }


    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        // Arrange
        string[] input = new string[] {"rose"};
        string expected = "Plants with 4 letters:" +
            $"{Environment.NewLine}rose";

        // Act
        string result = Plants.GetFastestGrowing(input);

        // Assert
        Assert.That(result,Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        // Arrange
        string[] input = new string[] { "rose", "tulip", "mint"};
        string expected = "Plants with 4 letters:" +
            $"{Environment.NewLine}rose" +
            $"{Environment.NewLine}mint" +
            $"{Environment.NewLine}Plants with 5 letters:" +
            $"{Environment.NewLine}tulip";

        // Act
        string result = Plants.GetFastestGrowing(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = new string[] { "RoSe", "TULIP", "mint" };
        string expected = "Plants with 4 letters:" +
            $"{Environment.NewLine}RoSe" +
            $"{Environment.NewLine}mint" +
            $"{Environment.NewLine}Plants with 5 letters:" +
            $"{Environment.NewLine}TULIP";

        // Act
        string result = Plants.GetFastestGrowing(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
