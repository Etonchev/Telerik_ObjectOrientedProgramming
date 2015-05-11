using System;

namespace _03_AnimalHierarchy
{
    class Frog : Animal, ISound
    {
        public override void ProduceSound()
        {
            Console.WriteLine("Crabit, crabit!");
        }
        public Frog(string name, Sex sex, int age)
            : base(name, sex, age)
        {

        }
    }
}