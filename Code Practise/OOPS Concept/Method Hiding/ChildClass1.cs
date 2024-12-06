using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Practise.OOPS_Concept.Method_Hiding
{
    internal class ChildClass1 : ParentClass1
    {
        public override void Display()
        {
            Console.WriteLine("This is Display method from Child Class 1");
        }
        public new void Show()
        {
            Console.WriteLine("This is Show method from Child Class 1");
        }
    }
}
