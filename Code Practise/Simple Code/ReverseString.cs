using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Practise.Simple_Code
{
    internal class ReverseString
    {
        string word;
        public ReverseString(string word)
        {
            this.word = word;
        }
        public void ExecuteReverseString()
        {
            if (this.word != null)
            {
                string revWord = string.Empty;
                foreach (char c in this.word)
                {
                    revWord = c + revWord;
                }
                Console.WriteLine($"Reverse of Word :{this.word}    is    : {revWord}");
            }
            else
            {
                Console.WriteLine("Word is null. Please give valid input");
            }
        }

        public void ExecuteReverseStringUsingCharArray()
        {
            if (this.word != null)
            {
                char[] letters = this.word.ToCharArray();
                int i = 0, j = this.word.Length - 1;
                char temp;
                while (i < j)
                {
                    temp = letters[i];
                    letters[i] = letters[j];
                    letters[j] = temp;
                    i++;
                    j--;
                }
                Console.WriteLine($"Reverse of Word :{this.word}    is    : {String.Join("", letters)}");
            }
            else
            {
                Console.WriteLine("Word is null. Please give valid input");
            }
        }

        public void ExecuteReverseStringUsingStringBuilder()
        {
            if (this.word != null)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = this.word.Length - 1; i >= 0; i--)
                {
                    sb.Append(word.ElementAt(i));
                }
                Console.WriteLine($"Reverse of Word :{this.word}    is    : {sb.ToString()}");
            }
            else
            {
                Console.WriteLine("Word is null. Please give valid input");
            }
        }
    }
}
