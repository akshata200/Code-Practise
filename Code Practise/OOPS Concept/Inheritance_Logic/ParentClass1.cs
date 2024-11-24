using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Practise.OOPS_Concept.Inheritance_Logic
{
    internal class ParentClass1
    {
        string className;
        public ParentClass1()
        {
            className = "Parent Class 1";
        }
        
        public void getClassDetails()
        {
            Console.WriteLine("This is Parent Class 1");
        }

        private void getClassPrivateDetails()
        {
            Console.WriteLine("This is Parent Class 1 private details");
        }
    }
}
