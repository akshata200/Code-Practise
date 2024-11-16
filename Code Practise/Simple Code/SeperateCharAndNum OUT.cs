using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Practise.Simple_Code
{
    //how to seperate charcter and number from the string 
    internal class SeperateCharAndNum
    {
        /* if string str = "1DO23NA", return two strings nums = "123" and charStr = "DONA"
         */

        public void SeperateCharAndNumFromStr(out string numStr, out string charStr) {
            numStr = string.Empty;
            charStr = string.Empty;
            string str = "1DO23NA";
            foreach (char c in str)
            {
                if (Char.IsDigit(c))
                    numStr = numStr + c ;
                else
                    charStr = charStr + c ;
            }
        }

        public void PrintStrings()
        {
            string numStr = string.Empty;
            string charStr = string.Empty;
            SeperateCharAndNumFromStr(out numStr,out charStr);
            Console.WriteLine(charStr + "   :   " + numStr);
        }
    }
}
