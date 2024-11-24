using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Practise.OOPS_Concept.Inheritance_Logic
{
    /*
    internal class ChildClass1 : ParentClass1,ParentInterface1
    {
        public void getParentInterfaceDetails()
        {
            Console.WriteLine("This is child class implementing Parent Interface 1");
        }
    }
    */

    /*
    internal class ChildClass1 : ParentInterface1, ParentInterface2
    {
        public void getParentInterfaceDetails()
        {
            Console.WriteLine("This is child class implementing Parent Interface 1 and Parent Interface 2");
        }
    }
    */

    internal class ChildClass1 : AbstractParentClass1
    {
        
        public override void GetAbstractParentClassDetails()
        {
            Console.WriteLine("This is child class implementing Abstract Parent 1");
        }
    }
}
