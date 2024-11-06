using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Practise
{
    internal class Palindrome
    {
        // Palindrome is a word, phrase, or sequence that reads the same backwards as forwards, e.g. madam or nurses run.

        private string word;

        public Palindrome(string word)
        {
            this.word = word;
        }

        public void CheckWordPalindrome()
        {
            if (this.word == null || this.word == string.Empty)
                Console.WriteLine("Word is empty");
            else if (this.word.Length == 1)
                Console.WriteLine("Yes, it is palindrome");
            else
            {
                int i = 0;
                int j = this.word.Length-1;
                bool isPalindrome = true;
                while (i < j)
                {
                    if (this.word[i].ToString().ToLower() != this.word[j].ToString().ToLower())
                    {
                        isPalindrome = false;
                        Console.WriteLine("No, it is not palindrome");
                        break;
                    }
                    i++;
                    j--;
                }
                if (isPalindrome) // of check if i > j. since we are breaking in case of mismatch
                    Console.WriteLine("Yes, it is palindrome");
            }
        }

    }
}
