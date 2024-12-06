using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Practise.OOPS_Concept.Method_Hiding
{
    internal class ParentClass1
    {
        public virtual void Display()
        {
            Console.WriteLine("This is Display method from Parent Class 1");
        }
        public void Show()
        {
            Console.WriteLine("This is Show method from Parent Class 1");
        }
    }
}
