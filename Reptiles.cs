using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    public abstract class Reptiles : Animal;

    public class Turtles: Reptiles
    {
        public override string? TypeAnimal { get; }
        public override string? Name { get; set; }
        public override string? Species { get; } = "Черепахи";
        public override bool IsHungry { get; protected set; }
        public override bool IsActive { get; protected set; }

        public Turtles(string? typeAnimal, string name)
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
            Console.WriteLine($"Як {TypeAnimal} {Name} говорит: (черепаха молчит)");
        }
        public override void Eat()
        {
            Console.WriteLine($"Черепаха: {TypeAnimal} по имени {Name} ест водоросли");
        }
    }

    public class Snakes: Reptiles
    {
        public override string? TypeAnimal { get; }
        public override string? Name { get; set; }
        public override string? Species { get; } = "Змея";
        public override bool IsHungry { get; protected set; }
        public override bool IsActive { get; protected set; }

        public Snakes(string? typeAnimal, string name)
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
            Console.WriteLine($"Як {TypeAnimal} {Name} шипит: сссссссс");
        }
        public override void Eat()
        {
            Console.WriteLine($"Змея: {TypeAnimal} по имени {Name} ест чью-то ногу");
        }
    }
}
