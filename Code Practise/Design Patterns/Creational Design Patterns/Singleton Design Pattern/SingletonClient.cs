using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Practise.Design_Patterns.Creational_Design_Patterns.Singleton_Design_Pattern
{
    public class SingletonClient
    {
        /* check Database connection class for explaination
         * but yes, as name suggests, in Singleton class, we create object of class only once
         * its different from declaring class as static, as in static class we don't create object
         * we call class methods using class name itself
         * here we ensure single object creation by making class Private and having static method to create object/ instance
         */

        public void ExecuteSingletonDesignPattern()
        {
            DatabaseConnection dbConn1 = DatabaseConnection.CreateInstance();
            Console.WriteLine("Hash Code of Object Reference 1 : " + dbConn1.GetHashCode());

            DatabaseConnection dbConn2 = DatabaseConnection.CreateInstance();
            Console.WriteLine("Hash Code of Object Reference 2 : " + dbConn2.GetHashCode());

        }

    }
}
