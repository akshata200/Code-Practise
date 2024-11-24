using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Practise.Simple_Code
{
    internal class CheckIfNumisPrime
    {
        // check if given number is prime or not
        int num;

        public CheckIfNumisPrime() {
            this.num = 192; 
        }

        public void ExecuteCheckIfNumIsPrime()
        {
            bool isPrime = true;
            if (num == 0 || num == 1)
            {
                Console.WriteLine($"Given Number {num} is not Prime");
            }
            else
            {
                for (int i = 2; i < Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        Console.WriteLine($"Given Number {num} is not Prime");
                        break;
                    }
                }

                if (isPrime) {
                    Console.WriteLine($"Given Number {num} is Prime");
                }
            }
        }
    }
}
