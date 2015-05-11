using System;

namespace _03_AnimalHierarchy
{
    class Dog : Animal, ISound
    {
        public override void ProduceSound()
        {
            Console.WriteLine("Bau, bau!");
        }
        public Dog(string name, Sex sex, int age)
            : base(name, sex, age)
        {

        }
    }
}