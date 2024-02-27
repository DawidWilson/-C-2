                    // Тема 11 Задание 3 

Random random = new Random();
Console.Write("Введите число от 0 до 5: ");
int numb = int.Parse(Console.ReadLine());
random.Next(0, 5);

if (numb > random) Console.WriteLine("Вы выйграли :)");
else if (numb < random ) Console.WriteLine("Поражение :( ")


