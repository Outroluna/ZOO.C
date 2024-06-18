using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    public class Employee: IEmployee
    {
        public string? Name { get; set; }
        public string? Position { get; set; }
        public double WorkExperience { get; set; }

        public Employee(string? name, string? position, ushort workExperience)
        {
            Name = name;
            Position = position;
            WorkExperience = workExperience;
        }
        ///Проверка на стаж работы
        public bool IsSuitable()
        {
            if(WorkExperience > 1.5) { return true; }
            else { return false; }
        }

        ///Кормление животного
        public void FeedAnimal(Animal animal)
        {
            if (animal.IsHungry)
            {
                Console.WriteLine($"{Name} ({Position}) кормит {animal.TypeAnimal} {animal.Name}.");
                animal.Eat();
            }
            else
            {
                Console.WriteLine($"{animal.TypeAnimal} {animal.Name} - не голоден");
            }
        }

        ///Проверка животного
        public void CheckAnimal(Animal animal)
        {
            Console.WriteLine($"Сотрудник {Name} ({Position}) проверяет {animal.TypeAnimal} - {animal.Name}");
            Console.WriteLine($"{animal.TypeAnimal} - {animal.Name} сейчас {(animal.IsHungry ? "голоден" : "не голоден")}");
            Console.WriteLine($"{animal.TypeAnimal} - {animal.Name}: {(animal.IsActive ? "активный" : "наблюдаются признаки болезни")}");
            animal.MakeSound();
        }
    }
}
