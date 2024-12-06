using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Practise.Simple_Code
{
    internal class Helper
    {
        public void ExecuteHelper()
        {
            Dictionary<string, int> numtable = new Dictionary<string, int>();
            numtable.Add("One", 1);
            numtable.Add("Four", 4);
            numtable.Add("Three", 3);
            numtable.Add("Two", 2);



            foreach (var item in numtable)
            {
                Console.WriteLine(item.Key + "   :   " + item.Value);
            }
            Dictionary<string, int> sortedDict = numtable.OrderBy(x => x.Value).ToDictionary();
            Console.WriteLine();
            foreach (var item in sortedDict)
            {
                Console.WriteLine(item.Key + "   :   " + item.Value);
            }

            List<int> arrList = [12, -4, 5, 0, 0, -3, 6];
            int pos = 0, neg = 0, zero = 0;
            int total = arrList.Count;
            foreach (int i in arrList)
            {
                if (i < 0)
                    neg++;
                else if (i > 0)
                    pos++;
                else
                    zero++;
            }
            arrList.Sort();
            Console.WriteLine($"{(decimal)pos / total}");
            Console.WriteLine(string.Format("{0:N6}", ((decimal)pos / total)));
            Console.WriteLine((decimal)neg / total);
            Console.WriteLine((decimal)zero / total);

            string time = "12";
            time = "" + (int.Parse(time) - 2);
            Console.WriteLine(time);
        }
    }
}
