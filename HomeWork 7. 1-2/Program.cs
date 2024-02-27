// Домашка Задание 1.
Console.Write("Введите радиус окружности: ");
double radius = double.Parse(Console.ReadLine());

const double pi = Math.PI;
Console.WriteLine($"Ваш результат {pi * radius * radius:F2}");

// Домашка Задание 2+3: Написать досье, изучить структуру DateTime

DateTime currenDate = DateTime.Now;
Console.WriteLine(currenDate);

Console.Write("Привет user, введи свое имя ");
string name = Console.ReadLine();

Console.Write($"Отлично{name}, теперь введи свою фамилию ");
string surName = Console.ReadLine();

Console.Write($"Прекрасно {surName} {name}, а сейчас введи свой возраст: ");
int age = int.Parse(Console.ReadLine());

Console.Write($"{name}, раскажи кем ты работаешь:");
string profession = Console.ReadLine();

Console.WriteLine($"Значит ты у нас {profession}, какакя кличка у твоей собаки? ");
string namePet = Console.ReadLine();

Console.WriteLine($"{name}, расскажи как зовут твою жену?");
string nameWife = Console.ReadLine();

Console.WriteLine("Какой твой любимый вид спорта?");
string loveSport = Console.ReadLine();

Console.WriteLine($"{name}, в каком море ты любишь купаться?");
string loveSea = Console.ReadLine();

Console.WriteLine("Какой ты бы хотел иметь дом?");
string home = Console.ReadLine();

Console.WriteLine("Какой язык ты знаешь?");
string language = Console.ReadLine();

Console.WriteLine($"Получается ты у нас {surName} {name}, тебе {age} лет\nТы работаешь {profession}, твою собаку зовут{namePet}\n " +
    $"Твою жену зовут {nameWife}, ты любишь {loveSport}\nТы любишь купаться {loveSea}, хочешь себе дом {home}\nТы знаешь {language}");


