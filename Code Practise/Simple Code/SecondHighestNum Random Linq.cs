using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Practise.Simple_Code
{
    internal class SecondHighestNum
    {
        public void SecondHighestNumberinList()
        {
            Console.WriteLine();
            List<int> numList = new List<int>();
            Random rn = new Random();
            for (int i = 0; i < 10; i++)
            {
                numList.Add(rn.Next(1,20));
            }
            foreach (int num in numList) { 
                Console.Write(num+"  ");
            }
            Console.WriteLine();

            int secondHeighest = numList.OrderByDescending(x => x).Skip(1).FirstOrDefault();
            Console.WriteLine("Second Heighest in List    :   "+secondHeighest);
            
        }

        public void SecondHighestNuminArray() {
            Console.WriteLine();
            int []arr = new int[10];
            Random rn = new Random();
            for (int i = 0; i < 10; i++)
            {
                arr[i] = rn.Next(1,20);
            }
            foreach (int num in arr)
            {
                Console.Write(num + "  ");
            }
            Console.WriteLine();

            int secondHeighest = arr.OrderByDescending(x => x).Skip(1).FirstOrDefault();
            Console.WriteLine("Second Heighest in Array    :   " + secondHeighest);
        }
        
    }
}
