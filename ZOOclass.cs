using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    public class ZOOclass
    {
        public string? Name { get; set; }
        List<Animal> Animals = new List<Animal>();
        List<IEmployee> Employees = new List<IEmployee>();

        public ZOOclass(string? name)
        {
            Name = name;
        }
        ///Добавление животных в зоопарк
        public void AddAnimal(params Animal[] animal)
        {
            foreach (var anim in animal)
            {
                Animals.Add(anim);
                Console.WriteLine($"{anim.TypeAnimal} - {anim.Name}: добавлен в зоопарк");
            }
        }
        ///Удаление животных из зоопарка
        public void RemoveAnimal(Animal animal)
        {
            if (Animals.Remove(animal))
            {
                Console.WriteLine($"{animal.TypeAnimal} - {animal.Name} больше не находится в зоопарке {Name}");
            }
            else
            {
                Console.WriteLine($"{animal.TypeAnimal} {animal.Name}  не находился в зоопарке");
            }
        }
        ///Вывод списка всех животных, добавленных в зоопарк
        public void ListAnimals()
        {
            Console.WriteLine("Список животных зоопарка: ");
            foreach (var animal in Animals)
            {
                Console.WriteLine($"Семейство: {animal.Species}, Вид: {animal.TypeAnimal}, Имя: {animal.Name}");
            }
        }

        ///Добавление сотрудника в зоопарк
        public void HireEmployee(IEmployee employee)
        {
            if (employee.IsSuitable())
            {
                if (Employees.Contains(employee) == false)
                {
                    Employees.Add(employee);
                    Console.WriteLine($"{employee.Name} принят на должность: {employee.Position}");
                }
                else
                    Console.WriteLine($"{employee.Name} уже работает в Зоопарке на должности: {employee.Position}");
            }
            else
            {
                Console.WriteLine($"{employee.Name} не принят на работу (недостаточный стаж работы)");
            }
        }

        ///Увольнение сотрудника зоопарка
        public void FireEmployee(IEmployee employee)
        {
            if (Employees.Remove(employee))
            {
                Console.WriteLine($"{employee.Name} был уволен с должности {employee.Position}");
            }
            else
            {
                Console.WriteLine($"{employee.Name} не сотрудник зоопарка");
            }
        }
        ///Вывод списка всех сотрудников зоопарка
        public void ListEmployees()
        {
            Console.WriteLine("Список сотрудников зоопарка: ");
            foreach (var employee in Employees)
            {
                Console.WriteLine($"Имя: {employee.Name}, Должность: {employee.Position}");
            }
        }

        ///Кормление всех животных
        public void FeedAllAnimals()
        {
            foreach (var employee in Employees)
            {
                foreach (var animal in Animals)
                {
                    employee.FeedAnimal(animal);
                }
            }
        }
        ///Проверка всех животных
        public void CheckAllAnimals()
        {
            foreach (var employee in Employees)
            {
                foreach (var animal in Animals)
                {
                    employee.CheckAnimal(animal);
                }
            }
        }
    }
}
    

