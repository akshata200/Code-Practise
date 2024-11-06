using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Practise
{
    internal class SwapNumbers
    {
        private int a;
        private int b;
        public SwapNumbers(int a, int b) {
            this.a = a;
            this.b = b;
        }

        public void SwapUsingTemp() {

            Console.WriteLine("Swapping using Temp varible");
            Console.WriteLine($"Value of a : {a}   and    b : {b}");

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"Value of a : {a}   and    b : {b}");
        }

        public void SwapWithoutTemp() {

            Console.WriteLine("Swapping without using Temp varible");
            Console.WriteLine($"Value of a : {a}   and    b : {b}");

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"Value of a : {a}   and    b : {b}");
        }


        
    }
}
