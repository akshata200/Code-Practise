using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Practise.Design_Patterns.Creational_Design_Patterns.Builder_Design_Pattern
{
    public class User
    {
        private string username;
        private string email;
        private string password;

        // we use builder object to initailise the object in Builder design pattern
        public User(UserBuilder builderObj){
            this.username = builderObj.username;
            this.email = builderObj.email;
            this.password = builderObj.password;
        }

        // define only getters and no setter as this design pattern is more recommended for immutable objects
        public string getUsername()
        {
            return username;
        }
        public string getEmail()
        {
            return email;
        }

        public string getPassword()
        {
            return password;
        }

        public override string? ToString()
        {
            return username + "     :       " + email + "       :       " + password;
        }



        // inner builder class

        public class UserBuilder
        {
            public string username;
            public string email;
            public string password;

            public UserBuilder()
            {

            }

            // method chaining
            public UserBuilder setUsername(string username) 
            { 
                this.username = username;
                return this;
            }

            public UserBuilder setEmail(string email)
            {
                this.email = email;
                return this;
            }

            public UserBuilder setPassword(string password)
            {
                this.password = password;
                return this;
            }

            public User build()
            {
                User userObj = new User(this);
                return userObj;
            }



        }

    }
}
