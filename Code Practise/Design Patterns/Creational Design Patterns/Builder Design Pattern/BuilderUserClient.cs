using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Practise.Design_Patterns.Creational_Design_Patterns.Builder_Design_Pattern
{
    internal class BuilderUserClient
    {
        /*
         * In Builder design pattern, we create an internal builder class which helps in creating instance/object for our actual class
         * Benifit of builder class shines most when our class has lot of data member (like more than 20)
         * In that case, passing all arguments to a constructor can be tacky. 
         * you might also need to remember all the arguments and their sequence while creating obj using constructor
         * And what if some arguments can be optional
         * In that case you will need to define multiple parameterised constructor with all possibilties 
         * but still 20 constructors? Thats gonna be such a tacky and complicated code
         * 
         * So here comes the builder class, if you see below client code example
         * you can see while creaing class object, I can give parameter in any sequence I want and no need to give all parameters
         */
        public void ExecuteUserBuilderDesignPattern()
        {
            User userObj1 = new User.UserBuilder()
                                .setUsername("Akshata")
                                .setEmail("Akshata@gmail.com")
                                .setPassword("AKS@123")
                                .build();

            User userObj2 = new User.UserBuilder()
                                .setPassword("JAN@123")
                                .setUsername("Janvi")                                
                                .build();

            Console.WriteLine("User 1  :  "+userObj1);
            Console.WriteLine("User 2  :  "+userObj2);

        }
    }
}
