using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;

namespace TemporaryJob
{
    internal class Salesperson
    {
        public string fullName;
        public double goal;
        public double[] expected;


        public Salesperson() { }

        public Salesperson(string name, double goal)
        {
            fullName = name;
            this.goal = goal;

        }

        public string getName()
        {
            WriteLine("Input the full name of salesperson: ");
            fullName = ReadLine();
            return fullName;
        }

        public double getGoal()
        {
            WriteLine("Input the goal for the salesperson: ");
            goal = Convert.ToDouble(ReadLine());
            return goal;
        }

        public string SwitchNames(string name)
        {
            string firstName = name.Split(' ')[0];
            string surname = name.Split(' ')[1];
            string switchedName = surname + ", " + firstName;
            return switchedName;
        }

        public double[] CalculateExpected(double goal1)
        {
            double m1 = goal * 1.05; //increments goal in 5%
            double m2 = m1 * 1.1;
            double m3 = m2 * 1.15;
            double m4 = m3 * 1.2;
            expected = new double[] { m1, m2, m3, m4 }; //creates an array and fills it with increments
            return expected;
        }

        /*public void ShowExpected(double[] expected1)
        {
            for(int i = 0; i < expected1.Length; i++)
            {
                WriteLine("Month #{0}: {1}", i, expected1[i]);
            }
        }*/

        public override string ToString()
        {
            return "\n"+SwitchNames(fullName) + ", their goal is: " + goal + " and their expected sales are: " ;
        }
    }
}
