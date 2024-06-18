using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    public abstract class Birds : Animal;
    public class Falcons : Birds
    {
        public override string? TypeAnimal { get; }
        public override string? Name { get; set; }
        public override string? Species { get; } = "Птицы";
        public override bool IsHungry { get; protected set; }
        public override bool IsActive { get; protected set; }
        public Falcons(string? typeAnimal, string name)
        {
            TypeAnimal = typeAnimal;
            Name = name;
            IsHungry = random.Next(0, 3) == 0;
            IsActive = random.Next(0, 2) == 0;
        }
        protected override void UpdateHunger()
        {
            IsHungry = random.Next(0, 3) == 0;
        }
        protected override void UpdateActive()
        {
            IsActive = random.Next(0, 3) == 0; // 33% шанс на изменение состояния активности
        }
        public override void MakeSound()
        {
            Console.WriteLine($"Як {TypeAnimal} {Name} кричит: иуууууууу");
        }
        public override void Eat()
        {
            Console.WriteLine($"Птица: {TypeAnimal} по имени {Name} ест маленьких мертвых мышат");
        }
    }
    public class Woodpeckers : Birds
    {
        public override string? TypeAnimal { get; }
        public override string? Name { get; set; }
        public override string? Species { get; } = "Птицы";
        public override bool IsHungry { get; protected set; }
        public override bool IsActive { get; protected set; }
        
        public Woodpeckers(string? typeAnimal, string name)
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
            Console.WriteLine($"Як {TypeAnimal} {Name} кричит: тук-тук-тук-тук");
        }
        public override void Eat()
        {
            Console.WriteLine($"Птица: {TypeAnimal} по имени {Name} ест зёрна");
        }

    }
}
