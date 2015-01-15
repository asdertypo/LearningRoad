using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOne
{
    class Program
    {
        delegate int ProcessNum(int numOne, int numTwo);
        static int Addition(int numOne, int numTwo) {
            int val;
            val = numOne + numTwo;
            return val;
        }
        static int Substraction(int numOne, int numTwo) {
            int val = numOne - numTwo;
            return val;
        } 
        static void Main(string[] args)
        {
            ProcessNum process;
            Console.Write("Please press the first number:");
            int one = Convert.ToInt32(Console.ReadLine());
            Console.Write("Good!Now please press the second number:");
            int two = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cool!The last step is to choose addition or substraction,press \"a\" or \"s\".");
            string choise =Console.ReadLine();
            if (choise.Substring(0, 1) == "a")
            {
                process = new ProcessNum(Addition);
            }
            else {
                process = new ProcessNum(Substraction);
            }
            Console.WriteLine("The result is {0}", process(one, two));
            Console.ReadKey();
        }
    }
}
