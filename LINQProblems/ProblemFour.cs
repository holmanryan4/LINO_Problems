using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class ProblemFour
    {

        //Member Variables (HAS A)
        List<string> name = new List<string>();
        List<int> result = new List<int>();
        //Constructor
        public ProblemFour()
        {
            name.Add("Terrill");

        }

        //Member Methods (CAN DO)
        public void OrderedString()
        {
            for (int i = 0; i < name.Count; i++)
            {
                var ordered = name[i].Length.ToString();
                ordered.Trim();
            }
            
            
            Console.ReadLine(); 
        }
        
    }
}
