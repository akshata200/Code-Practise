using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Practise.Simple_Code
{
    class Player
    {
        public string Name { get; set; }
        public string Plays { get; set; }

        public Player(string name, string plays) { 
            this.Name = name;
            this.Plays = plays;
        }
    }
    internal class EqualityOperatorAndEquals
    {
        public void ExecuteEqualityOperatorAndEquals()
        {
            String s1 = "Akshata";
            String s2 = "Akshata";

            Console.WriteLine("Operator Checks on strings");

            bool equalityOperator = (s1 == s2);
            bool equalsCommand = (s1.Equals(s2));
            Console.WriteLine("Equality Operator    :"+ equalityOperator);
            Console.WriteLine("Equals               :" + equalsCommand);

            Console.WriteLine("Operator Checks on Player Objects");
            Player p1 = new Player("Richard","Baseball");
            Player p2 = new Player("Richard","Baseball");

            equalityOperator = (p1 == p2);
            equalsCommand = (p1.Equals(p2));
            Console.WriteLine("Equality Operator    :" + equalityOperator);
            Console.WriteLine("Equals               :" + equalsCommand);

        }

    }
}
