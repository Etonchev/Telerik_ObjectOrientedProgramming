using System;

namespace _03_AnimalHierarchy
{
    class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, Sex.Male, age)
        {

        }
    }
}