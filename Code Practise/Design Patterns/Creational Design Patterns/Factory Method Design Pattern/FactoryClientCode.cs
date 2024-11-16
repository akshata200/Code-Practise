using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Practise.Design_Patterns.Creational_Design_Patterns.Factory_Method_Design_Pattern
{
    internal class FactoryClientCode
    {
        public void ExecuteFactoryDesignPattern()
        {
            Factory factoryObj = new Factory();

            IDeveloper developer1 = factoryObj.CreateInstance("Web");
            Console.WriteLine("Developer 1 : " + developer1);

            IDeveloper developer2 = factoryObj.CreateInstance("Android");
            Console.WriteLine("Developer 2 : " + developer2);

            IDeveloper developer3 = factoryObj.CreateInstance("Desktop");
            Console.WriteLine("Developer 3 : " + developer3);

            IDeveloper developer4 = factoryObj.CreateInstance("Random");
            Console.WriteLine("Developer 4 : " + developer4);

        }
    }
}
