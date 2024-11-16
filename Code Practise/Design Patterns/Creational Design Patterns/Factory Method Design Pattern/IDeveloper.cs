using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Practise.Design_Patterns.Creational_Design_Patterns.Factory_Method_Design_Pattern
{
    internal interface IDeveloper
    {
        public string GetName();
        public int GetSalary();
        public void SetName(string name);
        public void SetSalary(int salary);

        public string? ToString();

    }
}
