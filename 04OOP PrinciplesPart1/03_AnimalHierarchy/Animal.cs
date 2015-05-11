using System;

namespace _03_AnimalHierarchy
{
    interface ISound
    {
        void ProduceSound();
    }

    public enum Sex { Male, Female }

    abstract class Animal : ISound
    {
        public string Name { get; set; }
        public Sex Sex { get; set; }
        public int Age { get; set; }

        public Animal(string name, Sex sex, int age)
        {
            Name = name;
            Sex = sex;
            Age = age;
        }

        abstract public void ProduceSound();
    }
}
