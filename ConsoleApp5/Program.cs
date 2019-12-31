using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
  public  class Program
    {
        static void Main(string[] args)
        {
            List<Double> list = new List<Double>();
            //list.Add(5);
            //list.Add(2);
            //list.Add(9);

        
             Double tx = list.FirstOrDefault();
            Console.WriteLine(tx);

            //TechnicalInterview technicalInterview = new TechnicalInterview();
            //Console.WriteLine(technicalInterview.ReverseString("Faisal Ayub"));
            //Console.WriteLine(technicalInterview.IsPalindrome("asdfghjklkjhgFdsa"));
            Console.ReadLine();
        }
    }
}
