using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class ProblemOne
    {

        //Member Variables (HAS A)
        List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
        
        //Constructor
        public ProblemOne()
        {
            
        }

        //Member Methods (CAN DO)

        public void FindSubString()
        {
            var newWords = words.Where(w => w.Contains("th"));
            foreach(string word in newWords)
            {

                Console.WriteLine(word);
               
            }
            Console.ReadLine();
           
        }
    }
}
