﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            int start = 0;
            int end = word.Length - 1;
            while (start < end)
            {
                if (word[start] != word[end])
                {
                    return false;
                }
                start++;
                end--;
            }
            return true;
        }
    }
    
}
