using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Practise.OOPS_Concept.Delegates_and_Anonymous_Functions
{
    internal class DelegatesExample
    {
        public delegate void GreetingDelegate(string name);

        public void GreetingsFunc1(string name)
        {
            Console.WriteLine($"Hello {name}, Good Morning");
        }

        public void GreetingsFunc2(string name)
        {
            Console.WriteLine($"How are you doing {name}?");
        }

        public void GreetingsFunc3(string name)
        {
            Console.WriteLine($"Is it morning there or evening. Well in any case.. Good Morning {name}");
        }


        /// <summary>
        /// Main execution method for DelegatesExample class
        /// </summary>
        public void ExecuteDelegatesExample()
        {
            Console.WriteLine("Named Function Example");
            NamedFunctionExample();
            Console.WriteLine("\n Anonymous Function example");
            AnonymousFuncExample();
            
        }

        public void NamedFunctionExample()
        {
            // Create object for delegate and pass the function name which it executes
            GreetingDelegate greet = new GreetingDelegate(GreetingsFunc1);
            try
            {
                //here we are binding the named functions
                greet += GreetingsFunc2; // subscribe
                greet -= GreetingsFunc1; // unsubscribe
                greet += GreetingsFunc3; // subscribe
                greet.Invoke("Akshata");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void AnonymousFuncExample()
        {
            GreetingDelegate gd = delegate (string name)
            {
                Console.WriteLine($"Hello {name}!! This is an Anonymous Function");
            };
            gd += delegate (string name)
            {
                Console.WriteLine(" How are you doing girl? ");
            };
            gd.Invoke("Krist");
        }
    }
}
