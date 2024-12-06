using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Practise.OOPS_Concept.Misc
{
    internal class LINQExample
    {
        class Person
        {
            public string name;
            public int age;
            public bool isEmployed;

            public Person() { }
            public Person(string name, int age, bool isEmployed)
            {
                this.name = name;
                this.age = age;
                this.isEmployed = isEmployed;
            }
        }
        public void ExecuteLINQExample()
        {
            List<int> numList = new List<int> { 2,7,9,5,1,4,6};

            Console.WriteLine("All Number :");
            foreach (int num in numList)
            {
                Console.Write(num + "   ");
            }

            /*
            var filterednums = from num in numList
                               where num > 3 && num < 8
                               select num;
            */
            var filterednums = from num in numList
                               where num%2 == 0
                               select num;

            Console.WriteLine("\nNumbers Greater Than 3 :");
            foreach (int num in filterednums) {
                Console.Write(num + "   ");
            }
        }
    }
}
