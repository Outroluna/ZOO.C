using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    public abstract class Animal
    {
        protected static Random random = new Random();
        public abstract string? TypeAnimal { get; }
        public abstract string? Name { get; set; }
        public abstract string? Species { get; }
        public abstract bool IsHungry { get; protected set; }
        public abstract bool IsActive { get; protected set; }
        protected abstract void UpdateHunger();
        protected abstract void UpdateActive();

        public abstract void MakeSound();
        public abstract void Eat();
    }
}

