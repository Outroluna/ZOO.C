using ZOO;

ZOOclass zoo = new ZOOclass("Краснодарский Зоопарк");


//СОЗДАНИЕ ЖИВОТНЫХ
Animal mammal1 = new Predators("Лев", "Симба");
Animal mammal2 = new Predators("Тигр амурский", "Шер-Хан");

Animal mammal3 = new Primates("Макак японский", "Лёлик");
Animal mammal4 = new Primates("Мартышка браззовская", "Болик");

Animal bird1 = new Falcons("Ястреб-тетеревятник", "Стрела");
Animal bird2 = new Falcons("Белоплечий орлан", "Снежок");

Animal bird3 = new Woodpeckers("Арасари черногорлый", "Стукач");
Animal bird4 = new Woodpeckers("Тукан-ариель черноклювый", "Тукимен");

Animal reptile1 = new Turtles("Черепаха шпоросная", "Рафаэль");
Animal reptile2 = new Turtles("Черепаха египетская", "Донатело");
Animal reptile3 = new Turtles("Черепаха средиземноморская", "Микелянджело");
Animal reptile4 = new Turtles("Черепаха двухкоготная", "Леонардо");

Animal reptile5 = new Snakes("Удав обыкновенный", "Пушистик");
Animal reptile6 = new Snakes("Игуана обыкновенная", "Джанго");

//ДОБАВЛЕНИЕ ЖИВОТНЫХ В ЗООПАРК
zoo.AddAnimal(mammal1,mammal2, mammal3, mammal4, bird1, bird2, bird3, bird4, reptile1, reptile2, reptile3, reptile4, reptile5, reptile6);

//ВЫВОД ВСЕХ ЖИВОТНЫХ ЗООПАРКА  
zoo.ListAnimals();

//УДАЛЕНИЕ ЖИВОТНОГО ИЗ ЗООПАРКА
zoo.RemoveAnimal(bird2);

//СОЗДАНИЕ СОТРУДНИКОВ
IEmployee employee1 = new Employee("Ладимир", "Смотритель", 10);
IEmployee employee2 = new Employee("Драгомир", "Помощник", 1);
IEmployee employee3 = new Employee("Истислав", "Ветеринар", 5);
IEmployee employee4 = new Employee("Иваныч", "Уборщик", 5);

//ДОБАВЛЕНИЕ СОТРУДНИКОВ В ЗООПАРК
zoo.HireEmployee(employee1); //Принят
zoo.HireEmployee(employee1); //Уже работает
zoo.HireEmployee(employee2); //Не принят (не хватает опыта работы)
zoo.HireEmployee(employee3); //Принят

//ВЫВОД ВСЕХ РАБОТНИКОВ ЗООПАРКА    
zoo.ListEmployees();

//УВОЛЬНЕНИЕ СОТРУДНИКОВ ЗООПАРКА
Console.WriteLine("УВОЛЬНЕНИЕ СОТРУДНИКА ЗООПАРКА");
zoo.FireEmployee(employee3);

Console.WriteLine("УВОЛЬНЕНИЕ НЕ СОТРУДНИКА ЗООПАРКА");
zoo.FireEmployee(employee2);

//ПРОВЕРКА ЖИВОТНОГО СОТРУДНИКОМ
Console.WriteLine("ПРОВЕРКА ЖИВОТНОГО");
employee3.CheckAnimal(mammal1);

//ПРОВЕРКА ВСЕХ ЖИВОТНЫХ
Console.WriteLine("ПРОВЕРКА ВСЕХ ЖИВОТНЫХ");
zoo.CheckAllAnimals();

//КОРМЛЕНИЕ ЖИВОТНОГО
Console.WriteLine("КОРМЛЕНИЕ ОДНОГО ЖИВОТНОГО");
employee1.FeedAnimal(mammal1);

//КОРМЛЕНИЕ ВСЕХ ЖИВОТНЫХ
Console.WriteLine("КОРМЛЕНИЕ ВСЕХ ЖИВОТНЫХ");
zoo.FeedAllAnimals();