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
            Animals myAnimals = new Animals();
            for (int i = 1; i < 5; i++) {
                myAnimals.Add(new Cow("test" + i.ToString()));
            }
            foreach(Animal myAnimal in myAnimals){
                myAnimal.feed();
            }
            //myAnimals[0]=new Cow("Bill Gate");//使用索引符后可用
            //myAnimals[0].feed();
            Console.ReadKey();
        }
    }
}
