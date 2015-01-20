using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOne
{
    public sealed class Myclass
    {
        public int i;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Myclass test1 = new Myclass();
            Myclass test2 = test1;
            test1.i = 100;
            test2.i = 200;
            Console.WriteLine(test1.i);
            Console.WriteLine(test2.i);
            Console.ReadKey();
        }
    }
}
