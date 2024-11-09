using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Practise.Design_Patterns.Creational_Design_Patterns.Prototype_Design_Pattern
{
    public class PrototypeClient
    {

        /*
         * In Prototype design pattern, we create the object of class only once 
         * and all other objects for that class, are just clone of the firstly created object.
         * Creating a copy of object rather than creating the object from scratch
         * 
         * The beauty of Prototype method shines when cost of creating object is heavy
         * This approach saves resouces and time, especially when object creation process is heavy.
         * Like when creating object we need to connect to network or database or if it needs to execute lot of code.
         * 
         * Please also check explaination for Deep and Shallow copy (object cloning) in NetworkConnection.cs at line 73
         */
        public void ExecutePrototypeDesignPattern()
        {
            List<string> domains = [ "google.com", "youtube.com", "leetcode.com", "spotify.com" ];

            NetworkConnection connection = new NetworkConnection();
            connection.setIP("340.123.567.34");
            connection.setPort(4004);
            connection.setDomain(domains);
            Console.WriteLine(" Original Connection Object before loading response");
            Console.WriteLine(connection);

            connection.LoadResponse();
            Console.WriteLine("\n Original Connection Object after loading response");
            Console.WriteLine(connection);

            Console.WriteLine("\n Copy 1 Connection Object before editing domains");
            NetworkConnection conn1 = (NetworkConnection) connection.Clone();
            Console.WriteLine(conn1);

            Console.WriteLine("\n Copy 1 Connection Object after editing domains");
            conn1.getDomains().Remove("google.com");
            Console.WriteLine(conn1);

            Console.WriteLine("\n Copy 2 Connection Object before editing domains");
            NetworkConnection conn2 = (NetworkConnection)connection.Clone();
            Console.WriteLine(conn2);





        }
    }
}
