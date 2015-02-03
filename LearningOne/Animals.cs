using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LearningOne
{
    class Animals:CollectionBase
    {
        public void Add(Animal newAnimal) {
            List.Add(newAnimal);
        }
        public void Remove(Animal oldAnimal) {
            List.Remove(oldAnimal);
        }
        public Animals() { }
        public Animal this[int animalIndex] {
            get { return (Animal)List[animalIndex]; }
            set { List[animalIndex] = value; }
        }
    }
    public class Animal { 
        protected string name;
        public Animal(){
            name="Defualt Name";
        }
        public Animal(string newName) {
            name = newName;
        }
        public void feed() {
            Console.WriteLine("{0} has been fed.", name);
        }
    }
    public class Cow : Animal {
        public Cow(string newName) : base(newName) { }
        public void Milked(){Console.WriteLine("{0} has been milked.",name);}
    }
}
