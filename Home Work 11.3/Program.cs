                    // Тема 11 Задание 3 

Random random = new Random();
Console.Write("Введите число от 0 до 5: ");
int numb = int.Parse(Console.ReadLine());
int a = random.Next(0, 5);

if (numb > a) Console.WriteLine("Поражение :(");
else if (numb < a) Console.WriteLine("Поражение :( ");
else Console.WriteLine("Вы выйграли :) ");

