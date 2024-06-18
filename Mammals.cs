using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    public abstract class Mammals : Animal;

    public class Predators : Mammals
    {
        public override string? TypeAnimal { get; }
        public override string? Name { get; set; }
        public override string? Species { get; } = "Млекопитающие";
        public override bool IsHungry { get; protected set; }
        public override bool IsActive { get; protected set; }

        public Predators(string? typeAnimal, string name)
        {
            TypeAnimal = typeAnimal;
            Name = name;
            IsHungry = random.Next(0, 3) == 0; // 33% шанс на голод
            IsActive = random.Next(0, 2) == 0; // 50% шанс на активность
        }
        protected override void UpdateHunger()
        {
            IsHungry = random.Next(0, 3) == 0; // 33% шанс на изменение состояния голода
        }
        protected override void UpdateActive()
        {
            IsActive = random.Next(0, 3) == 0; // 33% шанс на изменение состояния активности
        }
        public override void MakeSound()
        {
            Console.WriteLine($"Як {TypeAnimal} {Name} рычит: рррррррр");
        }
        public override void Eat()
        {
            Console.WriteLine($"Хищник: {TypeAnimal} по имени {Name} ест мясо");
        }
    }

    public class Primates : Mammals
    {
        public override string? TypeAnimal { get; }
        public override string? Name { get; set; }
        public override string? Species { get; } = "Млекопитающие";
        public override bool IsHungry { get; protected set; }
        public override bool IsActive { get; protected set; }

        public Primates(string? typeAnimal, string name)
        {
            TypeAnimal = typeAnimal;
            Name = name;
            IsHungry = random.Next(0, 2) == 0;
            IsActive = random.Next(0, 2) == 0;
        }
        protected override void UpdateHunger()
        {
            IsHungry = random.Next(0, 2) == 0;
        }
        protected override void UpdateActive()
        {
            IsActive = random.Next(0, 3) == 0; // 33% шанс на изменение состояния активности
        }
        public override void MakeSound()
        {
            Console.WriteLine($"Як {TypeAnimal} {Name} кричит: 'звуки приматов'");
        }
        public override void Eat()
        {
            Console.WriteLine($"Примат: {TypeAnimal} по имени {Name} ест фрукты");
        }
    }
}
