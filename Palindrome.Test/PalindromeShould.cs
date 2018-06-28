using MHPalindrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Palindrome.Test
{
    [TestClass]
    public class PalindromeShould
    {   
        [TestMethod]
        public void BeTrueForAnEmptyString()
        {
            bool result = string.Empty.IsPalindrome();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void BeFalseFor_Hello()
        {
            bool result = "Hello".IsPalindrome();
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void BeTrueFor_abcba()
        {
            bool result = "abcba".IsPalindrome();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void BeTrueFor_Never_Odd_Or_Even()
        {
            bool result = "Never Odd Or Even".IsPalindrome();
            Assert.IsTrue(result);
        }
    }
}
