using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class ProblemTwo
    {

        //Member Variables (HAS A)
        List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };

        //Constructor
        public ProblemTwo()
        {

        }

        //Member Methods (CAN DO)
        public void CopyString()
        {
            var result = names.Distinct();
            foreach(var value in result)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }

    }
}
