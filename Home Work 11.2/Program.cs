// Тема 11 задание 2

Console.Write("Укажите сколько сейчас градусов на улице: ");
int Temperature = int .Parse(Console.ReadLine());

if (Temperature > 20) Console.WriteLine(" Сегодня можно выпустить слонов, жирафов и львов");
else if (Temperature < 20) Console.WriteLine("Сегодня можно выпустить медведей,волков и пингвинов");
else Console.WriteLine("Сегодня можно выпустить  только кенгуру ");