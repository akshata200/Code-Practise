using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Practise.Design_Patterns.Creational_Design_Patterns.Factory_Method_Design_Pattern
{
    public class WebDeveloper : IDeveloper
    {
        private string name;
        private int salary;

        public WebDeveloper(string name, int salary)
        {
            this.name = name;
            this.salary = salary;
        }
        public string GetName()
        {
            return name;
        }

        public int GetSalary()
        {
            return salary;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetSalary(int salary)
        {
            this.salary = salary;
        }

        public override string? ToString()
        {
            return "I am " + this.name + " and my salary is " + this.salary;
        }
    }
}
