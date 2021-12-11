using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Entities
{
    public class Animal
    {
        public Animal() { }

        public Animal(string name, int age, AnimalType type, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Type = type;
            this.Gender = gender;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public AnimalType Type { get; set; }
        public Gender Gender { get; set; }

        public override string ToString()
        {
            return $"Name: {Name.PadRight(10)}, Age: {Age}, Gender: {Gender}";
        }
    }//Animal

}//NameSpace
