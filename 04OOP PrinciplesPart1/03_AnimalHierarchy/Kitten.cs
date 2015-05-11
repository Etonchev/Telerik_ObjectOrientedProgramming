using System;

namespace _03_AnimalHierarchy
{
    class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, Sex.Female, age)
        {

        }
    }
}