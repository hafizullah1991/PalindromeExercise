using System;

namespace PalindromeExercise
{
    class Program
    {
        static void Main(string[] args)
            
        {
            WordSmith smith = new WordSmith();
            bool result = smith.IsAPalindrome("hello");
            Console.WriteLine(result);

        }
    }
}
