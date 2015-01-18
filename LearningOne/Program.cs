using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOne
{
    public abstract class Mybase { }
    internal class MyClass : Mybase { }
    public interface IMyBaseInterface { }
    internal interface IMyBaseinterface2 { }
    interface IMyInterface : IMyBaseInterface, IMyBaseinterface2 { }
    sealed class MyComplexClass : MyClass, IMyInterface { }
    class Program
    {
        static void Main(string[] args)
        {
            MyComplexClass test = new MyComplexClass();
            Console.WriteLine(typeof(MyComplexClass));
            Console.ReadKey();
        }
    }
}
