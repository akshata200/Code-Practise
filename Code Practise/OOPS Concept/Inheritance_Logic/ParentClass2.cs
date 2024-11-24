using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Practise.OOPS_Concept.Inheritance_Logic
{
    internal class ParentClass2
    {
        string className;
        public ParentClass2()
        {
            className = "Parent Class 2";
        }

        public void getClassDetails()
        {
            Console.WriteLine("This is Parent Class 2");
        }

        private void getClassPrivateDetails()
        {
            Console.WriteLine("This is Parent Class 1 private details");
        }
    }
}
