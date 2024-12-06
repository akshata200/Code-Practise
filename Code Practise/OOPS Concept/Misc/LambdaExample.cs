using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Code_Practise.OOPS_Concept.Misc
{
    class Person
    {
        public string name;
        public int age;
        public bool isEmployed;

        public Person() { }
        public Person(string name , int age, bool isEmployed)
        {
            this.name = name;
            this.age = age;
            this.isEmployed = isEmployed;
        }

        
        public override string ToString()
        {
            return name + "  :  " + age + "  :  " + isEmployed;
        }
    }
    internal class LambdaExample
    {
        public delegate bool tryDelegate(string word);
        public void ExecuteLambdaExample()
        {
            List<Person> people = new List<Person>
            {
                new Person("Janvi",24,false),
                new Person("Vaibhav",24,true),
                new Person("Akshata",23,true),
                new Person("Sanika",21,false)
            };

            List<Person> sortedPeople = people.OrderBy(p => p.age).ToList();
            Console.WriteLine("\nSorted by Age");
            foreach (Person person in sortedPeople) {
                Console.Write(person.name + "  ");
            }
            Console.WriteLine("\n \nEmployed People");
            List<Person> employedPeople = people.FindAll(p => p.isEmployed);
            foreach (Person person in employedPeople)
            {
                Console.Write(person.name + "  ");
            }

            Console.WriteLine("\n \nEmployed People Sorted By Age");
            List<Person> employedSortedPeople = people.FindAll(p => p.isEmployed).OrderBy(p => p.age).ToList();
            foreach (Person person in employedSortedPeople)
            {
                Console.Write(person.name + "  ");
            }

            Console.WriteLine("\n \nEven Number");
            List<int> numList = new List<int>{ 2, 6, 1, 9, 5, 3 };
            List<int> evenNumList = numList.FindAll(x => x % 2 == 0);
            foreach (int num in evenNumList)
            {
                Console.Write(num+"  ");
            }

        }

        public void TryingActualLamdbaExamples()
        {
            // takes two ints as input as returns int as output (int,int,int)

            //Multiply two numbers
            Func<int, int,int> Multiply = (x, y) => x * y;
            Console.WriteLine(String.Format("Multiplication of two numbers {0} and {1} is {2} ", 3, 5,Multiply(3,5)));

            //Performs some operations on two numbers
            Func<int, int, int> SomeOperations = (x, y) => {
                int t = x * y;
                t = t * 2;
                t = t / 4;
                return t;
            };
            Console.WriteLine(String.Format("Performing some actions on integers {0} and {1} is {2}",4,5,SomeOperations(4,5)));

            //return list of people where age is greater than equal to 23 and is employed
            List<Person> people = new List<Person>
            {
                new Person("Janvi",24,false),
                new Person("Vaibhav",24,true),
                new Person("Akshata",23,true),
                new Person("Sanika",21,false),
                new Person("Simran",25,false),
                new Person("Tulsi",26,false),
                new Person("Kristi", 22,true)
            };

            // Custom condition...similar to Java Comparator
            Func<Person, bool> filterPeople = (person) =>
            {
                if (person.age >= 23 && person.isEmployed)
                    return true;
                else
                    return false;
            };

            Console.WriteLine();

            List<Person> filteredPeople = people.Where(filterPeople).ToList();
            // Below statement also works, but above statement is more compact
            //List<Person> filteredPeople = people.Where(person => filterPeople(person)).ToList();
            foreach (Person p in filteredPeople)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("\nCustom Sorted people");
            Func<Person,Person, bool> customSortPeople = (p1,p2) =>
            {
                if(p1.age < p2.age)
                    return false;
                else
                    return true;
            };
            
            /*
            List<Person> sortedPeople = people.Where((p1,p2) => customSortPeople(p1,)).ToList();
            foreach (Person p in sortedPeople)
            {
                Console.WriteLine(p);
            }
            */

        }

    }
}
