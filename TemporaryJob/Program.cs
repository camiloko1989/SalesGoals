using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TemporaryJob
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Create salesperson
            //2. Add goal to salesperson
            //3. Show goals every month 5% 10% 15% 20%


            void AddValues(Salesperson[] salespeople1) //fills each salesperson name and goal
            {

                foreach(Salesperson s in salespeople1)
                {
                    s.fullName = s.getName();
                    s.goal = s.getGoal();
                }
            }

            
            Salesperson[] salespeople = new Salesperson[4] // Create an array of Salesperson objects 
            {
                new Salesperson(),
                new Salesperson(),
                new Salesperson(),
                new Salesperson()
            };

            AddValues(salespeople); 

            for (int i = 0; i < salespeople.Length; i++) //it 
            {
                WriteLine(salespeople[i]); //calls the object salesperson -> override ToString
                salespeople[i].CalculateExpected(salespeople[i].goal);
                foreach(var e in salespeople[i].expected) 
                {
                    WriteLine("Month #{0}: {1}", i, e); 
                }
                
            }
            ReadKey();
        }
    }
}
