using PalindromeExercise;
using System;
using System.Security.Cryptography.X509Certificates;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("level", true)]
        [InlineData("radar", true)]
        [InlineData("hello", false)]
        [InlineData("", true)]
        public void PalindromTest(string word, bool expected)
        {
            //Arrange
            WordSmith instance = new WordSmith();
            // Act
          bool actual =  instance.IsAPalindrome(word);
            // Assert
            Assert.Equal(actual, expected);
        }
    }
}
