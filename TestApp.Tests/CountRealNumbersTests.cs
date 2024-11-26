using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class CountRealNumbersTests
{
    // TODO: finish test
    [Test]
    public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        int[] input = Array.Empty<int>();

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.Empty, "String is not empty.");
    }

    [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { 42 };
        string expected = "42 -> 1";

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected), "The count of number 42 is not 1.");
    }

    [Test]
    public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { 42, 8, 2, 8, 42 };
        string expected = $"2 -> 1" +
                          $"{Environment.NewLine}8 -> 2" +
                          $"{Environment.NewLine}42 -> 2";

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { -1, -5, -1, -5, -12 };
        string expected = $"-12 -> 1" +
                          $"{Environment.NewLine}-5 -> 2" +
                          $"{Environment.NewLine}-1 -> 2";

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { -4, 6, 0, -4, 10 };
        string expected = $"-4 -> 2" +
                          $"{Environment.NewLine}0 -> 1" +
                          $"{Environment.NewLine}6 -> 1" +
                          $"{Environment.NewLine}10 -> 1";

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
