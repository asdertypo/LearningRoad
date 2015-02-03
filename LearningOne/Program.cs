using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "smith", "apple", "snake", "park", "tick", "game", "sologn", "photo", "saw", "test" };
            var results = names.OrderBy(n=>n).Where(c => c.StartsWith("s"));
            //var results=from n in names
            //            where n.StartsWith("s")
            //            select n;
            foreach(var result in results){
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }
    }
}
