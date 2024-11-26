using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.Tests;

public class CountCharactersTests
{
    [Test]
    public void Test_Count_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }


    [Test]
    public void Test_Count_WithNoCharacters_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new List<string>() { "", "", "" };

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new List<string>() { "F" };
        string expected = "F -> 1";

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected), "Count of characters is more than 1");
    }

    [Test]
    public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
    {
        //Arrange
        List<string> input = new List<string>() { "ab", "ac", "abc" };
        string expected = $"a -> 3" +
                          $"{Environment.NewLine}b -> 2" +
                          $"{Environment.NewLine}c -> 2";

        //Act
        string result = CountCharacters.Count(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
    [Test]
    public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
    {
        //Arrange
        List<string> input = new List<string>() { "!a", "#&a", "&" };
        string expected = $"! -> 1" +
                          $"{Environment.NewLine}a -> 2" +
                          $"{Environment.NewLine}# -> 1" +
                          $"{Environment.NewLine}& -> 2";


        //Act
        string result = CountCharacters.Count(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
