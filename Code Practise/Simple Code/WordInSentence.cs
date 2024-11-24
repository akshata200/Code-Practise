using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Practise.Simple_Code
{
    internal class WordInSentence
    {
        string sentence;
        string word;

        public WordInSentence()
        {
            sentence = "It uniquely identifies a record in the relational database table";
            word = "Record  ";
        }

        public void ExecuteCheckWordInSentence()
        {
            bool wordExists = false;
            if (sentence != null && word != null)
            {
                string[] words = sentence.ToLower().Split(" ");
                word = word.Trim().ToLower();
                foreach (string w in words) {
                    if (w.Trim() == word)
                    {
                        Console.WriteLine("Given word exists in the sentence");
                        wordExists = true;
                        break;
                    }
                }
                if (!wordExists) {
                    Console.WriteLine("Word does not exists in given sentence");
                }
            }

        }
    }
}
