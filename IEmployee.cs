using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    public interface IEmployee
    {
        public string? Name { get; set; }
        public string? Position {  get; set; }
        public double WorkExperience { get; set; }

        public void FeedAnimal(Animal animal);
        public void CheckAnimal(Animal animal);
        public bool IsSuitable();
    }
}
