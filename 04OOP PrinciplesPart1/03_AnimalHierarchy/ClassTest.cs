using System;
using System.Collections.Generic;

namespace _03_AnimalHierarchy
{
    class ClassTest
    {
        static void AverageAge(List<Animal> animals)
        {
            double averageAgeDog = 0;
            double averageAgeFrog = 0;
            double averageAgeCat = 0;
            int dogCount = 0;
            int frogCount = 0;
            int catCount = 0;

            foreach (var item in animals)
            {
                if (item.GetType() == typeof(Dog))
                {
                    dogCount++;
                    averageAgeDog += item.Age;
                }

                if (item.GetType() == typeof(Frog))
                {
                    frogCount++;
                    averageAgeFrog += item.Age;
                }

                if (item.GetType() == typeof(Kitten) || item.GetType() == typeof(Tomcat))
                {
                    catCount++;
                    averageAgeCat += item.Age;
                }
            }

            averageAgeDog /= dogCount;
            averageAgeFrog /= frogCount;
            averageAgeCat /= catCount;

            Console.WriteLine("Average age of dogs is: {0,10}\nAverage age of frongs is: {1,10}\nAverage age of cats is: {2,10}", averageAgeDog, averageAgeFrog, averageAgeCat);
        }

        public static void Main()
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog("Rex", Sex.Male, 3));
            animals.Add(new Kitten("Marry", 1));
            animals.Add(new Tomcat("Tom", 2));
            animals.Add(new Frog("Curmit", Sex.Male, 1));
            animals.Add(new Dog("Lassi", Sex.Female, 2));
            animals.Add(new Kitten("Suzzi", 2));
            animals.Add(new Tomcat("Rick", 4));
            animals.Add(new Frog("John", Sex.Male, 3));

            foreach (var item in animals)
            {
                item.ProduceSound();
            }

            Console.WriteLine();
            AverageAge(animals);
        }
    }
}
