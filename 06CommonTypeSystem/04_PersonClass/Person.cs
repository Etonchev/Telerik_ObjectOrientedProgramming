using System;

namespace _04_PersonClass
{
    class Person
    {
        private string name;
        private int? age;

        public Person(string name, int? age = null)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            if (this.age == null)
            {
                return String.Format("Name: {0}, Age: (Not specified)", name);
            }

            return String.Format("Name: {0}, Age: {1}", name, age);
        }
    }
}
