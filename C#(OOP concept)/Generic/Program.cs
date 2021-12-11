using Generic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal("Horse", 3, AnimalType.Harvivore, Gender.Male);

            GenericBehavior<Animal> gb = new GenericBehavior<Animal>();

            Console.WriteLine($"{a1.Type}: {gb.GetGenericBehavior(a1)}\n" +
                $"\t{a1}");

            Console.WriteLine();
            Console.WriteLine();

            Animal s1 = new Animal { Name = "Tiger", Age = 5, Type = AnimalType.Carvivore, Gender = Gender.Female, };

            SpecificBehavior<Animal> sb = new SpecificBehavior<Animal>();

            Console.WriteLine($"{s1.Type}: {sb.GetSpecificBehavior<Animal>(s1)}\n" +
                $"\t{s1}");
            Console.WriteLine();
            Console.WriteLine();

            Animal h1 = new Animal { Name = "Human", Age = 25, Type = AnimalType.Omnivore, Gender = Gender.Male, };

            SpecificBehavior<Animal> hb = new SpecificBehavior<Animal>();

            Console.WriteLine($"{h1.Type}: {sb.GetSpecificBehavior<Animal>(h1)}\n" +
                $"\t{h1}");

            Console.ReadLine();
        }//Main method
    }//Program Class
}//NameSpace
