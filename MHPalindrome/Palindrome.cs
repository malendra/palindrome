using System;
using System.Linq;

namespace MHPalindrome
{
    public static class Palindrome
    {   
    public static bool IsPalindrome(this string s)
    {
        if (string.IsNullOrWhiteSpace(s))
        {
            return true;
        }
        string reverseString = new string( s.Replace(" ",string.Empty).Reverse().ToArray());
        return s.Replace(" ",string.Empty).ToLower() == reverseString.ToLower();
        }
    }
}
