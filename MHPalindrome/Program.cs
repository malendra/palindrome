using System;

namespace MHPalindrome
{
    class Program
    {
        static void Check(string s, bool shouldBePalindrome)
        {
            Console.WriteLine(s.IsPalindrome() == shouldBePalindrome ? "pass" : "FAIL");
        }

        static void Main()
        {

            Check("abcba", true);   
            Check("abcde", false);
            Check("Mr owl ate my metal worm", true);
            Check("Never Odd Or Even", true);
            Check("Never Even Or Odd", false);

            Console.ReadLine();
        }
    }
}
