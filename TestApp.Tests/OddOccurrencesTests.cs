using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class OddOccurrencesTests
{
    [Test]
    public void Test_FindOdd_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();
         
        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.Empty, "String is not empty.");
    }


    [Test]
    public void Test_FindOdd_WithNoOddOccurrences_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = new string[] {"Lion", "Wolf", "lion", "Wolf" };

        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.Empty, "String is not empty.");
    }

    [Test]
    public void Test_FindOdd_WithSingleOddOccurrence_ShouldReturnTheOddWord()
    {
        // Arrange
        string[] input = new string[] { "banan", "apple", "apple" };
        string expected = "banan";
        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindOdd_WithMultipleOddOccurrences_ShouldReturnAllOddWords()
    {
        // Arrange
        string[] input = new string[] { "banana", "orange", "apple", "apple", "orange", "orange"};
        string expected = "banana orange";
        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindOdd_WithMixedCaseWords_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = new string[] { "BANANA", "orange", "applE", "Apple", "orAnge", "Orange" };
        string expected = "banana orange";

        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
