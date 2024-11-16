using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Practise.Design_Patterns.Creational_Design_Patterns.Factory_Method_Design_Pattern
{
    internal class Factory
    {
        public IDeveloper CreateInstance(string option)
        {
            if (option == "Android")
                return new AndroidDeveloper("Android Developer", 30000);
            else if (option == "Web")
                return new WebDeveloper("Web Developer", 20000);
            else if (option == "Desktop")
                return new DesktopAppDeveloper("Desktop App Developer", 60000);
            else
                return null;
        }
    }
}
