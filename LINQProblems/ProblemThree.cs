using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class ProblemThree
    {

        //Member Variables (HAS A)

       public List<string> classGrades = new List<string>()
       {
            "80,100,92,89,65",
            "93,81,78,84,69",
            "73,88,83,99,64",
            "98,100,66,74,55"
       };
        public List<double> NewClassGrades = new List<double>();

        //Constructor
        public ProblemThree()
        {

        }
       
        //Member Methods (CAN DO)
        public void DropLowestNumber()
        {
            for (int i = 0; i < classGrades.Count; i++)
            {
                
                var dropGrades = classGrades[i].Split(',').Select(Int32.Parse).ToList();
                dropGrades.Remove(dropGrades.Min());
                NewClassGrades.Add(dropGrades.Average());
                
            }
           
        }
        
        public void GetAverageOfAverage()
        {
            NewClassGrades.Average();

            Console.WriteLine("The overall average is: " + NewClassGrades.Average());
            Console.ReadLine();
        }
        
    }
}
