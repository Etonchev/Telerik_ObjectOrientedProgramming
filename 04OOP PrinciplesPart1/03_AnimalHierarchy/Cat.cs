using System;

namespace _03_AnimalHierarchy
{
    class Cat : Animal, ISound
    {
        public override void ProduceSound()
        {
            Console.WriteLine("Miau, miau!");
        }
        public Cat(string name, Sex sex, int age)
            : base(name, sex, age)
        {

        }
    }
}